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
    public partial class FrAlerta : Form
    {
        private Timer _timer;
        private int _tiempoRestante;
        public FrAlerta( string mensaje, int duracion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None; 
            this.TopMost = true; 
            this.ShowInTaskbar = false; 
            this.BackColor = Color.FromArgb(170, 118, 0);

            var screen = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(screen.Width - this.Width - 10, screen.Height - this.Height - 10);

            Label lblMensaje = new Label
            {
                Text = mensaje,
                ForeColor = Color.White, 
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 50
            };
            PanelMensaje.Controls.Add(lblMensaje);

            ProgressBar progressBar = new ProgressBar
            {
                Dock = DockStyle.Bottom,
                Height = 10,
                Style = ProgressBarStyle.Continuous
            };
            this.Controls.Add(progressBar);

            _tiempoRestante = duracion;
            progressBar.Maximum = duracion;

            _timer = new Timer();
            _timer.Interval = 100; 
            _timer.Tick += (s, e) =>
            {
                _tiempoRestante -= 100;
                progressBar.Value = Math.Max(0, _tiempoRestante);

                if (_tiempoRestante <= 0)
                {
                    _timer.Stop();
                    this.Close();
                }
            };
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            _timer.Start();
        }

    }
}
