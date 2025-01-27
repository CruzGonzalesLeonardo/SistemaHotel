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

namespace CapaDePresentacion.FrProcesos
{
    public partial class FrReservas : Form
    {
        public FrReservas()
        {
            InitializeComponent();
            DataPrueba.Visible = false;

        }
        private void FrReservas_Load(object sender, EventArgs e)
        {
            DataPrueba.DataSource = ObtenerDatosCuartos();
            GenerarPaneles();

        }
        private DataTable ObtenerDatosCuartos()
            {
                DataTable tabla = new DataTable();
                tabla.Columns.Add("NumeroCuarto", typeof(int)); // Número del cuarto
                tabla.Columns.Add("Tipo", typeof(string)); // Tipo del cuarto
                tabla.Columns.Add("Estado", typeof(int)); // Estado del cuarto (1 a 3)

                // Agregamos los datos de los cuartos
                tabla.Rows.Add(101, "Individual", 1);
                tabla.Rows.Add(102, "Doble", 2);
                tabla.Rows.Add(103, "Suite", 4);
                tabla.Rows.Add(104, "Individual", 1);
                tabla.Rows.Add(105, "Doble", 2);
                tabla.Rows.Add(106, "Suite", 3);
                tabla.Rows.Add(107, "Individual", 1);
                tabla.Rows.Add(108, "Doble", 3);
                tabla.Rows.Add(109, "Suite", 2);
                tabla.Rows.Add(110, "Individual", 1);

                tabla.Rows.Add(201, "Doble", 2);
                tabla.Rows.Add(202, "Suite", 4);
                tabla.Rows.Add(203, "Individual", 1);
                tabla.Rows.Add(204, "Doble", 2);
                tabla.Rows.Add(205, "Suite", 3);
                tabla.Rows.Add(206, "Individual", 1);
                tabla.Rows.Add(207, "Doble", 2);
                tabla.Rows.Add(208, "Suite", 3);
                tabla.Rows.Add(209, "Individual", 1);
                tabla.Rows.Add(210, "Doble", 2);

            return tabla;
            }

        private void GenerarPaneles()
        {
            // Limpia el panel padre
            PanelContenedor.Controls.Clear();
            // Configura el tamaño de los paneles personalizados
            int panelWidth = 254; // Ancho de cada panel
            int panelHeight = 151; // Alto de cada panel
            int margen = 10; // Espacio entre paneles

            // Calcula cuántos paneles caben en una fila según el tamaño del panel padre
            int panelesPorFila = Math.Max(1, (PanelContenedor.Width - margen) / (panelWidth + margen));

            int x = margen;
            int y = margen;
            int contador = 0;

            foreach (DataGridViewRow fila in DataPrueba.Rows)
            {
                if (!fila.IsNewRow)
                {
                    PanelCuartoInfo panelCuarto = new PanelCuartoInfo
                    {
                        NumeroCuarto = fila.Cells["NumeroCuarto"].Value?.ToString() ?? "",
                        Tipo = fila.Cells["Tipo"].Value?.ToString() ?? "",
                        Estado = fila.Cells["Estado"].Value?. ToString() ?? "",
                        Size = new Size(panelWidth, panelHeight),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Ubica el panel dinámicamente
                    panelCuarto.Location = new Point(x, y);
                    panelCuarto.BorderStyle = BorderStyle.None;
                    // Añade el panel al contenedor
                    PanelContenedor.Controls.Add(panelCuarto);

                    // Actualiza la posición para el siguiente panel
                    contador++;
                    if (contador % panelesPorFila == 0)
                    {
                        // Nueva fila
                        x = margen;
                        y += panelHeight + margen;
                    }
                    else
                    {
                        // Siguiente columna
                        x += panelWidth + margen;
                    }
                }
            }

        }
        private void btnProbarData_Click(object sender, EventArgs e)
        {
            GenerarPaneles();
        }

        private void btnMostrarData_Click(object sender, EventArgs e)
        {
            DataPrueba.Visible = !DataPrueba.Visible;
        }


    }
}   
