using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeDatos
{
    public class CD_Usuario
    {
        private CD_Conexion ConectarBD = new CD_Conexion();

        public DataTable ValidarUsuario(String Usuario, string Contraseñia)
        {
            DataTable Resultado = new DataTable();

            using (SqlCommand comando = new SqlCommand("PR_LOGIN", ConectarBD.AbrirConexion()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario",Usuario);
                comando.Parameters.AddWithValue("@Contraseña", Contraseñia);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(Resultado);

            }
            ConectarBD.CerrarConexion();
            return Resultado;
        }
    }
}
