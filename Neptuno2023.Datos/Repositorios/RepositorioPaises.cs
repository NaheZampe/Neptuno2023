using Neptuno2023.Datos.Comun.Interfases;
using Neptuno2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Datos.Repositorios
{
    public class RepositorioPaises : IRepositorioPaises

    {
        private string CadenaDeConexion;
        public RepositorioPaises()
        {
            CadenaDeConexion = ConfigurationManager.ConnectionStrings["MiConixion"].ToString();
        }
        public List<Pais> GetPaises()
        {
            List<Pais> lista =new List<Pais>();
            using (var _conn = new SqlConnection(CadenaDeConexion))
            {
                _conn.Open();
                var selectQuery = "Select*From Paises Order by NombrePais";
                using (var comando=new SqlCommand(selectQuery,_conn))
                {
                    using (var reader=comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pais=new Pais()
                            {
                                PaisId=reader.GetInt32(0),
                                NombrePais=reader.GetString(1),
                                RowVersion = (byte[])reader[2]
                            };
                            lista.Add(pais);
                        }
                    }
                }
                return lista;
            }
        }
    }
}
