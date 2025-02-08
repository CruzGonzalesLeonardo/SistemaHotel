using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeDatos
{
    public class CD_Conexion
    {
        public SqlConnection Conexion = new SqlConnection("Server=(local);DataBase= DBHotelCusco;Integrated Security=true");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
        public bool VerificarConexion()
        {
            try
            {
                AbrirConexion();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }

    }
}
