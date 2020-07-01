using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.DTOs.Estilo;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioEstilos
    {
        private readonly SqlConnection _cn;

        public RepositorioEstilos(SqlConnection cn)
        {
            this._cn = cn;
        }

        public void Agregar(Estilo estilo)
        {
            try
            {
                var cadenaComando = "INSERT INTO Estilos VALUES (@estilo)";
                var comando=new SqlCommand(cadenaComando,_cn);
                comando.Parameters.AddWithValue("@estilo", estilo.Nombre);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@Identity";
                comando=new SqlCommand(cadenaComando,_cn);
                int id =(int)(decimal) comando.ExecuteScalar();
                estilo.EstiloId = id;
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
                List<Estilo> lista=new List<Estilo>();
                string cadenaComando = "SELECT EstiloId, Nombre FROM Estilos";
                var comando=new SqlCommand(cadenaComando, _cn);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Estilo estilo = ConstruirEstilo(reader); 
                    lista.Add(estilo);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        private Estilo ConstruirEstilo(SqlDataReader reader)
        {
            return new Estilo
            {
                EstiloId = reader.GetInt32(0),
                Nombre = reader.GetString(1)
            };
        }


      
    }
}
