using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CapadeDatos;

namespace CapadeNegocio
{
    public class CN_Clientes
    {
        private CD_Cliente OJCliente = new CD_Cliente();

        public DataTable VistaClienteFiltro (int FiltroEstado)
        {
            DataTable DataCliente = OJCliente.VistaClientes(FiltroEstado);

            return DataCliente;
        }

        public (string Mensaje, int valor) ValidarExistencia(string ID_Numero)
        {
            DataTable Resultado = OJCliente.ValidarIDCliente(ID_Numero);

            int valor;

            if (Resultado.Rows.Count > 0)
            {
                valor = Resultado.Rows[0]["Existe"] != DBNull.Value ? Convert.ToInt32(Resultado.Rows[0]["Existe"]) : 0;    
                
            }
            else
            {
                valor = 99;
            }

            if(valor == 1)
            {
                return ("El usuario ya esta registrado",1);
            }
            else if(valor == 0)
            {
                return ("El identificador esta disponible",0);
            }
            else
            {
                return ("Existe un error del sistema",99);
            }
        }

        public (string Estado, string Mensaje) InsertarCliente (string Numero,string Documento,string Nombres, string Apellidos, string Telefono, string Correo)
        {
            DataTable Resultado = OJCliente.InsertarNuevoCliente(Numero, Documento, Nombres, Apellidos, Telefono, Correo);

            if (Resultado.Rows.Count > 0) 
            {
                string Estado = Resultado.Rows[0]["Estado"]?.ToString() ?? "";
                string Mensaje = Resultado.Rows[0]["Mensaje"]?.ToString() ?? "Error fuera de la BD";

                return (Estado,Mensaje);
            }
            else
            {
                return ("", "Error extenerno en la tabla recogida");
            }

        }

        public (string Estado, string Mensaje) ModificarEstado(string Identificador, int Estado)
        {
            DataTable Resultado = OJCliente.ModificarEstadoCliente(Identificador, Estado);

            if (Resultado.Rows.Count > 0)
            {
                string Proceso = Resultado.Rows[0]["Estado"]?.ToString() ?? "";
                string Mensaje = Resultado.Rows[0]["Mensaje"]?.ToString() ?? "Error fuera de la BD";

                return (Proceso, Mensaje);
            }
            else
            {
                return ("", "Error extenerno en la tabla recogida");
            }
        }

        
        public (string Estado, string Mensaje) ModificarCliente(string Numero, string Documento, string Nombres, string Apellidos, string Telefono, string Correo, string Estado)
        {
            int NumeralEstado = 1;

            if (Estado == "ACTIVO")
            {
                NumeralEstado = 1;
            }else if(Estado == "INACTIVO")
            {
                NumeralEstado = 2;
            }else if(Estado == "NO DESEADO")
            {
                NumeralEstado = 0;
            }else if(Estado == "Todos")
            {
                NumeralEstado = 3;
            }

            DataTable Resultado = OJCliente.ModificarDatosClientes(Numero, Documento, Nombres, Apellidos, Telefono, Correo,NumeralEstado);    

            if (Resultado.Rows.Count > 0)
            {
                string Proceso = Resultado.Rows[0]["Estado"]?.ToString() ?? "";
                string Mensaje = Resultado.Rows[0]["Mensaje"]?.ToString() ?? "Error fuera de la BD";

                return (Proceso, Mensaje);
            }
            else
            {
                return ("", "Error extenerno en la tabla recogida");
            }
        }


        public DataTable BuscarCliente(string cadenaBusqueda, string Estado)
        {
            int NumeralEstado = 1;

            if (Estado == "Activos")
            {
                NumeralEstado = 1;
            }
            else if (Estado == "Inactivos")
            {
                NumeralEstado = 2;
            }
            else if (Estado == "No deseados")
            {
                NumeralEstado = 0;
            }
            else if (Estado == "Todos")
            {
                NumeralEstado = 3;
            }

            DataTable Busqueda = OJCliente.BuscarClientes(cadenaBusqueda, NumeralEstado);

            return Busqueda;

        }
    }
}
