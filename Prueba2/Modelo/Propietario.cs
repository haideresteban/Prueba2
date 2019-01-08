using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Modelo
{
    
        public class Propietario
        {
        public decimal id { get; set; }
        public int numeroIdentificacion { get; set; }
            public string nombres { get; set; }
            public string apellidos { get; set; }
            public string direccion { get; set; }
            public string telefono { get; set; }
            public string correoElectronico { get; set; }

            public Propietario()
            {

            }
            public Propietario(int identificacion, string nombres, string apellidos, string direccion,
                string telefono, string correoElectronico)
            {
                this.numeroIdentificacion = identificacion;
                this.nombres = nombres;
                this.apellidos = apellidos;
                this.direccion = direccion;
                this.telefono = telefono;
                this.correoElectronico = correoElectronico;
            }
        }
    }

