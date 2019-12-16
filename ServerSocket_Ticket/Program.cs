using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ServerSocket_Ticket
{
    class Program
    {
        private static readonly Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static readonly List<ClientSocket> clientSockets = new List<ClientSocket>();
        private static readonly List<Ticket> listTickets = new List<Ticket>();
        private const int BUFFER_SIZE = 2048;
        private const int PORT = 100;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];

        static void Main()
        {
            Console.Title = "Server";
            SetupServer();
            while (true)
            {
                var message = Console.ReadLine(); // When we press enter close everything
                sendMessageAllClient(message);
            }
            //CloseAllSockets();
        }

        private static void SetupServer()
        {
            Console.WriteLine("Setting up server...");
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            serverSocket.Listen(0);
            serverSocket.BeginAccept(AcceptCallback, null);
            Console.WriteLine("Server setup complete");
        }

        /// <summary>
        /// Close all connected client (we do not need to shutdown the server socket as its connections
        /// are already closed with the clients).
        /// </summary>
        private static void sendMessageAllClient(string message)
        {

            foreach (var item in clientSockets)
            {
                byte[] data = Encoding.ASCII.GetBytes(message);
                item.socket.Send(data);
            }
        }
        private static void CloseAllSockets()
        {
            foreach (ClientSocket clientSocket in clientSockets)
            {
                clientSocket.socket.Shutdown(SocketShutdown.Both);
                clientSocket.socket.Close();
            }

            serverSocket.Close();
        }

        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException) // I cannot seem to avoid this (on exit when properly closing sockets)
            {
                return;
            }
            var clientSocket = new ClientSocket();
            clientSocket.socket = socket;
            clientSockets.Add(clientSocket);
            socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
            Console.WriteLine("Client connected, waiting for request...");

            serverSocket.BeginAccept(AcceptCallback, null);
        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;
            var resultClient = clientSockets.Where(t => t.socket == current).FirstOrDefault();
            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                Console.WriteLine("Client forcefully disconnected");
                // Don't shutdown because the socket may be disposed and its disconnected anyway.
                current.Close();
                clientSockets.Remove(resultClient);
                return;
            }
            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            if (text.Contains("[") && text.Contains("]"))
            {
                resultClient.nick = text.Replace("[", "").Replace("]", "");
            }
            else
            {
                Console.WriteLine("Received Text: " + text);
                var objText = text.Split(':');
                if(objText[0]== "TICKETERO")
                {
                    var ticket = new Ticket();
                    ticket.taken = false;
                    ticket.nro = objText[1];
                    listTickets.Add(ticket);
                }
                else
                {
                    var valueNro = "";
                    foreach (var item in listTickets)
                    {

                        if(item.taken == false)
                        {
                            valueNro = item.nro;
                            item.taken = true;
                            break;
                        }
                    }
                    
                    byte[] data = Encoding.ASCII.GetBytes(valueNro);
                    foreach (var item in clientSockets)
                    {
                        if (item.nick == "TICKETERO")
                            item.socket.Send(data);
                    }
                    current.Send(data);
                    Console.WriteLine("message from client");
                }
                
            }
            current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
        }
    }
}
