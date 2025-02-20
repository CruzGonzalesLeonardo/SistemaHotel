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

namespace CapaDePresentacion.FrAuxiliares
{
    public partial class PanelCuartoInfo : UserControl
    {
        int NumeroEstado;
        public PanelCuartoInfo()
        {
            InitializeComponent();
        }

        public string NumeroCuarto
        {
            get => TituloNumero.Text;
            set => TituloNumero.Text = value;
        }

        public string Tipo
        {
            get => TituloTipo.Text;
            set => TituloTipo.Text = value;
        }

        public string EstadoHabitacion
        {
            get => btnEleccion.Text;
            set => btnEleccion.Text = value;
        }

        public string Estado
        {
            set
            {
                NumeroEstado = Convert.ToInt32(value);
                CambiarColor(NumeroEstado);
            }

        }

        public void CambiarColor( int estado)
        {
            //Existen 5 estados: disponible, Ocupado, Reservado, Limpieza
            switch (estado)
            {
                case 1:
                    PanelPadre.BackColor = Color.Green;
                    btnEleccion.Text = "Disponible";
                    break;
                case 2:
                    PanelPadre.BackColor = Color.Blue;
                    btnEleccion.Text = "Reservado";
                    break;
                case 3:
                    PanelPadre.BackColor = Color.Red;
                    btnEleccion.Text = "Ocupado";
                    break;
                case 4:
                    PanelPadre.BackColor = Color.Black;
                    btnEleccion.Text = "Limpieza";
                    break;
                default:
                    PanelPadre.BackColor = Color.Transparent;

                    break;
            }
        }

        private void btnEleccion_Click(object sender, EventArgs e)
        {
            if (NumeroEstado == 4)
            {
                string mensaje = "¿La habitacion " + TituloNumero.Text + " ya esta disponible?";
                using (FrConfirmacion confirmar = new FrConfirmacion(mensaje,0))
                {
                    confirmar.ShowDialog();
                    if (confirmar.Resultado)
                    {
                        PanelPadre.BackColor= Color.Green;
                        btnEleccion.Text = "Disponible";
                        //llamado a la base de datos para modificar
                        FrAlerta alerta = new FrAlerta("¡Se actualizo correctamente el estado de la habitacion!", 2000);
                        alerta.Show();
                    }
                }

            }
            else
            {
                FrGestionReserva Reserva = new FrGestionReserva(TituloNumero.Text,TituloTipo.Text,Convert.ToString(NumeroEstado),"13:00","Wifi,tele,doblecama,etc");
                Reserva.ShowDialog();

            }
            
        }
    }
}
