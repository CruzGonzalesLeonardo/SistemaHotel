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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureHotel
            // 
            this.PictureHotel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PictureHotel.Image = ((System.Drawing.Image)(resources.GetObject("PictureHotel.Image")));
            this.PictureHotel.Location = new System.Drawing.Point(291, 0);
            this.PictureHotel.Name = "PictureHotel";
            this.PictureHotel.Size = new System.Drawing.Size(285, 282);
            this.PictureHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureHotel.TabIndex = 0;
            this.PictureHotel.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(547, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(29, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderColor = System.Drawing.Color.Blue;
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.Lime;
            this.txtUsuario.BorderRadius = 0;
            this.txtUsuario.BorderSize = 2;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 10F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(20, 74);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtUsuario.PlaceholderText = "Nombre de Ususario";
            this.txtUsuario.Size = new System.Drawing.Size(241, 29);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtContraseña.BorderColor = System.Drawing.Color.Blue;
            this.txtContraseña.BorderFocusColor = System.Drawing.Color.Lime;
            this.txtContraseña.BorderRadius = 0;
            this.txtContraseña.BorderSize = 2;
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 10F);
            this.txtContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña.Location = new System.Drawing.Point(20, 144);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContraseña.PasswordChar = true;
            this.txtContraseña.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtContraseña.PlaceholderText = "Ingresar Contraseña";
            this.txtContraseña.Size = new System.Drawing.Size(241, 31);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.Texts = "";
            this.txtContraseña.UnderlinedStyle = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Blue;
            this.btnIngresar.BorderColor = System.Drawing.Color.White;
            this.btnIngresar.BorderRadius = 10;
            this.btnIngresar.BorderSize = 0;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(80, 210);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(126, 35);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "LOGIN";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(93, 24);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(95, 22);
            this.Titulo.TabIndex = 7;
            this.Titulo.Text = "USUARIO";
            // 
            // TituErrorContraseña
            // 
            this.TituErrorContraseña.AutoSize = true;
            this.TituErrorContraseña.ForeColor = System.Drawing.Color.Red;
            this.TituErrorContraseña.Location = new System.Drawing.Point(17, 179);
            this.TituErrorContraseña.Name = "TituErrorContraseña";
            this.TituErrorContraseña.Size = new System.Drawing.Size(86, 13);
            this.TituErrorContraseña.TabIndex = 8;
            this.TituErrorContraseña.Text = "Error Contraseña";
            // 
            // TituErrorUsuario
            // 
            this.TituErrorUsuario.AutoSize = true;
            this.TituErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.TituErrorUsuario.Location = new System.Drawing.Point(17, 107);
            this.TituErrorUsuario.Name = "TituErrorUsuario";
            this.TituErrorUsuario.Size = new System.Drawing.Size(68, 13);
            this.TituErrorUsuario.TabIndex = 9;
            this.TituErrorUsuario.Text = "Error Usuario";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(310, 247);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // FrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(576, 282);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.TituErrorUsuario);
            this.Controls.Add(this.TituErrorContraseña);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.PictureHotel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrLogin";
            ((System.ComponentModel.ISupportInitialize)(this.PictureHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}