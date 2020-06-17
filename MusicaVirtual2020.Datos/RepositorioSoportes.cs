using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioSoportes
    {
        private readonly SqlConnection _cn;

        public RepositorioSoportes(SqlConnection cn)
        {
            this._cn = cn;
        }

        public List<Soporte> GetLista()
        {
            try
            {
                List<Soporte> lista = new List<Soporte>();
                string cadenaComando = "SELECT SoporteId, Descripcion FROM Soportes";
                SqlCommand comando = new SqlCommand(cadenaComando, _cn);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Soporte soporte = ConstruirSoporte(reader);
                    lista.Add(soporte);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Soporte ConstruirSoporte(SqlDataReader reader)
        {
            return new Soporte
            {
                SoporteId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }



        public void Agregar(Soporte soporte)
        {
            try
            {
                var cadenaComando = "INSERT INTO Soportes VALUES (@nombre)";
                var comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@nombre", soporte.Descripcion);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, _cn);
                int id = (int)(decimal)comando.ExecuteScalar();
                soporte.SoporteId = id;
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
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (soporte.SoporteId == 0)
                {
                    var cadenaComando = "SELECT SoporteId, Descripcion FROM Soportes WHERE Descripcion=@nombre";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", soporte.Descripcion);

                }
                else
                {
                    var cadenaComando = "SELECT SoporteId, Descripcion FROM Soportes WHERE Descripcion=@nombre AND SoporteId<>@id";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", soporte.Descripcion);
                    comando.Parameters.AddWithValue("@id", soporte.SoporteId);
                }

                reader = comando.ExecuteReader();
                return reader.HasRows;
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
                var cadenaComando = "SELECT COUNT(*) FROM Albumes WHERE SoporteId=@id";
                var comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@id", soporte.SoporteId);
                int cantidadRegistros = (int)comando.ExecuteScalar();
                if (cantidadRegistros > 0)
                {
                    return true;
                }

                return false;

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
                var cadenaComando = "DELETE FROM Soportes WHERE SoporteId=@id";
                var comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@id", soporte.SoporteId);
                comando.ExecuteNonQuery();
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
                var cadenaComando = "UPDATE Soportes SET Descripcion=@nombre WHERE SoporteId=@id";
                var comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@nombre", soporte.Descripcion);
                comando.Parameters.AddWithValue("@id", soporte.SoporteId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Soporte GetSoportePorId(int id)
        {
            try
            {
                Soporte soporte = null;
                string cadenaComando = "SELECT SoporteId, Descripcion FROM Soportes WHERE SoporteId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    soporte = ConstruirSoporte(reader);
                }
                reader.Close();
                return soporte;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

    }
}
