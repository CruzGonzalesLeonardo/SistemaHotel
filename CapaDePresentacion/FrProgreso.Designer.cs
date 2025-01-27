namespace CapaDePresentacion
{
    partial class FrProgreso
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
            this.components = new System.ComponentModel.Container();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.timerTitulo = new System.Windows.Forms.Timer(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.sPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.BackColor = System.Drawing.Color.Black;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Russo One", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuario.ForeColor = System.Drawing.Color.White;
            this.lblTituloUsuario.Location = new System.Drawing.Point(27, 93);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(115, 35);
            this.lblTituloUsuario.TabIndex = 0;
            this.lblTituloUsuario.Text = "XXXXX";
            // 
            // timerTitulo
            // 
            this.timerTitulo.Tick += new System.EventHandler(this.timerTitulo_Tick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Black;
            this.lblTitulo.Font = new System.Drawing.Font("Russo One", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(17, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(372, 35);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "BIENVENIDO USUARIO";
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.Black;
            this.sPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.sPanel1.BorderRadius = 10;
            this.sPanel1.BorderSize = 2;
            this.sPanel1.Controls.Add(this.lblTitulo);
            this.sPanel1.Controls.Add(this.lblTituloUsuario);
            this.sPanel1.ForeColor = System.Drawing.Color.Black;
            this.sPanel1.Location = new System.Drawing.Point(73, 40);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(411, 162);
            this.sPanel1.TabIndex = 11;
            // 
            // FrProgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(576, 282);
            this.Controls.Add(this.sPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrProgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrProgreso";
            this.Load += new System.EventHandler(this.FrProgreso_Load);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.Timer timerTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Sipaa.Framework.SPanel sPanel1;
    }
}