using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba2.Modelo;


    public  class ControllerVehiculo
    {
        public int? id ;
        private string error;
        DatosVehiculo objDatosVehiculo;

        public ControllerVehiculo(int? id = null)
        {
            objDatosVehiculo = new DatosVehiculo();
        }
        public DataTable listaVehiculos()
        {
            this.error = " ";
            DataTable listaVehiculos = objDatosVehiculo.listarVehiculos2();
            this.error = objDatosVehiculo.Error;
            return listaVehiculos;
        }
    public List<Marca> listaMarcas()
    {
        this.error="";
        List<Marca> marcas = objDatosVehiculo.listaMarcas();
        this.error = objDatosVehiculo.Error;
        return marcas;
    }

    public List<Linea> lineaByMarca(decimal idMarca)
    {
        this.error="";
        List<Linea> lineaByMarca = objDatosVehiculo.listaLineas(idMarca);
        this.error = objDatosVehiculo.Error;
        return lineaByMarca;
    }
    public List<TipoServicio> listaTipoServicios()
    {
        this.error = "";
        List<TipoServicio> listaTipoSer = objDatosVehiculo.listarTipodeServicios();
        this.error = objDatosVehiculo.Error;
        return listaTipoSer;
    }
    public List<ClaseVehiculo> listaClaseVEhiculos()
    {
        this.error = "";
        List<ClaseVehiculo> listaClasevehi = objDatosVehiculo.listaClaseVehiculos();
        this.error = objDatosVehiculo.Error;
        return listaClasevehi;
    }
    public bool  agregarVehiculo(Vehiculo vehiculo)
    {
        this.error = "";
        bool agregado = objDatosVehiculo.agregarVehiculo(vehiculo);
        this.error = objDatosVehiculo.Error;
        return agregado;
    }
    public Vehiculo buscarVehiculo(int? id)
    {
        this.error = "";
      Vehiculo vehiculo  = objDatosVehiculo.BuscarVehiculo(id);
        this.error = objDatosVehiculo.Error;
        return vehiculo;

    }
    public DataTable buscarVehiculobyPlaca(string placa)
    {
        this.error = "";
        DataTable vehiculo = objDatosVehiculo.BuscarVehiculoByPlaca(placa);
        this.error = objDatosVehiculo.Error;
        return vehiculo;

    }

    
         public DataTable tramite()
    {
        this.error = "";
        DataTable vehiculo = objDatosVehiculo.tramites();
        this.error = objDatosVehiculo.Error;
        return vehiculo;

    }

    public string numeroFactura()
    {
        this.error = "";
        string numeroFactura = objDatosVehiculo.numeroFactura();
        this.error = objDatosVehiculo.Error;
        return numeroFactura;

    }
    public decimal idVehiculoByPlaca(string placa)
    {
        this.error = "";
        decimal idVehiculo = objDatosVehiculo.idAutoByPlaca(placa);
        this.error = objDatosVehiculo.Error;
        return idVehiculo;

    }

}

