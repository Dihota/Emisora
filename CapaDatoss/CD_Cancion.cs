using System.Data;
using System.Data.SqlClient;

namespace CapaDatoss
{
    public class CD_Cancion
    {
        private CD_Conexion conex = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable Mostrar()
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "Sp_consulta_todas_canciones";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conex.Cerrarconexion();
            return tabla;
        }

        public DataTable Filtrar(string nombre)
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "Sp_consulta_cancion_por_idartista";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conex.Cerrarconexion();
            return tabla;
        }

        public int insertar(string nombre, string cancion, string duracion)
        {
            int resp;
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "Sp_Registro_Cancion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NomArtista", nombre);
            comando.Parameters.AddWithValue("@NomCancion", cancion);
            comando.Parameters.AddWithValue("@DuracionCancion", duracion);
            resp = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            conex.Cerrarconexion();
            return resp;
        }

        public DataTable Artistas()
        {
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "select distinct(Nombre) from Artista";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conex.Cerrarconexion();
            return tabla;
        }

        public int actualizar(int Id, string nombre, string duracion)
        {
            int resp;
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "Sp_Update_Cancion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdCancion", Id);
            comando.Parameters.AddWithValue("@NomCancion", nombre);
            comando.Parameters.AddWithValue("@DuracionCancion", duracion);
            resp = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            conex.Cerrarconexion();
            return resp;

        }

        public int eliminar(int Id)
        {
            int resp;
            comando.Connection = conex.AbrirConexion();
            comando.CommandText = "Sp_Delete_Cancion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", Id);
            resp = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            conex.Cerrarconexion();
            return resp;

        }
    }
}
