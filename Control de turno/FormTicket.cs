using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_turno
{
    public partial class FormTicket : Form
    {
        int contador = 0;
        List<string> listTicket = new List<string>();
        FormScreen formScreen = new FormScreen();
        public FormTicket()
        {
            InitializeComponent();
            formScreen.Show();
            MessageBox.Show(ClientSocket.ConnectToServer("TICKETERO"));
            Thread thread = new Thread(startThread);
            thread.Start();
        }
        void startThread()
        {
            string respuesta = "";
            while (true)
            {
                respuesta = ClientSocket.ReceiveResponse();
                if (respuesta != "error message receive")
                {
                    //listBox1.Items.Add(respuesta);
                    try
                    {
                        this.Invoke((MethodInvoker)delegate {

                            formScreen.AddNewTicket(respuesta);
                            });
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
            contador++;
            var valorTicket = "C-" + contador.ToString("D2");
            MessageBox.Show("Ticket: "+ valorTicket);
            listTicket.Add(valorTicket);
            ClientSocket.RequestLoop("TICKETERO:"+valorTicket);
        }
    }
}
