using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Modelo
{
    public class TipoServicio
    {
        public decimal id { get; set; }
        public string descripcion { get; set; }

        public TipoServicio()
        {

        }

        public TipoServicio(decimal id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;

        }
    }
}
