using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Modelo
{
  public  class Marca
    {
        public decimal Id { get; set; }
        public string descripcion { get; set; }


        public Marca()
        {

        }

        public Marca(decimal id, string descripcion)
        {
            this.Id = id;
            this.descripcion = descripcion;

        }
    }
}
