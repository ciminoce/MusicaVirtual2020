using System;
using System.Data.SqlClient;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioTemas
    {
        private readonly SqlConnection _cn;

        public RepositorioTemas(SqlConnection cn)
        {
            _cn = cn;
        }

        public void Agregar(Tema tema, SqlTransaction tran)
        {
            try
            {
                string cadenaComando = "INSERT INTO Temas(PistaNumero, Nombre, Duracion, AlbumId) VALUES (@nro, @tema, @duracion, @album)";
                SqlCommand comando = new SqlCommand(cadenaComando, _cn, tran);
                comando.Parameters.AddWithValue("@nro", tema.PistaNro);
                comando.Parameters.AddWithValue("@tema", tema.Nombre);
                comando.Parameters.AddWithValue("@duracion", tema.Duracion);
                comando.Parameters.AddWithValue("@album", tema.Album.AlbumId);

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
