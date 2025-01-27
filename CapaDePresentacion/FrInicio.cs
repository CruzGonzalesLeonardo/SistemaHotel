using CapaDePresentacion.FrData;
using CapaDePresentacion.FrProcesos;
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

    public partial class FrInicio : Form
    {
        bool EstadoPanelOpcion = true; // Estado actual del panel
        Timer animacionTimer = new Timer();
        int panelStep = 10; // Velocidad del deslizamiento
        int panelAnchoMinimo = 40; // Ancho mínimo deseado
        int panelAnchoMaximo = 200; // Ancho máximo deseado

        public FrInicio()
        {
            InitializeComponent();
            var workingArea = Screen.PrimaryScreen.WorkingArea;
            this.Bounds = workingArea;

            animacionTimer.Interval = 20; // Intervalo en ms
            animacionTimer.Tick += AnimarPanel;
        }

        private void FrInicio_Load(object sender, EventArgs e)
        {
            PanelReporte.Visible = false;
            PanelReserva.Visible = false;
            PanelMantenimiento.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e) {Application.Exit();}


        private void btnMinimizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;

        }
       

        bool Estado = true;
        private void btnEstado_Click(object sender, EventArgs e)
        {
            switch (Estado)
            {
                case true: { this.WindowState = FormWindowState.Maximized; Estado = false; break; }
                case false: { this.WindowState = FormWindowState.Normal; Estado = true; break; }
            }

         
        }



        private void AnimarPanel(object sender, EventArgs e)
        {
            if (EstadoPanelOpcion) // Ocultando el panel
            {
                if (PnOpciones.Width > panelAnchoMinimo)
                {
                    PnOpciones.Width = Math.Max(PnOpciones.Width - panelStep, panelAnchoMinimo); // Reducir y limitar el ancho mínimo
                }
                else
                {
                    TerminarAnimacion(panelAnchoMinimo, false); // Terminar con el ancho mínimo
                }
            }
            else // Mostrando el panel
            {
                if (PnOpciones.Width < panelAnchoMaximo)
                {
                    PnOpciones.Width = Math.Min(PnOpciones.Width + panelStep, panelAnchoMaximo); // Aumentar y limitar el ancho máximo
                }
                else
                {
                    TerminarAnimacion(panelAnchoMaximo, true); // Terminar con el ancho máximo
                }
            }
        }

        private void TerminarAnimacion(int anchoFinal, bool nuevoEstado)
        {
            PnOpciones.Width = anchoFinal; // Asegurarse de que el ancho sea exacto
            animacionTimer.Stop(); // Detener el Timer
            EstadoPanelOpcion = nuevoEstado; // Actualizar el estado
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!animacionTimer.Enabled) // Evitar superposiciones de animaciones
            {
                animacionTimer.Start();
                AjustarBotones();

            }
        }

        private void AjustarOpciones(Panel elegido)
        {
            if (elegido.Visible)
            {
                elegido.Visible = false;
                return;
            }


            PanelReporte.Visible = false;
            PanelReserva.Visible = false;
            PanelMantenimiento.Visible = false;

            elegido.Visible = true;
        }

        private void AjustarBotones()
        {
            UtilidadForm.AjustarBoton(btnMenuPrincipal, EstadoPanelOpcion, "MENU PRINCIPAL");
            UtilidadForm.AjustarBoton(btnRecepcion, EstadoPanelOpcion, "RESERVA");
            UtilidadForm.AjustarBoton(btnReserva, EstadoPanelOpcion, "NUEVA RESERVA");
            UtilidadForm.AjustarBoton(btnListaReserva, EstadoPanelOpcion, "LISTA RESERVA");
            UtilidadForm.AjustarBoton(btnCheckIn, EstadoPanelOpcion, "CHECK-IN");
            UtilidadForm.AjustarBoton(btnGestionServicios, EstadoPanelOpcion, "ESTABLECIDOS");
            UtilidadForm.AjustarBoton(btnGestionHabitaciones, EstadoPanelOpcion, "IMPREVISTOS");

        }
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            AjustarOpciones(PanelReserva);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            AjustarOpciones(PanelReporte);
        }


        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            AjustarOpciones(PanelMantenimiento);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FrLogin fr = new FrLogin();
            fr.Show();
        }

        private void AbrirForm(object formHijo)
        {
            if (this.PanelHijo.Controls.Count > 0)
                this.PanelHijo.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelHijo.Controls.Add(fh);
            this.PanelHijo.Tag = fh;
            fh.Show();
        }

        private void btnGestionCliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrCliente());
        }

        private void btnGestionHabitaciones_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrHabitacion());
        }

        private void btnGestionPersonal_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrPersonal());   
        }

        private void btnGestionServicios_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrServicios());
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrReservas());
        }
    }
}
