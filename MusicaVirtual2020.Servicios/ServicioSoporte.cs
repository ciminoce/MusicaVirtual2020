using System;
using System.Collections.Generic;
using MusicaVirtual2020.Datos;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Servicios
{
    public class ServicioSoporte
    {
        private ConexionBd _conexion;
        private RepositorioSoportes _repositorio;

        public ServicioSoporte()
        {

        }

        public List<Soporte> GetLista()
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorio = new RepositorioSoportes(_conexion.AbrirConexion());
                var lista = _repositorio.GetLista();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Agregar(Soporte soporte)
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorio = new RepositorioSoportes(_conexion.AbrirConexion());
                _repositorio.Agregar(soporte);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(Soporte soporte)
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorio = new RepositorioSoportes(_conexion.AbrirConexion());
                var existe = _repositorio.Existe(soporte);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Soporte soporte)
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorio = new RepositorioSoportes(_conexion.AbrirConexion());
                var estaRelacionado = _repositorio.EstaRelacionado(soporte);
                _conexion.CerrarConexion();
                return estaRelacionado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public void Borrar(Soporte soporte)
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorio = new RepositorioSoportes(_conexion.AbrirConexion());
                _repositorio.Borrar(soporte);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Editar(Soporte soporte)
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorio = new RepositorioSoportes(_conexion.AbrirConexion());
                _repositorio.Editar(soporte);
                _conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
