using System;
using System.Collections.Generic;
using MusicaVirtual2020.Datos;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Servicios
{
    public class ServicioEstilo
    {
        private ConexionBd conexion;
        private RepositorioEstilos repositorio;

        public ServicioEstilo()
        {
        }

        public void Agregar(Estilo estilo)
        {
            try
            {
                conexion=new ConexionBd();
                repositorio=new RepositorioEstilos(conexion.AbrirConexion());
                //var estilo = Mapeador.ConvertirEstilo(estiloDto);
                repositorio.Agregar(estilo);
                
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
        public List<Estilo> GetLista()
        {
            try
            {
                conexion=new ConexionBd();
                repositorio=new RepositorioEstilos(conexion.AbrirConexion());
                var lista=repositorio.GetLista();
                
                conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
    }
}
