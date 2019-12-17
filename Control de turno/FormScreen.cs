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
    public partial class FormScreen : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"E:\Proyectos\Windows Form\control turno 2\Control de turno\Resources\doorBell.wav");

        public FormScreen()
        {

            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddNewTicket("");
        }
        int nro = 0;

        public void AddNewTicket(string responseTicket)
        {
            player.Play();
            if (LayoutPanelTicket.Controls.Count == 4)
            {
                LayoutPanelTicket.Controls.Remove(LayoutPanelTicket.Controls[0]);
            }
            ViewTicket vTicket = new ViewTicket();
            nro++;
            vTicket.NroATM = nro.ToString("D2");
            vTicket.NroTicket = responseTicket;
            LayoutPanelTicket.Controls.Add(vTicket);
            //vTicket.AddColorToAnimation();

        }

        private void FormScreen_AutoSizeChanged(object sender, EventArgs e)
        {
        }

        private void FormScreen_Load(object sender, EventArgs e)
        {
            LayoutPanelTicket.Width = this.Width;
            LayoutPanelTicket.Location = new Point(0, this.Height - LayoutPanelTicket.Height - 40);

            axWindowsMediaPlayer1.Width = this.Width;
            axWindowsMediaPlayer1.Height = this.Height - LayoutPanelTicket.Height - 40;
            axWindowsMediaPlayer1.URL = @"E:\Proyectos\Windows Form\control turno 2\Control de turno\Resources\Wildlife.wmv";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
