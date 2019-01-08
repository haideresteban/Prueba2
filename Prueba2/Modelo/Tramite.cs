using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Modelo
{
    public class Tramite
    {
        public decimal id { get; set; }
        public string descripcion { get; set; }
        public decimal valor { get; set; }

        public Tramite()
        {

        }
        public Tramite(decimal id, string descripcion, decimal valor)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.valor = valor;

        }
    }
}
