using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CapaDePresentacion.FrAuxiliares
{
    public partial class FrConfirmacion : Form
    {
        public bool Resultado { get; private set; } = false;

        private string Mensaje;
        public FrConfirmacion(string mensaje)
        {
            InitializeComponent();
            Mensaje = mensaje;

            MovForm.EnableFormDrag(this, this);
            MovForm.EnableFormDrag(this, PanelPadre); 
            MovForm.EnableFormDrag(this, PanelTitulo);
            MovForm.EnableFormDrag(this, lblMensaje);


        }

        private string AjustarTexto(string texto, int anchoPanel)
        {
            Font fuente = new Font("Metropolis Black", 14);

            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                string[] palabras = texto.Split(' ');
                string lineaActual = "";
                string textoFinal = "";

                foreach (string palabra in palabras)
                {
                    string lineaConPalabra = lineaActual + (lineaActual.Length > 0 ? " " : "") + palabra;
                    SizeF tamanoLinea = g.MeasureString(lineaConPalabra, fuente);

                    if (tamanoLinea.Width > anchoPanel)
                    {
                        textoFinal += lineaActual + "\n";
                        lineaActual = palabra; 
                    }
                    else
                    {
                        lineaActual = lineaConPalabra; 
                    }
                }
                textoFinal += lineaActual;
                return textoFinal;
            }
        }

        private void FrConfirmacion_Load(object sender, EventArgs e)
        {
            int anchoPanel = PanelPadre.Width - 10;
            String TextoAjustado = AjustarTexto(Mensaje, anchoPanel);
            lblMensaje.Text = TextoAjustado;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            Resultado = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Resultado = false;
            this.Close();
        }
    }
}
