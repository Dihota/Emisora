using System.Data;
using System.Data.SqlClient;

namespace CapaDatoss
{
    public class Cd_artistas
    {
        private CD_Conexion conex = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        
        public DataTable Mostrar()
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "Sp_consulta_Todos_artistas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conex.Cerrarconexion();
            return tabla;
        }

        public DataTable Filtrar(string nombre)
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "Sp_consulta_artista_por_nombre";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conex.Cerrarconexion();
            return tabla;
        }

        public int insertar(string nombre, string pais, string casadisquera)
        {
            int resp;
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "Sp_Registro_Artistas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nom", nombre);
            comando.Parameters.AddWithValue("@Pais1", pais);
            comando.Parameters.AddWithValue("@CasaDis", casadisquera);
            resp = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            conex.Cerrarconexion();
            return resp;

        }


        public int actualizar(int Id, string nombre, string pais, string casadisquera)
        {
            int resp;
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "Sp_Update_Artistas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", Id);
            comando.Parameters.AddWithValue("@Nom", nombre);
            comando.Parameters.AddWithValue("@Pais1", pais);
            comando.Parameters.AddWithValue("@CasaDis", casadisquera);
            resp = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            conex.Cerrarconexion();
            return resp;

        }

        public int eliminar(int Id)
        {
            int resp;
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "Sp_Delete_Artistas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", Id);
            resp = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            conex.Cerrarconexion();
            return resp;

        }



    }
}
