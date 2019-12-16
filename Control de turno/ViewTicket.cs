using System;
using System.Diagnostics;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace Control_de_turno
{
    public partial class ViewTicket : UserControl
    {
        #region Property
        public Color BackgroundColor
        {
            get { return BackgroundColor; }
            set
            {
                //BackgroundColor = value;
                this.BackColor = value;
            }
        }
        public Color FontColor = Color.White;
        public string NroTicket
        {
            get { return NroTicket; }
            set
            {
                //NroTicket = value;
                labelNroTicket.Text = value;
            }
        }

        private System.Timers.Timer aTimer;
        public string NroATM
        {
            get { return NroATM; }
            set
            {
                //NroATM = value;
                labelNroATM.Text = value;
            }
        }
        #endregion

        static bool bandera = true;
        int contador = 0;
        public ViewTicket()
        {
            InitializeComponent();
            AddColorToAnimation();
            Debug.WriteLine("contador = "+contador);
           
        }

        public void AddColorToAnimation()
        {
            contador = 0;
            SetTimer();
        }
        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1200);
            // Hook up the Elapsed event for the timer. 
            //aTimer.Elapsed += OnTimedEvent;
            aTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimedEvent);
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
    
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (contador >= 5)
            {
                aTimer.Stop();
                bandera = false;
            }
            if (bandera)
            {
                this.BackColor = Color.Green;
                bandera = false;
            }
            else
            {
                this.BackColor = Color.Blue;
                bandera = true;
            }
            contador++;

        }
    }
}
