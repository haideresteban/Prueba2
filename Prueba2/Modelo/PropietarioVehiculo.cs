using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Modelo
{
    public class PropietarioVehiculo
    {
        public decimal idPropietario { get; set; }
        public decimal idVehiculo { get; set; }



        public PropietarioVehiculo()
        {

        }

      


        public PropietarioVehiculo(decimal idPropietario, decimal idVehiculo)
        {
            this.idPropietario = idPropietario;
            this.idVehiculo = idVehiculo;

        }

    }

}
