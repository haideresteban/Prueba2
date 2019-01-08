using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Modelo
{
   public class Vehiculo
    {
        public decimal id  { get; set; }
        public string placa { get; set; }
        public Linea idLinea { get; set; }
        public string modelo { get; set; }
        public string numeroMotor { get; set; }
        public string color { get; set; }
        public ClaseVehiculo idClaseVehiculo { get; set; }
        public TipoServicio idTipoServicio { get; set; }


        public Vehiculo()
        {

        }

        public Vehiculo(decimal id, string placa, Linea idLinea, string modelo, string numeroMotor, string color, ClaseVehiculo idClaseVehiculo,TipoServicio idTipoServicio)
        {
            this.id = id;
            this.placa = placa;
            this.idLinea = idLinea;
            this.modelo = modelo;
            this.numeroMotor = numeroMotor;
            this.color = color;
            this.idClaseVehiculo = idClaseVehiculo;
            this.idTipoServicio = idTipoServicio;

        }



    }
}
