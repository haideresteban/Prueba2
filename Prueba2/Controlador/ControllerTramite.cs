using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
}
