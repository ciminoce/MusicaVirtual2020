using System;
using System.Collections.Generic;
using MusicaVirtual2020.Datos;
using MusicaVirtual2020.Entidades;

namespace MusicaVirtual2020.Servicios
{
    public class ServicioNegocio
    {
        private ConexionBd cn;
        private RepositorioNegocios repositorio;
        private RepositorioPaises repositorioPaises;

        public ServicioNegocio()
        {

        }

        public void Borrar(Negocio negocio)
        {
            try
            {
                cn = new ConexionBd();
                repositorio = new RepositorioNegocios(cn.AbrirConexion());
                repositorio.Borrar(negocio);
                cn.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Existe(Negocio negocio)
        {
            try
            {
                cn = new ConexionBd();
                repositorio = new RepositorioNegocios(cn.AbrirConexion());
                var existe = repositorio.Existe(negocio);
                cn.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void Agregar(Negocio negocio)
        {
            try
            {
                cn = new ConexionBd();
                repositorio = new RepositorioNegocios(cn.AbrirConexion());
                repositorio.Agregar(negocio);
                cn.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public List<Negocio> GetNegocios(Pais pais = null)
        {
            try
            {
                cn = new ConexionBd();
                repositorioPaises = new RepositorioPaises(cn.AbrirConexion());
                repositorio = new RepositorioNegocios(cn.AbrirConexion(), repositorioPaises);
                var lista = repositorio.GetNegocios(pais);
                cn.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelaciona(Negocio negocio)
        {
            try
            {
                cn = new ConexionBd();
                repositorio = new RepositorioNegocios(cn.AbrirConexion());
                var relacionado = repositorio.EstaRelacionado(negocio);
                cn.CerrarConexion();
                return relacionado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

    }
}
