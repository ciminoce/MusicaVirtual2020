using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MusicaVirtual2020.Entidades;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioPaises
    {
        private readonly SqlConnection _cn;

        public RepositorioPaises(SqlConnection cn)
        {
            this._cn = cn;
        }

        public List<Pais> GetLista()
        {
            try
            {
                List<Pais> lista=new List<Pais>();
                string cadenaComando = "SELECT PaisId, Nombre FROM Paises";
                SqlCommand comando=new SqlCommand(cadenaComando,_cn);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Pais pais = ConstruirPais(reader);
                    lista.Add(pais);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Pais ConstruirPais(SqlDataReader reader)
        {
            return new Pais
            {
                PaisId = reader.GetInt32(0),
                Nombre = reader.GetString(1)
            };
        }

 

        public void Agregar(Pais pais)
        {
            try
            {
                var cadenaComando = "INSERT INTO Paises VALUES (@nombre)";
                var comando=new SqlCommand(cadenaComando,_cn);
                comando.Parameters.AddWithValue("@nombre", pais.Nombre);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando=new SqlCommand(cadenaComando,_cn);
                int id =(int)(decimal)comando.ExecuteScalar();
                pais.PaisId = id;
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
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (pais.PaisId==0)
                {
                    var cadenaComando = "SELECT PaisId, Nombre FROM Paises WHERE Nombre=@nombre";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", pais.Nombre);

                }
                else
                {
                    var cadenaComando = "SELECT PaisId, Nombre FROM Paises WHERE Nombre=@nombre AND PaisId<>@id";
                    comando=new SqlCommand(cadenaComando,_cn);
                    comando.Parameters.AddWithValue("@nombre", pais.Nombre);
                    comando.Parameters.AddWithValue("@id", pais.PaisId);
                }
                
                reader = comando.ExecuteReader();
                return reader.HasRows;
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
                var cadenaComando = "SELECT COUNT(*) FROM Negocios WHERE PaisId=@id";
                var comando=new SqlCommand(cadenaComando,_cn);
                comando.Parameters.AddWithValue("@id", pais.PaisId);
                int cantidadRegistros =(int) comando.ExecuteScalar();
                if (cantidadRegistros>0)
                {
                    return true;
                }
                else
                {
                    cadenaComando = "SELECT COUNT(*) FROM Interpretes WHERE PaisId=@id";
                    comando=new SqlCommand(cadenaComando,_cn);
                    comando.Parameters.AddWithValue("@id", pais.PaisId);
                    cantidadRegistros = (int) comando.ExecuteScalar();
                    if (cantidadRegistros>0)
                    {
                        return true;
                    }

                    return false;
                }
               
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
                var cadenaComando = "DELETE FROM Paises WHERE PaisId=@id";
                var comando=new SqlCommand(cadenaComando,_cn);
                comando.Parameters.AddWithValue("@id", pais.PaisId);
                comando.ExecuteNonQuery();
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
                var cadenaComando = "UPDATE Paises SET Nombre=@nombre WHERE PaisId=@id";
                var comando=new SqlCommand(cadenaComando,_cn);
                comando.Parameters.AddWithValue("@nombre", pais.Nombre);
                comando.Parameters.AddWithValue("@id", pais.PaisId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Pais GetPaisPorId(int id)
        {
            try
            {
                Pais pais = null;
                string cadenaComando = "SELECT PaisId, Nombre FROM Paises WHERE PaisId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    pais = ConstruirPais(reader);
                }
                reader.Close();
                return pais;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
