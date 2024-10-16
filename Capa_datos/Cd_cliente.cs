using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidades;
namespace Capa_datos
{
    public class Cd_cliente
    {
        public List<Cliente> Listar()
        {

            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.conn))
            {

                try
                {

                    string query = "SELECT cc,nombre,apellido,contacto FROM CLIENTE";


                    SqlCommand cmd = new SqlCommand(query, oconexion);
                   cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            lista.Add(new Cliente()
                            {

                                cc = reader["cc"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                contacto = reader["contacto"].ToString()
                            });

                        }
                    }

                }
                catch (Exception ex)
                {

                    lista = new List<Cliente>();

                }
                finally
                {

                }
return lista;
            }

        }
    }
}
