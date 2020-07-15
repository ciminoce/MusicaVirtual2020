using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MusicaVirtual2020.Entidades.DTOs.Album;
using MusicaVirtual2020.Entidades.DTOs.Interprete;
using MusicaVirtual2020.Entidades.DTOs.Negocio;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioAlbumes
    {
        private SqlConnection _connection;
        //private RepositorioInterpretes _repoInterpretes;

        public RepositorioAlbumes(SqlConnection connection)
        {
            _connection = connection;
            //_repoInterpretes = repoInterpretes;
        }

        public List<AlbumListDto> GetLista()
        {
            try
            {
                List<AlbumListDto> lista = new List<AlbumListDto>();
                string cadenaComando = "SELECT AlbumId, Titulo, Nombre, Pistas FROM Albumes" +
                                       " INNER JOIN Interpretes ON Albumes.InterpreteId=Interpretes.InterpreteId";
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
                Interprete = reader.GetString(2),
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

        public List<InterpreteAlbumesDto> GetCantidadPorInterprete()
        {
            try
            {
                List<InterpreteAlbumesDto> lista = new List<InterpreteAlbumesDto>();
                string cadenaComando = "SELECT Nombre, COUNT(AlbumId) AS Cantidad From Albumes " +
                                       "INNER JOIN Interpretes ON Albumes.InterpreteId=Interpretes.InterpreteId GROUP BY Nombre";
                var comando = new SqlCommand(cadenaComando, _connection);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    InterpreteAlbumesDto interpreteAlbumesDto = ConstruirInterpreteAlbumesDto(reader);
                    lista.Add(interpreteAlbumesDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        private InterpreteAlbumesDto ConstruirInterpreteAlbumesDto(SqlDataReader reader)
        {
            return new InterpreteAlbumesDto()
            {
                Interprete = reader.GetString(0),
                Cantidad = reader.GetInt32(1)
            };
        }

        public List<NegocioAlbumesDto> GetCantidadPorNegocio()
        {
            try
            {
                List<NegocioAlbumesDto> lista=new List<NegocioAlbumesDto>();
                string cadenaComando = "SELECT Nombre, COUNT(AlbumId) AS Cantidad From Albumes " +
                                       "INNER JOIN Negocios ON Albumes.NegocioId=Negocios.NegocioId GROUP BY Nombre";
                SqlCommand comando=new SqlCommand(cadenaComando,_connection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var negocioAlbumesDto = ConstruirNegocioAlbumesDto(reader);
                    lista.Add(negocioAlbumesDto);

                }
                reader.Close();
                return lista;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private NegocioAlbumesDto ConstruirNegocioAlbumesDto(SqlDataReader reader)
        {
            return new NegocioAlbumesDto
            {
                Negocio = reader.GetString(0),
                Cantidad = reader.GetInt32(1)
            };
        }
    }
}
