using System;
using System.Collections.Generic;
using MusicaVirtual2020.Datos;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Servicios
{
    public class ServicioPais
    {
        private ConexionBd _conexion;
        private RepositorioPaises _repositorio;

        public ServicioPais()
        {
            
        }

        public List<Pais> GetLista()
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioPaises(_conexion.AbrirConexion());
                var lista = _repositorio.GetLista();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public void Agregar(Pais pais)
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioPaises(_conexion.AbrirConexion());
                _repositorio.Agregar(pais);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Pais pais)
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioPaises(_conexion.AbrirConexion());
                 var existe=_repositorio.Existe(pais);
                 _conexion.CerrarConexion();
                 return existe;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Pais pais)
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioPaises(_conexion.AbrirConexion());
                var estaRelacionado=_repositorio.EstaRelacionado(pais);
                _conexion.CerrarConexion();
                return estaRelacionado;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
        public void Borrar(Pais pais)
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioPaises(_conexion.AbrirConexion());
                _repositorio.Borrar(pais);
                _conexion.CerrarConexion();
                
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public void Editar(Pais pais)
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioPaises(_conexion.AbrirConexion());
                _repositorio.Editar(pais);
                _conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
