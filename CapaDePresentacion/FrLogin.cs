using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Sipaa.Framework;
using CapadeNegocio;
using System.Security.Cryptography.X509Certificates;

namespace CapaDePresentacion
{
    public partial class FrLogin : Form
    {

        public FrLogin()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.Blue;
            this.TransparencyKey = System.Drawing.Color.Blue;

            TituErrorUsuario.Visible = false;
            TituErrorContraseña.Visible = false;
            MovForm.EnableFormDrag(this, this);
            MovForm.EnableFormDrag(this, PanelFondo);
            MovForm.EnableFormDrag(this, PictureHotel);
            MovForm.EnableFormDrag(this, Titulo);
            MovForm.EnableFormDrag(this, txtUsuario);
            MovForm.EnableFormDrag(this,txtContraseña);
            MovForm.EnableFormDrag(this, TituErrorContraseña);
            MovForm.EnableFormDrag(this, TituErrorUsuario);

        }
        private void FrLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool HayError = false;

            if (string.IsNullOrWhiteSpace(txtUsuario.Texts)) {
                TituErrorUsuario.Text = "Por favor ingrese un usuario";
                TituErrorUsuario.Visible=true;
                HayError = true;
            }else 
            { 
                TituErrorUsuario.Visible=false;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Texts))
            {
                TituErrorContraseña.Text = "Por favor ingrese su contraseña";
                TituErrorContraseña.Visible = true;
                HayError = true;
            }else 
            { 
                TituErrorContraseña.Visible = false; 
            }

            if (HayError == true) { return; }


            CN_Usuario MiUsuario = new CN_Usuario();
            var (idUsuario, rol, responsable,cargoSucursal, mensaje) = MiUsuario.Login(txtUsuario.Texts, txtContraseña.Texts);

            if(idUsuario == 0)
            {
                if(mensaje == "Usuario no encontrado.")
                {
                    TituErrorUsuario.Text = mensaje;
                    TituErrorUsuario.Visible = true;
                }
                else if (mensaje == "Contraseña incorrecta.")
                {
                    TituErrorContraseña.Text = mensaje;
                    TituErrorContraseña.Visible = true;
                }
                else if (mensaje == "El usuario está inactivo. Contacte con el administrador.")
                {
                    TituErrorUsuario.Text = mensaje;
                    TituErrorUsuario.Visible = true;
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            //MessageBox.Show("Bienvenido " + responsable+" "+rol, "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TransitionToOtherForm(idUsuario, responsable, rol,cargoSucursal);

        }

        private void TransitionToOtherForm(int IDUsuario,string Nombre, string rol,string cargo)
        {
            FrProgreso siguienteForm = new FrProgreso(IDUsuario,Nombre,rol,cargo);

            for (double i = 1.0; i >= 0.0; i -= 0.05) // De 1 a 0, el cambio de opacidad
            {
                this.Opacity = i;
                System.Threading.Thread.Sleep(10); // Pausa breve para la transición visual
            }
            this.Hide(); 

            siguienteForm.Show();
            siguienteForm.Opacity = 0;

            // Hacer que el siguiente formulario se haga visible poco a poco
            for (double i = 0.0; i <= 1.0; i += 0.05)
            {
                siguienteForm.Opacity = i;
                System.Threading.Thread.Sleep(10);
            }
        }

    }


}
