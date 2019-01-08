using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Modelo
{


    public class Factura
    {

        public decimal id { get; set; }
        public string numero { get; set; }
        public DateTime fecha { get; set; }
        public decimal idVehiculo { get; set; }
        public string observaciones { get; set; }
        public Factura()
        {

        }
        public Factura(decimal id, string numero, DateTime fecha,decimal idVehiculo, string observaciones )
        {
            this.id = id;
            this.numero = numero;
            this.fecha = fecha;
            this.idVehiculo = idVehiculo;
            this.observaciones = observaciones;
        }


    }
}
