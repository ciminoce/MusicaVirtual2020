using System.Collections.Generic;
using System.Data.SqlClient;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioAlbumes
    {
        private SqlConnection _connection;

        public RepositorioAlbumes(SqlConnection connection)
        {
            _connection = connection;
        }

        //public List<Album> GetAlbumes()
        //{

        //}
    }
}
