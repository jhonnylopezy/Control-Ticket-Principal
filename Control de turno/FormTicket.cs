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
        public FormTicket()
        {
            InitializeComponent();
            MessageBox.Show(ClientSocket.ConnectToServer("TICKETERO"));
            //Thread thread = new Thread(startThread);
            //thread.Start();
        }
        void startThread()
        {
            
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
