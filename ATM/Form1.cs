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

namespace ATM
{
    public partial class Form1 : Form
    {
        int milisegundo = 0;
        int segundo = 0;
        int minuto = 0;
         
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(ClientSocket.ConnectToServer("Cajero"));
            //Thread t = new Thread(InitListenServer);
            //t.Start();
            timer1.Stop();
        }
        public void InitListenServer()
        {
            var respuesta = "";
             while(true)
            {
                try
                {
                    respuesta = ClientSocket.ReceiveResponse();
                    this.Invoke((MethodInvoker)(() => labelNro.Text=respuesta));
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            milisegundo++;
            if (milisegundo == 60)
            {
                milisegundo = 0;
                segundo = segundo + 1;
                if (segundo == 60)
                {
                    segundo = 0;
                    minuto = minuto + 1;
                }
            }
            label3.Text = minuto.ToString("D2") +":"+segundo.ToString("D2")+":"+milisegundo.ToString("D2");
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //labelNro.Text = "C-10";
            var sendData = new SendData();
            sendData=
            var respuesta= ClientSocket.RequestLoop("Cajero&01: enviando Peticion");
            if (string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show("No hay ticket disponible para mostrar");
                labelNro.Text = "00";
            }
            else
            {
                labelNro.Text = respuesta;
            }
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
