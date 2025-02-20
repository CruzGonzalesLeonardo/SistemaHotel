using CapadeNegocio;
using CapaDePresentacion.FrAuxiliares;
using Sipaa.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.FrComplementos
{
    public partial class FrGestionCliente : Form
    {
        private bool NuevoCliente = true;
        public FrGestionCliente()
        {
            InitializeComponent();
            NuevoCliente = true;

            Titulo.Text = "Agregando Nuevo Cliente";

            txtNumeroDocumento.PlaceholderText = "Ingrese el nombre del Cliente";
            txtNombreCliente.PlaceholderText = "Ingrese el nombre del Cliente";
            txtApellidoCliente.PlaceholderText = "Ingrese el apellido del Cliente";
            txtTelefonoCliente.PlaceholderText = "Ingrese el N° de Celular";
            txtCorreoCliente.PlaceholderText = "Ingrese el correo electronico";

            ListaEstado.Visible = false;
            labelTitulo.Visible = false;
            PanelEstado.Visible = false;

        }

        public FrGestionCliente(string Numero, string Documento, string Nombre, string Apellido, string Telefono, string Correo, string Estado)
        {
            InitializeComponent();
            NuevoCliente = false;

            Titulo.Text = "Editando Cliente Existente";

            ListaTipoDocumeno.SelectedItem = Documento;
            ListaTipoDocumeno.Enabled = false;
            txtNumeroDocumento.Texts = Numero.ToString();
            txtNumeroDocumento.Enabled = false;
            txtNombreCliente.Texts = Nombre.ToString();
            txtApellidoCliente.Texts = Apellido.ToString();
            txtTelefonoCliente.Texts = Telefono.ToString();
            txtCorreoCliente.Texts = Correo.ToString();

            ListaEstado.SelectedItem = Estado;

        
        }
        private void FrGestionCliente_Load(object sender, EventArgs e)
        {
            ListaTipoDocumeno.Focus();

            MovForm.EnableFormDrag(this, this);
            MovForm.EnableFormDrag(this, Titulo);
            MovForm.EnableFormDrag(this, panel1);
            MovForm.EnableFormDrag(this, panel2);
            MovForm.EnableFormDrag(this, panel3);
            MovForm.EnableFormDrag(this, panel4);
            MovForm.EnableFormDrag(this, panel6);


            this.Padding = new Padding(2);
            
            labelResultado.Visible = false;
            ListaTipoDocumeno.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (NuevoCliente)
            {
                if (ListaTipoDocumeno.SelectedItem == null)
                {
                    FrConfirmacion Comunidado = new FrConfirmacion("Por favor eliga el documento del cliente", 1);
                    Comunidado.ShowDialog();
                    return;
                }
                else if (string.IsNullOrEmpty(txtNumeroDocumento.Texts)) 
                {
                    FrConfirmacion Comunidado = new FrConfirmacion("Por favor ingrese el numero de identificacion del cliente", 1);
                    Comunidado.ShowDialog();
                    return;
                }
                else if (string.IsNullOrEmpty(txtNombreCliente.Texts))
                {
                    FrConfirmacion Comunidado = new FrConfirmacion("Por favor ingrese el nombre del cliente", 1);
                    Comunidado.ShowDialog();
                    return;
                }
                else if (string.IsNullOrEmpty(txtApellidoCliente.Texts))
                {
                    FrConfirmacion Comunidado = new FrConfirmacion("Por favor ingrese el apellido del cliente", 1);
                    Comunidado.ShowDialog();
                    return;
                }
                else if (string.IsNullOrEmpty(txtTelefonoCliente.Texts) && string.IsNullOrEmpty(txtCorreoCliente.Texts))
                {
                    FrConfirmacion Comunidado = new FrConfirmacion("Por favor ingrese un modo para comunicarse con el cliente (telefono o correo)", 1);
                    Comunidado.ShowDialog();
                    return;
                }
                CN_Clientes NuevoCliente = new CN_Clientes();

                string TelefonoCliente = string.IsNullOrWhiteSpace(txtTelefonoCliente.Texts) ? null : txtTelefonoCliente.Texts;
                string CorreoCliente = string.IsNullOrWhiteSpace(txtCorreoCliente.Texts) ? null : txtCorreoCliente.Texts;
                string DocumentoCliente = ListaTipoDocumeno.Text;


                var (Estado,Mensaje) = NuevoCliente.InsertarCliente(txtNumeroDocumento.Texts,DocumentoCliente,txtNombreCliente.Texts,txtApellidoCliente.Texts,TelefonoCliente,CorreoCliente);

                FrAlerta Alerta = new FrAlerta(Mensaje, 2000);
                Alerta.Show();

                if(Estado== "Éxito")
                {
                    this.Close();
                }
                else
                {
                    FrConfirmacion InfoError = new FrConfirmacion("Se producio un error al guardar los datos", 1);
                    InfoError.ShowDialog();
                }
            }
            else if (!NuevoCliente)
            {
                if (string.IsNullOrEmpty(txtNombreCliente.Texts))
                {
                    FrConfirmacion Comunidado = new FrConfirmacion("Por favor ingrese el nombre del cliente", 1);
                    Comunidado.ShowDialog();
                    return;
                }
                else if (string.IsNullOrEmpty(txtApellidoCliente.Texts))
                {
                    FrConfirmacion Comunidado = new FrConfirmacion("Por favor ingrese el apellido del cliente", 1);
                    Comunidado.ShowDialog();
                    return;
                }
                else if (string.IsNullOrEmpty(txtTelefonoCliente.Texts) && string.IsNullOrEmpty(txtCorreoCliente.Texts))
                {
                    FrConfirmacion Comunidado = new FrConfirmacion("Por favor ingrese un modo para comunicarse con el cliente (telefono o correo)", 1);
                    Comunidado.ShowDialog();
                    return;
                }
                string TelefonoCliente = string.IsNullOrWhiteSpace(txtTelefonoCliente.Texts) ? null : txtTelefonoCliente.Texts;
                string CorreoCliente = string.IsNullOrWhiteSpace(txtCorreoCliente.Texts) ? null : txtCorreoCliente.Texts;
                string DocumentoCliente = ListaTipoDocumeno.Text;

                CN_Clientes NuevoCliente = new CN_Clientes();

                var (Informe, Mensajes) = NuevoCliente.ModificarCliente(txtNumeroDocumento.Texts, DocumentoCliente, txtNombreCliente.Texts, txtApellidoCliente.Texts, TelefonoCliente, CorreoCliente, ListaEstado.Text);
                FrAlerta Alerta = new FrAlerta(Mensajes, 2000);
                Alerta.Show();

                if (Informe == "Éxito")
                {
                    this.Close();
                }
                else
                {
                    FrConfirmacion InfoError = new FrConfirmacion("Se producio un error al guardar los datos", 1);
                    InfoError.ShowDialog();
                }
            }
        }

        private void ListaEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaEstado.SelectedIndex != -1)
            {
                switch (ListaEstado.SelectedIndex)
                {
                    case 0:
                        PanelEstado.BackColor = Color.Green;
                        break;
                    case 1:
                        PanelEstado.BackColor = Color.Orange;
                        break;
                    case 2:
                        PanelEstado.BackColor = Color.Black;
                        break;
                    default:
                        PanelEstado.BackColor = Color.White;
                        break;
                }
            }
        }

        private void txtNumeroDocumento_Leave(object sender, EventArgs e)
        {
            if(NuevoCliente && !string.IsNullOrEmpty(txtNumeroDocumento.Texts))
            {
                CN_Clientes ConsultaCliente =  new CN_Clientes();

                var(Mensaje,Estado)= ConsultaCliente.ValidarExistencia(txtNumeroDocumento.Texts);
                labelResultado.Visible = true;
                labelResultado.Text = Mensaje.ToString();
                if (Estado == 1)
                {
                    labelResultado.ForeColor = Color.Red;
                    btnConfirmar.Enabled = false;
                }else if(Estado == 0)
                {
                    labelResultado.ForeColor = Color.Green;
                    btnConfirmar.Enabled = true;
                }else if(Estado == 99)
                {
                    labelResultado.ForeColor = Color.Blue;
                    btnConfirmar.Enabled = false;
                }
            }
        }
    }
}
