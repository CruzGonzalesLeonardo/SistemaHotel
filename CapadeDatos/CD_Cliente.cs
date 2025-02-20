using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapadeDatos
{
    public class CD_Cliente
    {
        private CD_Conexion ConectarBD = new CD_Conexion();

        public DataTable VistaClientes(int FiltroEstado)
        {
            DataTable Clientes = new DataTable();

            using (SqlCommand comando = new SqlCommand("PR_VISTA_CLIENTE", ConectarBD.AbrirConexion()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Estado", FiltroEstado);

                using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                {
                    adapter.Fill(Clientes);
                }

            }
            ConectarBD.CerrarConexion();
            return Clientes;

        }
        public DataTable ValidarIDCliente (string ID_Numero)
        {
            DataTable Resultado = new DataTable();

            using (SqlCommand comando = new SqlCommand("PR_VALIDAR_CLIENTE", ConectarBD.AbrirConexion()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID",ID_Numero);

                using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                {
                    adapter.Fill(Resultado);
                }
                ConectarBD.CerrarConexion();
                return Resultado;
            }
        }

        public DataTable InsertarNuevoCliente(string ID, string Documento, string Nombres, string Apellidos, string Telefono, string Correo)
        {
            DataTable Resultado = new DataTable();

            using(SqlCommand comando = new SqlCommand("PR_INSERT_CLIENTE", ConectarBD.AbrirConexion()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID",ID);
                comando.Parameters.AddWithValue("@TipoDocumento", Documento);
                comando.Parameters.AddWithValue("@Nombre", Nombres);
                comando.Parameters.AddWithValue("@Apellido", Apellidos);

                comando.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(Telefono) ? (object)DBNull.Value : Telefono);
                comando.Parameters.AddWithValue("@Correo", string.IsNullOrWhiteSpace(Correo) ? (object)DBNull.Value : Correo);

                using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                {
                    adapter.Fill(Resultado);
                }
            }

            ConectarBD.CerrarConexion();
            return Resultado;
        }

        public DataTable ModificarEstadoCliente(string NumeroIdentificador, int Estado)
        {
            DataTable Resultado = new DataTable();

            using(SqlCommand comando = new SqlCommand("PR_ALTER_CLIENTE_ESTADO", ConectarBD.AbrirConexion()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", NumeroIdentificador);
                comando.Parameters.AddWithValue("@Estado", Estado);

                using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                {
                    adapter.Fill(Resultado);
                }
            }
            ConectarBD.CerrarConexion();
            return Resultado;
        }

        public DataTable ModificarDatosClientes(string Numero, string Documento, string Nombres, string Apellidos, string Telefono, string Correo, int Estado)
        {
            DataTable Resultado = new DataTable();

            using (SqlCommand comando = new SqlCommand("PR_UPDATE_CLIENTE", ConectarBD.AbrirConexion()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", Numero);
                comando.Parameters.AddWithValue("@TipoDocumento", Documento);
                comando.Parameters.AddWithValue("@Nombre", Nombres);
                comando.Parameters.AddWithValue("@Apellido", Apellidos);

                comando.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(Telefono) ? (object)DBNull.Value : Telefono);
                comando.Parameters.AddWithValue("@Correo", string.IsNullOrWhiteSpace(Correo) ? (object)DBNull.Value : Correo);

                comando.Parameters.AddWithValue("@Estado", Estado);

                using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                {
                    adapter.Fill(Resultado);
                }
            }

            ConectarBD.CerrarConexion();
            return Resultado;
        }

        public DataTable BuscarClientes (string CadenaBusqueda, int Estado)
        {
            //Estado  -- 0: clientes no deseados, 1: activos, 2: inactivos, 3: sin distinción
            DataTable Resultado = new DataTable();

            using (SqlCommand comando = new SqlCommand("PR_BUSCAR_CLIENTE_ESTADO", ConectarBD.AbrirConexion()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Busqueda", CadenaBusqueda);
                comando.Parameters.AddWithValue("@Estado", Estado);

                using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                {
                    adapter.Fill(Resultado);
                }
            }

            ConectarBD.CerrarConexion();
            return Resultado;
        }
    }
}
