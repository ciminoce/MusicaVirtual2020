using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MusicaVirtual2020.Datos;
using MusicaVirtual2020.Entidades.DTOs.Album;
using MusicaVirtual2020.Entidades.DTOs.Interprete;
using MusicaVirtual2020.Entidades.DTOs.Negocio;
using MusicaVirtual2020.Entidades.Entities;
using MusicaVirtual2020.Entidades.Mapas;

namespace MusicaVirtual2020.Servicios
{
    public class ServicioAlbumes
    {
        private ConexionBd _conexion;
        private RepositorioAlbumes _repositorio;
        private RepositorioInterpretes _repoInterpretes;
        private RepositorioTemas _repositorioTemas;

        public ServicioAlbumes()
        {
            
        }

        public List<AlbumListDto> GetAlbumes()
        {
            try
            {
                _conexion=new ConexionBd();
                //_repoInterpretes=new RepositorioInterpretes(_conexion.AbrirConexion());
                _repositorio=new RepositorioAlbumes(_conexion.AbrirConexion());
                var lista= _repositorio.GetLista();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public void Agregar(Album album)
        {
            SqlTransaction tran = null;
            try
            {
                _conexion = new ConexionBd();
                SqlConnection cn = _conexion.AbrirConexion();
                _repositorio = new RepositorioAlbumes(cn);
                _repositorioTemas=new RepositorioTemas(cn);

                using (tran=cn.BeginTransaction())
                {
                    //Album album = Mapeador.ConvertirAAlbum(albumEditDto);
                    _repositorio.Agregar(album, tran);
                    //albumEditDto.AlbumId = album.AlbumId;
                    if (album.Temas.Count>0)
                    {
                        album.Temas.ForEach(t =>
                        {
                            t.Album = album;
                            _repositorioTemas.Agregar(t,tran);
                        });
                    }

                    tran.Commit();//método que persiste la informacion en la BD.
                    
                }
                _conexion.CerrarConexion();
                
            }
            catch (Exception e)
            {
                tran.Rollback();//tira para atras todo lo grabado
                throw new Exception(e.Message);
            }

        }

        public List<InterpreteAlbumesDto> GetCantidadPorInterprete()
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorio = new RepositorioAlbumes(_conexion.AbrirConexion());
                var lista = _repositorio.GetCantidadPorInterprete();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<NegocioAlbumesDto> GetCantidadPorNegocio()
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioAlbumes(_conexion.AbrirConexion());
                var lista = _repositorio.GetCantidadPorNegocio();
                _conexion.CerrarConexion();
                return lista;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
