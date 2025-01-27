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
    public partial class FrGestionPersonal : Form
    {
        public FrGestionPersonal()
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
