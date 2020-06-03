using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MusicaVirtual2020.Entidades;

namespace MusicaVirtual2020.Datos
{
    public class RepositorioInterpretes
    {
        private readonly SqlConnection _cn;
        private readonly RepositorioPaises _repositorioPaises;

        public RepositorioInterpretes(SqlConnection cn, RepositorioPaises repositorioPaises)
        {
            this._cn = cn;
            this._repositorioPaises = repositorioPaises;
        }

        public RepositorioInterpretes(SqlConnection cn)
        {
            _cn = cn;
        }
        public bool EstaRelacionado(Interprete interprete)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Albumes WHERE InterpreteId=@id";
                var comando = new SqlCommand(cadenaComando, _cn);
                comando.Parameters.AddWithValue("@id", interprete.InterpreteId);
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

        public void Borrar(Interprete interprete)
        {
            try
            {
                string cadenaComando = "DELETE FROM Interpretes WHERE InterpreteId=@id";
                SqlCommand comando=new SqlCommand(cadenaComando,_cn);
                comando.Parameters.AddWithValue("@id", interprete.InterpreteId);
                comando.ExecuteNonQuery();
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
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (interprete.InterpreteId == 0)
                {
                    var cadenaComando = "SELECT InterpreteId, Nombre, PaisId FROM Interpretes WHERE Nombre=@nombre AND PaisId=@paisid";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", interprete.Nombre);
                    comando.Parameters.AddWithValue("@paisid", interprete.Pais.PaisId);

                }
                else
                {
                    var cadenaComando = "SELECT InterpreteId, Nombre, PaisId FROM Interpretes WHERE Nombre=@nombre AND PaisId=@paisid AND InterpreteId<>@id";
                    comando = new SqlCommand(cadenaComando, _cn);
                    comando.Parameters.AddWithValue("@nombre", interprete.Nombre);
                    comando.Parameters.AddWithValue("@paisid", interprete.Pais.PaisId);
                    comando.Parameters.AddWithValue("@id", interprete.InterpreteId);
                }

                reader = comando.ExecuteReader();
                return reader.HasRows;

            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
        public void Agregar(Interprete interprete)
        {
            try
            {
                string cadenaComando = "INSERT INTO Interpretes VALUES (@nombre, @paisid)";
                SqlCommand comando=new SqlCommand(cadenaComando,_cn);
                comando.Parameters.AddWithValue("@nombre", interprete.Nombre);
                comando.Parameters.AddWithValue("@paisid", interprete.Pais.PaisId);
                comando.ExecuteNonQuery();
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
                List<Interprete> lista = new List<Interprete>();
                var cadenaComando = "SELECT InterpreteId, Nombre, PaisId FROM Interpretes ";
                string whereCondicion = pais != null ? " WHERE PaisId=@paisid " : string.Empty;
                var orderBy=" ORDER BY Nombre";

                var comando = new SqlCommand($"{cadenaComando}{whereCondicion}{orderBy}", _cn);
                if (pais!=null)
                {
                    comando.Parameters.AddWithValue("@paisid", pais.PaisId);
                }
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var interprete = ConstruirInterprete(reader);
                    lista.Add(interprete);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        private Interprete ConstruirInterprete(SqlDataReader reader)
        {
            return new Interprete
            {
                InterpreteId = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Pais = _repositorioPaises.GetPaisPorId(reader.GetInt32(2))
            };
        }
    }
}
