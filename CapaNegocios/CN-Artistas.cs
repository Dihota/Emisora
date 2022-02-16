using CapaDatoss;
using System;
using System.Data;

namespace CapaNegocios
{
    public class CN_Artistas
    {
        private Cd_artistas objetoCD = new Cd_artistas();

        public DataTable Mostrarartistas()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public DataTable Filtrar(string nombre)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Filtrar(nombre);
            return tabla;
        }

        public string Insertar(string nombre, string pais, string casadisquera)
        {
            string resp;
            int cod = objetoCD.insertar(nombre, pais, casadisquera);
            if (cod == 100)
            {
                resp = "Registro insertado correctamente";
            }
            else
            {
                resp = "El artista ya se encuentra registrado";
            }

            return resp;
        }

        public string actualizar(string Id, string nombre, string pais, string casadisquera)
        {
            string resp;
            int cod = objetoCD.actualizar(Int32.Parse(Id),nombre, pais, casadisquera);
            resp = "Registro actualizado correctamente";

            return resp;
        }

        public string eliminar(string Id)
        {
            string resp;
            int cod = objetoCD.eliminar(Int32.Parse(Id));
            resp = "Registro eliminado correctamente";

            return resp;
        }


    }
}
