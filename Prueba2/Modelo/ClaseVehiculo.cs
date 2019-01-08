using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Modelo
{
  public  class ClaseVehiculo {

        public decimal id { get; set; }
        public string descripcion { get; set; }


    public ClaseVehiculo()
    {

    }

    public ClaseVehiculo(decimal id, string descripcion)
    {
        this.id = id;
        this.descripcion = descripcion;

    }
}
}
