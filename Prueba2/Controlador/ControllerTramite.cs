using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Prueba2.Modelo;

public class ControllerTramite
{

    public int? id;
    private string error;
    DatosTramite objDatosTramite;

    public ControllerTramite(int? id = null)
    {
        objDatosTramite = new DatosTramite();
        this.id = id;
    }
 
    public string Error
    {
        get { return error; }
        set { error = value; }
    }
    public List<Tramite> listaTramites()
    {
        this.error = "";
        List<Tramite> listaTramites = objDatosTramite.numeroFactura();
        this.error = objDatosTramite.Error;
        return listaTramites;
    }
    public Tramite buscarTramite(decimal id)
    {
        this.error = "";
        Tramite tramite = new Tramite();
        tramite = objDatosTramite.buscarTramite(id);
        this.error = objDatosTramite.Error;
        return tramite;
    }
    public bool agregarFactura(Tramite tramite, Factura factura)
    {
        this.error = "";
        bool agrega = objDatosTramite.agregarTramite(tramite,factura);
        this.error = objDatosTramite.Error;
        return agrega;
    }
    //public DataTable FacturaByTramite(string placa)
    //{
    //    this.error = "";
    //    DataTable DT = objDatosTramite.FacturaByTramite(placa);
    //    this.error = objDatosTramite.Error;
    //    return DT;
    //}
    public DataTable FacturaByPlaca(string placa)
    {
        this.error = "";
        DataTable DT = objDatosTramite.FacturaByPlaca(placa);
        this.error = objDatosTramite.Error;
        return DT;
    }
    public DataTable FacturaByIdentificacion(string identificacion)
    {
        this.error = "";
        DataTable DT = objDatosTramite.FacturaByIdentificacion(identificacion);
        this.error = objDatosTramite.Error;
        return DT;
    }
    public DataTable FacturaByRangoFechas(string fechaIni, string fechaFin)
    {
        this.error = "";
        DataTable DT = objDatosTramite.facturaByRangoFechas(fechaIni,fechaFin);
        this.error = objDatosTramite.Error;
        return DT;
    }
    public Factura FacturaByNumeroF(string numeroFactura)
    {
        this.error = "";
        Factura factura = objDatosTramite.facturaByNumeroF(numeroFactura);
        this.error = objDatosTramite.Error;
        return factura;
    }

}
