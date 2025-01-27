namespace CapaDePresentacion
{
    partial class FrLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrLogin));
            this.PictureHotel = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtUsuario = new Sipaa.Framework.STextBox();
            this.txtContraseña = new Sipaa.Framework.STextBox();
            this.btnIngresar = new Sipaa.Framework.SButton();
            this.Titulo = new System.Windows.Forms.Label();
            this.TituErrorContraseña = new System.Windows.Forms.Label();
            this.TituErrorUsuario = new System.Windows.Forms.Label();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.PanelFondo = new Sipaa.Framework.SPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHotel)).BeginInit();
            this.sPanel1.SuspendLayout();
            this.PanelFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureHotel
            // 
            this.PictureHotel.Image = ((System.Drawing.Image)(resources.GetObject("PictureHotel.Image")));
            this.PictureHotel.Location = new System.Drawing.Point(12, 12);
            this.PictureHotel.Name = "PictureHotel";
            this.PictureHotel.Size = new System.Drawing.Size(250, 240);
            this.PictureHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureHotel.TabIndex = 0;
            this.PictureHotel.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(530, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(31, 27);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Black;
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.White;
            this.txtUsuario.BorderRadius = 10;
            this.txtUsuario.BorderSize = 1;
            this.txtUsuario.Font = new System.Drawing.Font("Metropolis Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(20, 34);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.txtUsuario.PlaceholderText = "Nombre de Ususario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 27);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Black;
            this.txtContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.txtContraseña.BorderFocusColor = System.Drawing.Color.White;
            this.txtContraseña.BorderRadius = 10;
            this.txtContraseña.BorderSize = 1;
            this.txtContraseña.Font = new System.Drawing.Font("Metropolis Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(20, 93);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContraseña.PasswordChar = true;
            this.txtContraseña.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.txtContraseña.PlaceholderText = "Ingresar Contraseña";
            this.txtContraseña.Size = new System.Drawing.Size(220, 27);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.Texts = "";
            this.txtContraseña.UnderlinedStyle = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnIngresar.BorderColor = System.Drawing.Color.White;
            this.btnIngresar.BorderRadius = 10;
            this.btnIngresar.BorderSize = 0;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(337, 205);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(152, 26);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "LOGIN";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.Titulo.Location = new System.Drawing.Point(57, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(142, 21);
            this.Titulo.TabIndex = 7;
            this.Titulo.Text = "BIENVENIDO";
            // 
            // TituErrorContraseña
            // 
            this.TituErrorContraseña.AutoSize = true;
            this.TituErrorContraseña.Font = new System.Drawing.Font("Metropolis Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituErrorContraseña.ForeColor = System.Drawing.Color.Red;
            this.TituErrorContraseña.Location = new System.Drawing.Point(76, 124);
            this.TituErrorContraseña.Name = "TituErrorContraseña";
            this.TituErrorContraseña.Size = new System.Drawing.Size(90, 10);
            this.TituErrorContraseña.TabIndex = 8;
            this.TituErrorContraseña.Text = "Error Contraseña";
            // 
            // TituErrorUsuario
            // 
            this.TituErrorUsuario.AutoSize = true;
            this.TituErrorUsuario.Font = new System.Drawing.Font("Metropolis Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.TituErrorUsuario.Location = new System.Drawing.Point(94, 65);
            this.TituErrorUsuario.Name = "TituErrorUsuario";
            this.TituErrorUsuario.Size = new System.Drawing.Size(72, 10);
            this.TituErrorUsuario.TabIndex = 9;
            this.TituErrorUsuario.Text = "Error Usuario";
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.Black;
            this.sPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.sPanel1.BorderRadius = 10;
            this.sPanel1.BorderSize = 3;
            this.sPanel1.Controls.Add(this.Titulo);
            this.sPanel1.Controls.Add(this.TituErrorUsuario);
            this.sPanel1.Controls.Add(this.txtUsuario);
            this.sPanel1.Controls.Add(this.TituErrorContraseña);
            this.sPanel1.Controls.Add(this.txtContraseña);
            this.sPanel1.ForeColor = System.Drawing.Color.Black;
            this.sPanel1.Location = new System.Drawing.Point(281, 47);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(259, 167);
            this.sPanel1.TabIndex = 10;
            // 
            // PanelFondo
            // 
            this.PanelFondo.BackColor = System.Drawing.Color.Black;
            this.PanelFondo.BorderColor = System.Drawing.Color.White;
            this.PanelFondo.BorderRadius = 20;
            this.PanelFondo.BorderSize = 1;
            this.PanelFondo.Controls.Add(this.btnSalir);
            this.PanelFondo.Controls.Add(this.sPanel1);
            this.PanelFondo.ForeColor = System.Drawing.Color.Black;
            this.PanelFondo.Location = new System.Drawing.Point(3, 7);
            this.PanelFondo.Name = "PanelFondo";
            this.PanelFondo.Size = new System.Drawing.Size(561, 249);
            this.PanelFondo.TabIndex = 11;
            // 
            // FrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 266);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.PictureHotel);
            this.Controls.Add(this.PanelFondo);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrLogin";
            ((System.ComponentModel.ISupportInitialize)(this.PictureHotel)).EndInit();
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.PanelFondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureHotel;
        private System.Windows.Forms.Button btnSalir;
        private Sipaa.Framework.STextBox txtUsuario;
        private Sipaa.Framework.STextBox txtContraseña;
        private Sipaa.Framework.SButton btnIngresar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label TituErrorContraseña;
        private System.Windows.Forms.Label TituErrorUsuario;
        private Sipaa.Framework.SPanel sPanel1;
        private Sipaa.Framework.SPanel PanelFondo;
    }
}