using CapaDatoss;
using System;
using System.Data;

namespace CapaNegocios
{
    public class CN_cancion
    {
        private CD_Cancion objetoCD = new CD_Cancion();

        public DataTable Mostrararcancion()
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

        public string Insertar(string nombre, string cancion, string duracion)
        {
            string resp;
            int cod = objetoCD.insertar(nombre, cancion, duracion);
            if (cod == 100)
            {
                resp = "Registro insertado correctamente";
            }
            else
            {
                resp = "La cancion ya se encuentra registrado";
            }

            return resp;
        }

        public DataTable listarArtista()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Artistas();
            return tabla;
        }

        public string actualizar(string Id, string nombre, string duraccion )
        {
            string resp;
            int cod = objetoCD.actualizar(Int32.Parse(Id), nombre, duraccion);
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
