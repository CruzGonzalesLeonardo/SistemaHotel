namespace CapaDePresentacion.FrAuxiliares
{
    partial class PanelCuartoInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelCuartoInfo));
            this.PanelPadre = new Sipaa.Framework.SPanel();
            this.btnEleccion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TituloTipo = new System.Windows.Forms.Label();
            this.TituloNumero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelPadre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPadre
            // 
            this.PanelPadre.BackColor = System.Drawing.Color.Black;
            this.PanelPadre.BorderColor = System.Drawing.Color.White;
            this.PanelPadre.BorderRadius = 10;
            this.PanelPadre.BorderSize = 0;
            this.PanelPadre.Controls.Add(this.btnEleccion);
            this.PanelPadre.Controls.Add(this.pictureBox1);
            this.PanelPadre.Controls.Add(this.TituloTipo);
            this.PanelPadre.Controls.Add(this.TituloNumero);
            this.PanelPadre.Controls.Add(this.label1);
            this.PanelPadre.ForeColor = System.Drawing.Color.White;
            this.PanelPadre.Location = new System.Drawing.Point(12, 13);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(228, 123);
            this.PanelPadre.TabIndex = 0;
            // 
            // btnEleccion
            // 
            this.btnEleccion.BackColor = System.Drawing.Color.Transparent;
            this.btnEleccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEleccion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEleccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEleccion.Font = new System.Drawing.Font("Metropolis Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEleccion.ForeColor = System.Drawing.Color.White;
            this.btnEleccion.Location = new System.Drawing.Point(0, 100);
            this.btnEleccion.Name = "btnEleccion";
            this.btnEleccion.Size = new System.Drawing.Size(228, 23);
            this.btnEleccion.TabIndex = 4;
            this.btnEleccion.Text = "Habitacion Libre";
            this.btnEleccion.UseVisualStyleBackColor = false;
            this.btnEleccion.Click += new System.EventHandler(this.btnEleccion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TituloTipo
            // 
            this.TituloTipo.AutoSize = true;
            this.TituloTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TituloTipo.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloTipo.ForeColor = System.Drawing.Color.White;
            this.TituloTipo.Location = new System.Drawing.Point(15, 62);
            this.TituloTipo.Name = "TituloTipo";
            this.TituloTipo.Size = new System.Drawing.Size(118, 19);
            this.TituloTipo.TabIndex = 2;
            this.TituloTipo.Text = "Matrimonial";
            // 
            // TituloNumero
            // 
            this.TituloNumero.AutoSize = true;
            this.TituloNumero.Font = new System.Drawing.Font("Russo One", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloNumero.ForeColor = System.Drawing.Color.White;
            this.TituloNumero.Location = new System.Drawing.Point(60, 17);
            this.TituloNumero.Name = "TituloNumero";
            this.TituloNumero.Size = new System.Drawing.Size(59, 36);
            this.TituloNumero.TabIndex = 1;
            this.TituloNumero.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Russo One", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "N°";
            // 
            // PanelCuartoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelPadre);
            this.Name = "PanelCuartoInfo";
            this.Size = new System.Drawing.Size(254, 151);
            this.PanelPadre.ResumeLayout(false);
            this.PanelPadre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sipaa.Framework.SPanel PanelPadre;
        private System.Windows.Forms.Label TituloTipo;
        private System.Windows.Forms.Label TituloNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEleccion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
