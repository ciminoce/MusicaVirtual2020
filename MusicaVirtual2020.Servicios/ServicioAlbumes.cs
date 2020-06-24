using System;
using System.Collections.Generic;
using MusicaVirtual2020.Datos;
using MusicaVirtual2020.Entidades.DTOs.Album;

namespace MusicaVirtual2020.Servicios
{
    public class ServicioAlbumes
    {
        private ConexionBd _conexion;
        private RepositorioAlbumes _repositorio;
        private RepositorioInterpretes _repoInterpretes;

        public ServicioAlbumes()
        {
            
        }

        public List<AlbumListDto> GetAlbumes()
        {
            try
            {
                _conexion=new ConexionBd();
                _repoInterpretes=new RepositorioInterpretes(_conexion.AbrirConexion());
                _repositorio=new RepositorioAlbumes(_conexion.AbrirConexion(),_repoInterpretes);
                var lista= _repositorio.GetLista();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public void Agregar(AlbumEditDto albumEditDto)
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorio = new RepositorioAlbumes(_conexion.AbrirConexion(), _repoInterpretes);
                _repositorio.Agregar(albumEditDto);
                _conexion.CerrarConexion();
                
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
