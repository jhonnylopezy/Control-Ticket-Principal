using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_turno
{
    public partial class Form2 : Form
    {
        int ValorTicket = 0;
        public Form2(int valorParam)
        {
            ValorTicket = valorParam;
            InitializeComponent();
            //labelNro.Text =Convert.ToString(ValorTicket);
        }
        public void changeValueTicket()
        {
            ValorTicket++;
            //labelNro.Text = Convert.ToString(ValorTicket);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
