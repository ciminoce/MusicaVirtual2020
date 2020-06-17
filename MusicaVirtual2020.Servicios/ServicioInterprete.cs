using System;
using System.Collections.Generic;
using MusicaVirtual2020.Datos;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Servicios
{
    public class ServicioInterprete
    {
        private ConexionBd cn;
        private RepositorioInterpretes repositorio;
        private RepositorioPaises repositorioPaises;

        public ServicioInterprete()
        {
            
        }

        public void Borrar(Interprete interprete)
        {
            try
            {
                cn=new ConexionBd();
                repositorio=new RepositorioInterpretes(cn.AbrirConexion());
                repositorio.Borrar(interprete);
                cn.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Existe(Interprete interprete)
        {
            try
            {
                cn=new ConexionBd();
                repositorio=new RepositorioInterpretes(cn.AbrirConexion());
                var existe = repositorio.Existe(interprete);
                cn.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void Agregar(Interprete interprete)
        {
            try
            {
                cn=new ConexionBd();
                repositorio=new RepositorioInterpretes(cn.AbrirConexion());
                repositorio.Agregar(interprete);
                cn.CerrarConexion();

            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
        public List<Interprete> GetInterpretes(Pais pais=null)
        {
            try
            {
                cn=new ConexionBd();
                repositorioPaises=new RepositorioPaises(cn.AbrirConexion());
                repositorio=new RepositorioInterpretes(cn.AbrirConexion(), repositorioPaises);
                var lista = repositorio.GetInterpretes(pais);
                cn.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelaciona(Interprete interprete)
        {
            try
            {
                cn=new ConexionBd();
                repositorio=new RepositorioInterpretes(cn.AbrirConexion());
                var relacionado = repositorio.EstaRelacionado(interprete);
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
