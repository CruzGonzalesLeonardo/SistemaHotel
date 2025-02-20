using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using CapadeDatos;

namespace CapadeNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario OjUsuario = new CD_Usuario();

        public (int IDUsuario, string RolUsuario, string Responzable,string CargoSucursal, string MensajeProceso) Login (string Usuario, string Contraseña)
        {
            DataTable Resultado = OjUsuario.ValidarUsuario(Usuario,Contraseña);

            if (Resultado.Rows.Count > 0) 
            {
                int idUsuario = Resultado.Rows[0]["ID_Usuario"] != DBNull.Value ? Convert.ToInt32(Resultado.Rows[0]["ID_Usuario"]) : 0;
                string rol = Resultado.Rows[0]["RolUsuario"]?.ToString() ?? "";
                string responsable = Resultado.Rows[0]["Responsable"]?.ToString() ?? "";
                string CargoSucursal = Resultado.Rows[0]["CargoSucursal"]?.ToString() ?? "";
                string mensaje = Resultado.Rows[0]["Mensaje"]?.ToString() ?? "Error desconocido.";

                return (idUsuario, rol, responsable,CargoSucursal, mensaje);
            }
            else
            {
                return (0, "","","", "Error externo no se econtro ninguna fila en la tabla");
            }

        }
    }
}
