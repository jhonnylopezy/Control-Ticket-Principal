using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Control_de_turno
{

    public partial class Form1 : Form
    {
        Form2 form2 = new Form2(0);
        ClientSocket clientSocket = new ClientSocket();
        public Form1()
        {
            InitializeComponent();
            //form2.Show();
            
        }
        //public void InitTread()
        //{
        //    if (ClientSocket.clientSocket.Connected)
        //    {
        //        //while (true)
        //        //{
        //            Thread t = new Thread(listenServer);
        //            t.Start();
        //        //}
        //    }
        //}
        public void listenServer()
        {
            string respuesta = "";
            while (true)
            {
                respuesta = ClientSocket.ReceiveResponse();
                if (respuesta != "error message receive") {
                    //listBox1.Items.Add(respuesta);
                    try
                    {
                        this.Invoke((MethodInvoker)(() => listBox1.Items.Add(respuesta)));
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    //Debug.WriteLine("escuchando del server: "+ respuesta);
                }
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //form2.changeValueTicket();
            listBox1.Items.Add(ClientSocket.ConnectToServer());
            Thread t = new Thread(listenServer);
                t.Start();
            //InitTread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(ClientSocket.RequestLoop(textBox1.Text));
            ClientSocket.RequestLoop(textBox1.Text);
            textBox1.Text = "";
        }
    }
}
