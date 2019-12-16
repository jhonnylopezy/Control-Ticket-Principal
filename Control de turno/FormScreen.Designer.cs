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
            this.button1 = new System.Windows.Forms.Button();
            this.LayoutPanelTicket = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LayoutPanelTicket
            // 
            this.LayoutPanelTicket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LayoutPanelTicket.Location = new System.Drawing.Point(2, 328);
            this.LayoutPanelTicket.Name = "LayoutPanelTicket";
            this.LayoutPanelTicket.Size = new System.Drawing.Size(869, 120);
            this.LayoutPanelTicket.TabIndex = 1;
            // 
            // FormScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.LayoutPanelTicket);
            this.Controls.Add(this.button1);
            this.Name = "FormScreen";
            this.Text = "FormScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.AutoSizeChanged += new System.EventHandler(this.FormScreen_AutoSizeChanged);
            this.Load += new System.EventHandler(this.FormScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelTicket;
    }
}