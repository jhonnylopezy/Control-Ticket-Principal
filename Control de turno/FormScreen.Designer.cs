namespace Control_de_turno
{
    partial class FormScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScreen));
            this.LayoutPanelTicket = new System.Windows.Forms.FlowLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutPanelTicket
            // 
            this.LayoutPanelTicket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LayoutPanelTicket.Location = new System.Drawing.Point(2, 328);
            this.LayoutPanelTicket.Name = "LayoutPanelTicket";
            this.LayoutPanelTicket.Size = new System.Drawing.Size(869, 120);
            this.LayoutPanelTicket.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(2, -2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(869, 292);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.TabStop = false;
            // 
            // FormScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.LayoutPanelTicket);
            this.Name = "FormScreen";
            this.Text = "FormScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.AutoSizeChanged += new System.EventHandler(this.FormScreen_AutoSizeChanged);
            this.Load += new System.EventHandler(this.FormScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelTicket;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}