using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MusicaVirtual2020.Entidades.DTOs.Album;
using MusicaVirtual2020.Entidades.Entities;
using MusicaVirtual2020.Entidades.Mapas;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioAlbumes
    {
        private SqlConnection _connection;
        private RepositorioInterpretes _repoInterpretes;

        public RepositorioAlbumes(SqlConnection connection, RepositorioInterpretes repoInterpretes)
        {
            _connection = connection;
            _repoInterpretes = repoInterpretes;
        }

        public List<AlbumListDto> GetLista()
        {
            try
            {
                List<AlbumListDto> lista = new List<AlbumListDto>();
                string cadenaComando = "SELECT AlbumId, Titulo, InterpreteId, Pistas FROM Albumes";
                var comando = new SqlCommand(cadenaComando, _connection);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    AlbumListDto albumDto = ConstruirAlbumDto(reader);
                    lista.Add(albumDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private AlbumListDto ConstruirAlbumDto(SqlDataReader reader)
        {
            return new AlbumListDto
            {
                AlbumId = reader.GetInt32(0),
                Titulo = reader.GetString(1),
                InterpreteListDto = _repoInterpretes.GetInterpretePorId(reader.GetInt32(2)),
                Pistas = reader.GetInt16(3)
            };
        }


        public void Agregar(Album album,SqlTransaction transaction)
        {
            try
            {
                string cadenaComando =
                    "INSERT INTO Albumes (Titulo, InterpreteId, EstiloId, SoporteId, Pistas, NegocioId, AnioCompra, Costo) " +
                    "VALUES (@titulo, @interprete, @estilo, @soporte, @pistas, @negocio, @anio, @costo)";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection, transaction);
                comando.Parameters.AddWithValue("@titulo", album.Titulo);
                comando.Parameters.AddWithValue("@interprete", album.Interprete.InterpreteId);
                comando.Parameters.AddWithValue("@estilo", album.Estilo.EstiloId);
                comando.Parameters.AddWithValue("@soporte", album.Soporte.SoporteId);
                comando.Parameters.AddWithValue("@pistas", album.Pistas);
                comando.Parameters.AddWithValue("@negocio", album.Negocio.NegocioId);
                comando.Parameters.AddWithValue("@anio", album.AnioCompra);
                comando.Parameters.AddWithValue("@costo", album.Costo);

                comando.ExecuteNonQuery();

                cadenaComando = "SELECT @@identity";
                comando = new SqlCommand(cadenaComando, _connection,transaction);
                int id = (int)(decimal)comando.ExecuteScalar();
                album.AlbumId = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
