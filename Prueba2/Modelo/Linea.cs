using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Modelo
{
    public class Linea
    {
        public decimal id { get; set; }
        public string descripcion { get; set; }
       public Marca idMarca { get; set; }

        public Linea()
        {

        }
        public Linea(decimal id, string descripcion, Marca idMarca)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.idMarca = idMarca;

        }
    }
}
