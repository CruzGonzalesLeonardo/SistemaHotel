using CapaDePresentacion.FrComplementos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class FrCliente : Form
    {
        public FrCliente()
        {
            InitializeComponent();
        }

        private void FrCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrGestionCliente form = new FrGestionCliente();
            form.ShowDialog();
        }
    }
}
