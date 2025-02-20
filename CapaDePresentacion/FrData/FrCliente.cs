using CapaDePresentacion.FrComplementos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapadeNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CapaDePresentacion.FrAuxiliares;


namespace CapaDePresentacion
{
    public partial class FrCliente : Form
    {
        public FrCliente()
        {
            InitializeComponent();
        }

        private void FrCliente_Load(object sender, EventArgs e)
        {
            ListaEstado.SelectedIndex = 0;
            ListaEstado.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void ListaEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int FiltroEstado = 0;

            //  0: clientes no deseados, 1: activos, 2: inactivos, 3: sin distinción

            switch (ListaEstado.SelectedIndex)
            {
                case 0: FiltroEstado = 1; TablaCliente.Columns["btnEliminar"].Visible = true; break;
                case 1: FiltroEstado = 2; TablaCliente.Columns["btnEliminar"].Visible = true; break;
                case 2: FiltroEstado = 0; TablaCliente.Columns["btnEliminar"].Visible = false; break;
                case 3: FiltroEstado = 3; TablaCliente.Columns["btnEliminar"].Visible = false; break;
                default: FiltroEstado = 1; break;
            }

            MostrarClientes(FiltroEstado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusquedaCliente.Texts))
            {
                FrConfirmacion Comunidado = new FrConfirmacion("Por favor ingrese un nombre o identificador para la busqueda", 1);
                Comunidado.ShowDialog();
                return;
            }
            BusquedaCliente();
        }

        public void MostrarClientes(int FiltroEstado)
        {
            CN_Clientes OJCliente = new CN_Clientes();
            
            DataTable dtClientes = OJCliente.VistaClienteFiltro(FiltroEstado);

            TablaCliente.Rows.Clear();


            foreach (DataRow row in dtClientes.Rows)
            {
                int rowIndex = TablaCliente.Rows.Add();
                TablaCliente.Rows[rowIndex].Cells["DOCUMENTO"].Value = row["DOCUMENTO"];
                TablaCliente.Rows[rowIndex].Cells["NUMERO"].Value = row["NUMERO"];
                TablaCliente.Rows[rowIndex].Cells["NOMBRE"].Value = row["NOMBRE"];
                TablaCliente.Rows[rowIndex].Cells["APELLIDO"].Value = row["APELLIDO"];
                TablaCliente.Rows[rowIndex].Cells["TELEFONO"].Value = row["TELEFONO"];
                TablaCliente.Rows[rowIndex].Cells["CORREO"].Value = row["CORREO"];
                TablaCliente.Rows[rowIndex].Cells["ESTADO"].Value = row["ESTADO"];

                FormatearEstado(TablaCliente.Rows[rowIndex].Cells["ESTADO"]);


            }

            TablaCliente.ClearSelection();
            TablaCliente.CurrentCell = null;
        }

        public void BusquedaCliente()
        {
            CN_Clientes OJCliente = new CN_Clientes();

            DataTable BuscarCliente = OJCliente.BuscarCliente(txtBusquedaCliente.Texts, ListaEstado.Text);

            TablaCliente.Rows.Clear();

            if (BuscarCliente.Rows.Count == 0)
            {
                FrConfirmacion Informe = new FrConfirmacion("No se encontro ningun cliente con " + txtBusquedaCliente.Texts, 1);
                Informe.ShowDialog();
                MostrarClientes(1);
                return;
            }
            foreach (DataRow row in BuscarCliente.Rows)
            {
                int rowIndex = TablaCliente.Rows.Add();
                TablaCliente.Rows[rowIndex].Cells["DOCUMENTO"].Value = row["DOCUMENTO"];
                TablaCliente.Rows[rowIndex].Cells["NUMERO"].Value = row["NUMERO"];
                TablaCliente.Rows[rowIndex].Cells["NOMBRE"].Value = row["NOMBRE"];
                TablaCliente.Rows[rowIndex].Cells["APELLIDO"].Value = row["APELLIDO"];
                TablaCliente.Rows[rowIndex].Cells["TELEFONO"].Value = row["TELEFONO"];
                TablaCliente.Rows[rowIndex].Cells["CORREO"].Value = row["CORREO"];
                TablaCliente.Rows[rowIndex].Cells["ESTADO"].Value = row["ESTADO"];

                FormatearEstado(TablaCliente.Rows[rowIndex].Cells["ESTADO"]);


            }

            TablaCliente.ClearSelection();
            TablaCliente.CurrentCell = null;
        }

        private void FormatearEstado(DataGridViewCell celda)
        {
            if (celda.Value != null)
            {
                int estado = Convert.ToInt32(celda.Value);
                celda.Style.Font = new Font(TablaCliente.Font, FontStyle.Bold);
                switch (estado)
                {
                    case 0: // NO DESEADO
                        celda.Style.BackColor = Color.Black;
                        celda.Style.ForeColor = Color.White;
                        celda.Value = "NO DESEADO";
                        break;
                    case 1: // ACTIVO
                        celda.Style.BackColor = Color.Green;
                        celda.Style.ForeColor = Color.White;
                        celda.Value = "ACTIVO";
                        break;
                    case 2: // INACTIVO
                        celda.Style.BackColor = Color.White;
                        celda.Style.ForeColor = Color.Black;
                        celda.Value = "INACTIVO";
                        break;
                }
            }
        }


        private void TablaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Seccion cuando se presiona un boton de la tabla de clientes de editar
                if (TablaCliente.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    var FilaSeleccionada = TablaCliente.Rows[e.RowIndex];

                    string Documento = FilaSeleccionada.Cells["DOCUMENTO"].Value.ToString();
                    string Numero = FilaSeleccionada.Cells["NUMERO"].Value.ToString();
                    string Nombre = FilaSeleccionada.Cells["NOMBRE"].Value.ToString();
                    string Apellido = FilaSeleccionada.Cells["APELLIDO"].Value.ToString();
                    string Telefono = FilaSeleccionada.Cells["TELEFONO"].Value.ToString();
                    string Correo = FilaSeleccionada.Cells["CORREO"].Value.ToString();
                    string Estado = FilaSeleccionada.Cells["ESTADO"].Value.ToString();

                    FrGestionCliente NuevoCliente = new FrGestionCliente(Numero,Documento,Nombre,Apellido,Telefono,Correo,Estado);
                    NuevoCliente.FormClosing += (s, args) => MostrarClientes(1);
                    ListaEstado.SelectedIndex = 0;
                    NuevoCliente.ShowDialog();

                }

                if (TablaCliente.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    var FilaSeleccionada = TablaCliente.Rows[e.RowIndex];
                    string Identificacion = FilaSeleccionada.Cells["NUMERO"].Value.ToString();
                    string NombreCompleto = FilaSeleccionada.Cells["NOMBRE"].Value.ToString() + " " + FilaSeleccionada.Cells["APELLIDO"].Value.ToString();
                    string Estado = FilaSeleccionada.Cells["ESTADO"].Value.ToString();

                    string Mensaje = "";

                    if(Estado == "ACTIVO")
                    {
                        Mensaje = "El cliente" + NombreCompleto + " no se eliminara solo cambiara a estado de INACTIVO ";
                    }else if(Estado == "INACTIVO")
                    {
                        Mensaje = "El cliente" + NombreCompleto + " se establecera como cliente no deseado para el hotel";
                    }

                    using (FrConfirmacion ConfirmarPregunta = new FrConfirmacion(Mensaje, 0))
                    {
                        ConfirmarPregunta.ShowDialog();
                        if (ConfirmarPregunta.Resultado)
                        {
                            CN_Clientes ObjetoCliente = new CN_Clientes();

                            if(Estado == "ACTIVO")
                            {
                                 var (Resultado,Reporte) = ObjetoCliente.ModificarEstado(Identificacion, 2);

                                FrAlerta Informe = new FrAlerta(Reporte, 2000);

                            }
                            else if (Estado == "INACTIVO")
                            {
                                var(Resultado, Reporte) = ObjetoCliente.ModificarEstado(Identificacion, 0);

                                FrAlerta Informe = new FrAlerta(Reporte, 2000);
                            }
                        }
                    }
                    ListaEstado.SelectedIndex = 1;
                    MostrarClientes(1);
                }
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrGestionCliente NuevoCliente = new FrGestionCliente();

            NuevoCliente.FormClosing += (s, args) => MostrarClientes(1);
            ListaEstado.SelectedIndex = 0;
            NuevoCliente.ShowDialog();
        }


    }
}
