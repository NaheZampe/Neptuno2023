using Neptuno2023.Datos.Comun.Interfases;
using Neptuno2023.Datos.Repositorios;
using Neptuno2023.Entidades.Entidades;
using Neptuno2023.Servicios.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Servicios.Servicios
{
    public class ServiciosPaises : IServicioPaises
    {
        private readonly IRepositorioPaises _repositorio;
        public ServiciosPaises()
        {
            _repositorio=new RepositorioPaises(); 
        }
        public List<Pais> GetPaises()
        {
            try
            {
                return _repositorio.GetPaises();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
