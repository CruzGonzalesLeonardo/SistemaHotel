using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Drawing;


namespace CapaDePresentacion
{
    public static class UtilidadForm
    {
        public static void AlternarVisibilidad(System.Windows.Forms.Panel panel)
        {
            panel.Visible = !panel.Visible;
        }

        public static void AjustarBoton(System.Windows.Forms.Button boton, bool encojido,string Titulo)
        {
            
            if (encojido)
            {
                // Ocultar texto y centrar la imagen
                boton.Text = "";
                boton.ImageAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                // Restaurar texto e imagen alineados
                boton.Text = Titulo;
                boton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
    }
}
