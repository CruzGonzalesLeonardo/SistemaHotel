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
    public partial class UcPanelHabitacion : UserControl
    {

        public UcPanelHabitacion()
        {
            InitializeComponent();
        }

        public string Nombre
        {
            get => lblNombre.Text;
            set => lblNombre.Text = value;
        }

        public string Apellido
        {
            get => lblApellido.Text;
            set => lblApellido.Text = value;
        }

        public string Telefono
        {
            get => lblTelefono.Text;
            set => lblTelefono.Text = value;
        }


        private void btnOpcion_Click(object sender, EventArgs e)
        {
            string mensaje = $"Nombre: {Nombre}\nApellido: {Apellido}\nTeléfono: {Telefono}";
            MessageBox.Show(mensaje, "Detalles del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
