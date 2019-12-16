namespace Control_de_turno
{
    partial class ViewTicket
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitleTicket = new System.Windows.Forms.Label();
            this.labelTitleCajero = new System.Windows.Forms.Label();
            this.labelNroTicket = new System.Windows.Forms.Label();
            this.labelNroATM = new System.Windows.Forms.Label();
            this.labelRow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitleTicket
            // 
            this.labelTitleTicket.AutoSize = true;
            this.labelTitleTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitleTicket.Location = new System.Drawing.Point(9, 11);
            this.labelTitleTicket.Name = "labelTitleTicket";
            this.labelTitleTicket.Size = new System.Drawing.Size(106, 25);
            this.labelTitleTicket.TabIndex = 0;
            this.labelTitleTicket.Text = "Nro. Ticket";
            // 
            // labelTitleCajero
            // 
            this.labelTitleCajero.AutoSize = true;
            this.labelTitleCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCajero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitleCajero.Location = new System.Drawing.Point(190, 11);
            this.labelTitleCajero.Name = "labelTitleCajero";
            this.labelTitleCajero.Size = new System.Drawing.Size(70, 25);
            this.labelTitleCajero.TabIndex = 1;
            this.labelTitleCajero.Text = "Cajero";
            // 
            // labelNroTicket
            // 
            this.labelNroTicket.AutoSize = true;
            this.labelNroTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNroTicket.Location = new System.Drawing.Point(6, 54);
            this.labelNroTicket.Name = "labelNroTicket";
            this.labelNroTicket.Size = new System.Drawing.Size(101, 46);
            this.labelNroTicket.TabIndex = 2;
            this.labelNroTicket.Text = "T-00";
            // 
            // labelNroATM
            // 
            this.labelNroATM.AutoSize = true;
            this.labelNroATM.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroATM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNroATM.Location = new System.Drawing.Point(196, 54);
            this.labelNroATM.Name = "labelNroATM";
            this.labelNroATM.Size = new System.Drawing.Size(64, 46);
            this.labelNroATM.TabIndex = 3;
            this.labelNroATM.Text = "00";
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRow.Location = new System.Drawing.Point(113, 54);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(69, 46);
            this.labelRow.TabIndex = 4;
            this.labelRow.Text = "-->";
            // 
            // ViewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.labelRow);
            this.Controls.Add(this.labelNroATM);
            this.Controls.Add(this.labelNroTicket);
            this.Controls.Add(this.labelTitleCajero);
            this.Controls.Add(this.labelTitleTicket);
            this.Name = "ViewTicket";
            this.Size = new System.Drawing.Size(278, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleTicket;
        private System.Windows.Forms.Label labelTitleCajero;
        private System.Windows.Forms.Label labelNroTicket;
        private System.Windows.Forms.Label labelNroATM;
        private System.Windows.Forms.Label labelRow;
    }
}
