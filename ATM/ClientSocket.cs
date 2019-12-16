using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATM

{
    class ClientSocket
    {
        public static readonly Socket clientSocket = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private const int PORT = 100;

        //static void Main()
        //{
        //    Console.Title = "Client";
        //    ConnectToServer();
        //    RequestLoop();
        //    Exit();
        //}

        public static string ConnectToServer(string nickUser)
        {
            int attempts = 0;

            while (!clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    //Console.WriteLine("Connection attempt " + attempts);
                    // Change IPAddress.Loopback to a remote IP to connect to a remote host.
                    clientSocket.Connect(IPAddress.Loopback, PORT);
                }
                catch (SocketException e)
                {
                    //Console.Clear();
                    return e.Message;
                }
            }
            SendString("["+nickUser+"]");
            //Console.Clear();
            //Console.WriteLine("Connected");
            return "Connected";
        }

        public static string RequestLoop(string message)
        {
            //Console.WriteLine(@"<Type ""exit"" to properly disconnect client>");

            //while (true)
            //if (clientSocket.Connected)
            //{
                SendString(message);
                return ReceiveResponse();
            //}
            //return "Connection not initialized";
            //}
        }

        /// <summary>
        /// Close socket and exit program.
        /// </summary>
        private static void Exit()
        {
            SendString("exit"); // Tell the server we are exiting
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            Environment.Exit(0);
        }

        private static void SendRequest(string message)
        {
            //Console.Write("Send a request: ");
            //string request = Console.ReadLine();
            //SendString(request);
              
             
            //if (request.ToLower() == "exit")
            //{
            //    Exit();
            //}
        }

        /// <summary>
        /// Sends a string to the server with ASCII encoding.
        /// </summary>
        private static void SendString(string text)
        {
            
                byte[] buffer = Encoding.ASCII.GetBytes(text);
                clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
            
        }

        public static string ReceiveResponse()
        {
            var buffer = new byte[2048];
            int received = clientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return "error message receive";
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            string text = Encoding.ASCII.GetString(data);
            return text;
        }
    }
}
