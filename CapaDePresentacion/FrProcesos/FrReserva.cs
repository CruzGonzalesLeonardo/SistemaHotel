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
    public partial class FrReserva : Form
    {
        public FrReserva()
        {
            InitializeComponent();
        }
    

    private void GenerarPaneles()
     {
            // Limpia el panel padre
            panelContenedor.Controls.Clear();
            // Configura el tamaño de los paneles personalizados
            int panelWidth = 254; // Ancho de cada panel
            int panelHeight = 151; // Alto de cada panel
            int margen = 10; // Espacio entre paneles

            // Calcula cuántos paneles caben en una fila según el tamaño del panel padre
            int panelesPorFila = Math.Max(1, (panelContenedor.Width - margen) / (panelWidth + margen));

            int x = margen;
            int y = margen;
            int contador = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (!fila.IsNewRow)
                {
                    // Crea un nuevo PanelCliente
                    UcPanelHabitacion panelCliente = new UcPanelHabitacion
                    {
                        Nombre = fila.Cells["Nombre"].Value?.ToString() ?? "",
                        Apellido = fila.Cells["Apellido"].Value?.ToString() ?? "",
                        Telefono = fila.Cells["Telefono"].Value?.ToString() ?? "",
                        Size = new Size(panelWidth, panelHeight),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Validación y asignación de color según el estado
                    if (int.TryParse(fila.Cells["Estado"].Value?.ToString(), out int estado))
                    {
                        switch (estado)
                        {
                            case 1:
                                panelCliente.BackColor = Color.Green;
                                break;
                            case 2:
                                panelCliente.BackColor = Color.Yellow;
                                break;
                            case 3:
                                panelCliente.BackColor = Color.Red;
                                break;
                            default:
                                panelCliente.BackColor = Color.LightGray;
                                break;
                        }
                    }
                    else
                    {
                        panelCliente.BackColor = Color.LightGray; // Valor predeterminado
                    }

                    // Ubica el panel dinámicamente
                    panelCliente.Location = new Point(x, y);

                    // Añade el panel al contenedor
                    panelContenedor.Controls.Add(panelCliente);

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
    private void CargarDatos()
        {
            // Simula datos para el DataGridView
            dataGridView1.DataSource = ObtenerDatosClientes();

            // Genera los paneles
            GenerarPaneles();
        }

        private DataTable ObtenerDatosClientes()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Telefono");
            tabla.Columns.Add("Estado"); // Columna Estado

            tabla.Rows.Add("José", "Pérez", "123456789", 1);
            tabla.Rows.Add("Ana", "García", "987654321", 2);
            tabla.Rows.Add("Luis", "Martínez", "567890123", 3);
            tabla.Rows.Add("María", "Rodríguez", "345678901", 1);
            tabla.Rows.Add("Carlos", "López", "234567890", 3);
            tabla.Rows.Add("Sofía", "Hernández", "876543210", 2);
            tabla.Rows.Add("Miguel", "Gómez", "135792468", 1);
            tabla.Rows.Add("Lucía", "Díaz", "246813579", 3);
            tabla.Rows.Add("Juan", "Vargas", "112233445", 2);
            tabla.Rows.Add("Laura", "Romero", "998877665", 1);

            tabla.Rows.Add("Diego", "Navarro", "564738291", 2);
            tabla.Rows.Add("Paula", "Castro", "123987456", 3);
            tabla.Rows.Add("Javier", "Ortega", "789456123", 1);
            tabla.Rows.Add("Camila", "Ramos", "987321654", 2);
            tabla.Rows.Add("Andrés", "Silva", "654987321", 3);
            tabla.Rows.Add("Elena", "Morales", "321654987", 1);
            tabla.Rows.Add("Fernando", "Soto", "159753468", 2);
            tabla.Rows.Add("Isabel", "Cabrera", "753159846", 3);
            tabla.Rows.Add("Diana", "Mendoza", "456123789", 1);
            tabla.Rows.Add("Héctor", "Guzmán", "951753852", 2);

            tabla.Rows.Add("Valeria", "Paredes", "123654789", 3);
            tabla.Rows.Add("Esteban", "Lara", "852741963", 1);
            tabla.Rows.Add("Carolina", "Medina", "369258147", 2);
            tabla.Rows.Add("Pedro", "Torres", "741852963", 3);
            tabla.Rows.Add("Patricia", "Vega", "987456321", 1);
            tabla.Rows.Add("Gabriel", "Flores", "654123987", 2);
            tabla.Rows.Add("Monica", "Reyes", "321789456", 3);
            tabla.Rows.Add("Ramón", "Ortiz", "789321654", 1);
            tabla.Rows.Add("Claudia", "Peña", "963852741", 2);
            tabla.Rows.Add("Daniel", "Fernández", "147258369", 3);


            return tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
