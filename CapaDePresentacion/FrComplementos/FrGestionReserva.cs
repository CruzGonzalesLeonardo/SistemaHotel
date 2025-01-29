using CapaDePresentacion.FrAuxiliares;
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
    public partial class FrGestionReserva : Form
    {
        string Numeral, Tipo, Estado, Precio, Descripcion;

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrGestionCliente ClienteNuevo = new FrGestionCliente();
            ClienteNuevo.ShowDialog();
        }

        private void CalenEntrada_ValueChanged(object sender, EventArgs e)
        {
            /*
            if (CalenSalida.Value < CalenEntrada.Value)
            {
                CalenSalida.Value = CalenEntrada.Value;
                FrAlerta Aviso = new FrAlerta("No puede ingresar una fecha menor a la fecha de ingreso", 1000);
                Aviso.Show();
            }
            */
            CalenSalida.MinDate = CalenEntrada.Value;
            CalcularDias();
        }

        private void CalenSalida_ValueChanged(object sender, EventArgs e)
        {
            /*
            if (CalenSalida.Value < CalenEntrada.Value)
            {
                CalenSalida.Value = CalenEntrada.Value;
                FrAlerta Aviso = new FrAlerta("No puede ingresar una fecha menor a la fecha de ingreso", 1000);
                Aviso.Show();
            }*/

            CalcularDias();
        }
        private void CalcularDias()
        {
            int dias = (CalenSalida.Value.Date - CalenEntrada.Value.Date).Days;
            lblDias.Text = "DIAS: "+dias.ToString();
        }

        private void btnCancelarServicios_Click(object sender, EventArgs e)
        {
            PanelServicios.Visible = false;
            this.Size = new Size(787, 487);
            this.CenterToScreen();
        }

        private void btnActivarServicio_Click(object sender, EventArgs e)
        {
            PanelServicios.Visible = true;
            this.Size = new Size(1195, 487);
            this.CenterToScreen();
        }

        public FrGestionReserva(string NumeroCuarto, string TipoCuarto, string EstadoCuarto, string PrecioCuarto, string DescripcionCuarto)
        {
            InitializeComponent();
            
            PanelServicios.Visible = false;
            this.Size = new Size(787, 487);
            Numeral = NumeroCuarto;
            Tipo = TipoCuarto;
            Estado = EstadoCuarto;
            Precio = PrecioCuarto;
            Descripcion = DescripcionCuarto;
        }
        private void FrGestionReserva_Load(object sender, EventArgs e)
        {
            lblNumero.Text = Numeral;
            lblTipo.Text = Tipo;
            lblPrecio.Text = Precio;
            lblDescripcion.Text = Descripcion;


            switch (Convert.ToInt32(Estado)) {
                case 1:
                    lblEstado.BackColor = Color.Green;
                    lblEstado.Text = "Disponible";
                    break;
                case 2:
                    lblEstado.BackColor = Color.Blue;
                    lblEstado.Text = "Reservado";
                    break;
                default:
                    lblEstado.BackColor = Color.Red;
                    lblEstado.Text = "ERROR!";
                    break;
            }
        }

    }
}
