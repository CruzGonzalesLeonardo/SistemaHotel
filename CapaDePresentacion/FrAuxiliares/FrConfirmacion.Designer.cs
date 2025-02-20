namespace CapaDePresentacion.FrAuxiliares
{
    partial class FrConfirmacion
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
            this.PanelPadre = new System.Windows.Forms.Panel();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnNo = new Sipaa.Framework.SButton();
            this.btnSi = new Sipaa.Framework.SButton();
            this.btnOK = new Sipaa.Framework.SButton();
            this.PanelPadre.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPadre
            // 
            this.PanelPadre.BackColor = System.Drawing.Color.White;
            this.PanelPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPadre.Controls.Add(this.btnOK);
            this.PanelPadre.Controls.Add(this.PanelTitulo);
            this.PanelPadre.Controls.Add(this.btnNo);
            this.PanelPadre.Controls.Add(this.btnSi);
            this.PanelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPadre.Location = new System.Drawing.Point(0, 0);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(306, 139);
            this.PanelPadre.TabIndex = 0;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.Controls.Add(this.lblMensaje);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(304, 93);
            this.PanelTitulo.TabIndex = 7;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Metropolis Black", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMensaje.Location = new System.Drawing.Point(6, 35);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(297, 19);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "MENSAJE DE CONFIRMACION";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.White;
            this.btnNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.btnNo.BorderRadius = 6;
            this.btnNo.BorderSize = 1;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Metropolis Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnNo.Location = new System.Drawing.Point(183, 99);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(118, 32);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(22)))), ((int)(((byte)(9)))));
            this.btnSi.BorderColor = System.Drawing.Color.White;
            this.btnSi.BorderRadius = 6;
            this.btnSi.BorderSize = 1;
            this.btnSi.FlatAppearance.BorderSize = 0;
            this.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSi.Font = new System.Drawing.Font("Metropolis Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.ForeColor = System.Drawing.Color.White;
            this.btnSi.Location = new System.Drawing.Point(10, 99);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(118, 32);
            this.btnSi.TabIndex = 6;
            this.btnSi.Text = "SI";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnOK
            // 
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(22)))), ((int)(((byte)(9)))));
            this.btnOK.BorderRadius = 6;
            this.btnOK.BorderSize = 1;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Metropolis Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(22)))), ((int)(((byte)(9)))));
            this.btnOK.Location = new System.Drawing.Point(94, 99);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(124, 32);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(306, 139);
            this.Controls.Add(this.PanelPadre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrConfirmacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrConfirmacion";
            this.Load += new System.EventHandler(this.FrConfirmacion_Load);
            this.PanelPadre.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPadre;
        private System.Windows.Forms.Label lblMensaje;
        private Sipaa.Framework.SButton btnNo;
        private Sipaa.Framework.SButton btnSi;
        private System.Windows.Forms.Panel PanelTitulo;
        private Sipaa.Framework.SButton btnOK;
    }
}