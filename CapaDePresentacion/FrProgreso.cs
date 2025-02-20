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
    public partial class FrProgreso : Form
    {
        private int currentIndex = 0;
        private string Salido = "BIENVENIDO USUARIO";
        private string fullTitle = "";
        private Timer fadeOutTimer = new Timer(); // Timer para manejar la transición de desvanecimiento

        private int IDUser = 0;
        private string RolUser;
        private string NombreUser;
        private string cargo;


        public FrProgreso(int iDUser, string Usuario, string rolUser,string CargoSucursalUser)
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.Magenta;
            this.TransparencyKey = System.Drawing.Color.Magenta;


            MovForm.EnableFormDrag(this, this);

            fullTitle = fullTitle + Usuario;
            lblTituloUsuario.Text = string.Empty;

            // Configurar el Timer de desvanecimiento
            fadeOutTimer.Interval = 50; // Intervalo en milisegundos
            fadeOutTimer.Tick += FadeOutTimer_Tick;

            IDUser = iDUser;
            RolUser = rolUser;
            NombreUser = Usuario;
            cargo = CargoSucursalUser;
        }

        private void FrProgreso_Load(object sender, EventArgs e)
        {

            timerTitulo.Start();
        }

        private void timerTitulo_Tick(object sender, EventArgs e)
        {
            if (currentIndex < fullTitle.Length)
            {
                lblTituloUsuario.Text += fullTitle[currentIndex];
                currentIndex++;
            }
            else
            {
                timerTitulo.Stop();
                StartFadeOut(); // Iniciar la transición al finalizar el texto
            }
        }

        private void StartFadeOut()
        {
            fadeOutTimer.Start(); // Inicia el timer para desvanecer
        }

        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05; // Reducir gradualmente la opacidad
            }
            else
            {
                fadeOutTimer.Stop();
                TransitionToOtherForm(); // Pasar al siguiente formulario cuando el desvanecimiento termine
            }
        }

        private void TransitionToOtherForm()
        {
            // Crear el siguiente formulario (FrInicio en este caso)
            FrInicio siguienteForm = new FrInicio(IDUser,NombreUser, RolUser,cargo);

            // Mostrar el siguiente formulario
            siguienteForm.Opacity = 0; // Inicialmente invisible
            siguienteForm.Show();

            // Animar la aparición del siguiente formulario
            Timer fadeInTimer = new Timer();
            fadeInTimer.Interval = 50; // Intervalo en milisegundos
            fadeInTimer.Tick += (s, ev) =>
            {
                if (siguienteForm.Opacity < 1)
                {
                    siguienteForm.Opacity += 0.05; // Incrementar gradualmente la opacidad
                }
                else
                {
                    fadeInTimer.Stop();
                    this.Close(); // Cerrar el formulario actual
                }
            };
            fadeInTimer.Start();
        }
    }
}
