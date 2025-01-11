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
            PanelMenu.Visible = false;
            PanelCHECK.Visible = false;
            PanelHabitacion.Visible = false;
            PanelPersonal.Visible = false;
            PanelReporte.Visible = false;
            PanelReserva.Visible = false;
            PanelServicio.Visible = false;
            PanelCliente.Visible = false;
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

            PanelMenu.Visible = false;
            PanelCHECK.Visible = false;
            PanelHabitacion.Visible = false;
            PanelPersonal.Visible = false;
            PanelReporte.Visible = false;
            PanelReserva.Visible = false;
            PanelServicio.Visible = false;
            PanelCliente.Visible = false;

            elegido.Visible = true;
        }

        private void AjustarBotones()
        {
            UtilidadForm.AjustarBoton(btnMenuPrincipal, EstadoPanelOpcion, "MENU PRINCIPAL");
            UtilidadForm.AjustarBoton(btnResumen, EstadoPanelOpcion, "RESUMEN GENERAL");
            UtilidadForm.AjustarBoton(btnAlerta, EstadoPanelOpcion, "ALERTAS");
            UtilidadForm.AjustarBoton(btnReserva, EstadoPanelOpcion, "RESERVA");
            UtilidadForm.AjustarBoton(btnNewReserva, EstadoPanelOpcion, "NUEVA RESERVA");
            UtilidadForm.AjustarBoton(btnListaReserva, EstadoPanelOpcion, "LISTA RESERVA");
            UtilidadForm.AjustarBoton(btnHistorialReser, EstadoPanelOpcion, "HISTORIAL");
            UtilidadForm.AjustarBoton(btnHabitacion, EstadoPanelOpcion, "HABITACION");
            UtilidadForm.AjustarBoton(btnVerHabitacion, EstadoPanelOpcion, "VER HABITACION");
            UtilidadForm.AjustarBoton(btnEstadoHabitacion, EstadoPanelOpcion, "ESTADO");
            UtilidadForm.AjustarBoton(btnCheck, EstadoPanelOpcion, "CHECK-IN/CHECK-OUT");
            UtilidadForm.AjustarBoton(btnCheckIn, EstadoPanelOpcion, "CHECK-IN");
            UtilidadForm.AjustarBoton(btnCheckOut, EstadoPanelOpcion, "CHECK-OUT");
            UtilidadForm.AjustarBoton(btnServicio, EstadoPanelOpcion, "SERVICIOS");
            UtilidadForm.AjustarBoton(btnServEstablecidos, EstadoPanelOpcion, "ESTABLECIDOS");
            UtilidadForm.AjustarBoton(btnServImprevisto, EstadoPanelOpcion, "IMPREVISTOS");
            UtilidadForm.AjustarBoton(btnReporte, EstadoPanelOpcion, "REPORTES");
            UtilidadForm.AjustarBoton(btnFinanciero, EstadoPanelOpcion, "FINANCIEROS");
            UtilidadForm.AjustarBoton(btnCliente, EstadoPanelOpcion, "CLIENTES");
            UtilidadForm.AjustarBoton(btnPersonal, EstadoPanelOpcion, "GESTION PERSONAL");
            UtilidadForm.AjustarBoton(btnNewPersonal, EstadoPanelOpcion, "NUEVO PERSONAL");
            UtilidadForm.AjustarBoton(btnListaPersonal, EstadoPanelOpcion, "LISTA PERSONAL");
            UtilidadForm.AjustarBoton(btnGestionCliente, EstadoPanelOpcion, "GESTION CLIENTE");
            UtilidadForm.AjustarBoton(btnNuevoCliente, EstadoPanelOpcion, "NUEVO CLIENTE");
            UtilidadForm.AjustarBoton(btnListaCliente, EstadoPanelOpcion, "LISTA CLIENTE");
        }
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {

            //UtilidadForm.AlternarVisibilidad(PanelMenu);
            AjustarOpciones(PanelMenu);

        }

        private void bntReserva_Click(object sender, EventArgs e)
        {
            //UtilidadForm.AlternarVisibilidad(PanelReserva);
            AjustarOpciones(PanelReserva);
        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            //UtilidadForm.AlternarVisibilidad(PanelHabitacion);
            AjustarOpciones(PanelHabitacion);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //UtilidadForm.AlternarVisibilidad(PanelCHECK);
            AjustarOpciones(PanelCHECK);
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            // UtilidadForm.AlternarVisibilidad(PanelServicio);
            AjustarOpciones(PanelServicio);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            // UtilidadForm.AlternarVisibilidad(PanelReporte);
            AjustarOpciones(PanelReporte);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            // UtilidadForm.AlternarVisibilidad(PanelPersonal);
            AjustarOpciones(PanelPersonal);
        }
        private void btnGestionCliente_Click(object sender, EventArgs e)
        {
            //UtilidadForm.AlternarVisibilidad(PanelCliente);
            AjustarOpciones(PanelCliente);
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FrLogin fr = new FrLogin();
            fr.Show();
        }

    }
}
