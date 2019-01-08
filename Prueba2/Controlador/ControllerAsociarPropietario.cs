using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba2.Modelo;
using System.Data;

public class ControllerAsociarPropietario
{
    public int? id;
    private string error;
    DatosPropietarioVehiculo objDatosPropietarioVehiculo;
    DatosVehiculo objDatosVehiculo;

    public ControllerAsociarPropietario()
    {
        objDatosPropietarioVehiculo = new DatosPropietarioVehiculo();
    }
    public DataTable propietarioByPLaca(string placa)
    {
        this.error = " ";
        DataTable propietarios = objDatosPropietarioVehiculo.propietariosByPlaca(placa);
        this.error = objDatosPropietarioVehiculo.Error;
        return propietarios;
    }

    public bool propietariagregarPropietarioVehiculo(decimal idPropietario, decimal idVehiculo)
    {
        this.error = " ";
        bool agregado = objDatosPropietarioVehiculo.agregarpPropietarioVehiculo(idPropietario,idVehiculo);
        this.error = objDatosPropietarioVehiculo.Error;
        return agregado;
    }
    public Propietario yaEsPropietario(decimal id, decimal idPropi)
    {
        this.error = " ";
        Propietario unPropietario = objDatosPropietarioVehiculo.yaEsPropietario(id, idPropi);
        this.error = objDatosPropietarioVehiculo.Error;
        return unPropietario;
    }
    
        public Propietario propietarioByVehiculoIdentificacion(string placa, string identificacion)
    {
        this.error = " ";
        Propietario unPropietario = objDatosPropietarioVehiculo.propietarioByVehiculoIdentificacion(placa, identificacion);
        this.error = objDatosPropietarioVehiculo.Error;
        return unPropietario;
    }

}



  

