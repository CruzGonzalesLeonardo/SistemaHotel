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
    public partial class FrPersonal : Form
    {
        public FrPersonal()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrGestionPersonal fr = new FrGestionPersonal();
            fr.ShowDialog();
        }
    }
}
