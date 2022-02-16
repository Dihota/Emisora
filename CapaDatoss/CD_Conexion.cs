using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaDatoss
{
    public class CD_Conexion
    {
        //Crea la conexion
        private SqlConnection Conexion = new SqlConnection("Server=.;DataBase= Emisora;Integrated Security=true");

        //Abrir conexion
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }
        //Cerrar conexion
        public SqlConnection Cerrarconexion ()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }

    }
}
