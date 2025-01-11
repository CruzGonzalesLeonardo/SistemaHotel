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
        private string fullTitle = "BIENVENIDO USUARIO: ";
        private Timer fadeOutTimer = new Timer(); // Timer para manejar la transición de desvanecimiento

        public FrProgreso(string Usuario)
        {
            InitializeComponent();

            MovForm.EnableFormDrag(this, this);

            fullTitle = fullTitle + Usuario;
            lblTitulo.Text = string.Empty;

            // Configurar el Timer de desvanecimiento
            fadeOutTimer.Interval = 50; // Intervalo en milisegundos
            fadeOutTimer.Tick += FadeOutTimer_Tick;
        }

        private void FrProgreso_Load(object sender, EventArgs e)
        {
            timerTitulo.Start();
        }

        private void timerTitulo_Tick(object sender, EventArgs e)
        {
            if (currentIndex < fullTitle.Length)
            {
                lblTitulo.Text += fullTitle[currentIndex];
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
            FrInicio siguienteForm = new FrInicio();

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
