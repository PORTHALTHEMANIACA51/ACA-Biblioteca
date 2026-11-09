using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace AcaBibliteca.Datos
{
    public class Conexion
    {
        private static string cadenaConexion = "Server=(localdb)\\MSSQLLocalDB;Database=AcaBiblioteca;Trusted_Connection=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}

