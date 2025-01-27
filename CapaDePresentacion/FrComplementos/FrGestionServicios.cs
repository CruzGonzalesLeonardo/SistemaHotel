using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.FrComplementos
{
    public partial class FrGestionServicios : Form
    {
        public FrGestionServicios()
        {
            InitializeComponent();

            MovForm.EnableFormDrag(this, this);
            MovForm.EnableFormDrag(this, Titulo);
            MovForm.EnableFormDrag(this, panel1);
            MovForm.EnableFormDrag(this, panel2);
            MovForm.EnableFormDrag(this, panel3);
            MovForm.EnableFormDrag(this, panel4);
            MovForm.EnableFormDrag(this, tableLayoutPanel1);

            this.Padding = new Padding(2);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crear un lápiz (Pen) de color negro y grosor 2
            using (Pen blackPen = new Pen(Color.Black, 2))
            {
                // Dibujar un rectángulo alrededor del formulario
                Rectangle borderRect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
                e.Graphics.DrawRectangle(blackPen, borderRect);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
