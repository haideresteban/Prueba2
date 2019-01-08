using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba2.Modelo;

public class ControllerPropietario
{

    public int? id;
    private string error;
    DatosPropietario objDatosPropietario;

    public ControllerPropietario(int? id = null)
    {
        objDatosPropietario = new DatosPropietario();
        this.id = id;
    }
    public bool agregarPropietario(Propietario unPropietario)
    {
        this.error = "";
        bool agrega = objDatosPropietario.agregarPropietario(unPropietario);
        this.error = objDatosPropietario.Error;
        return agrega;
    }

    public List<Propietario> listaPropietarios()
    {
        this.error = "";
        List<Propietario> listaPropietarios = objDatosPropietario.listarPropietarios();
        this.error = objDatosPropietario.Error;
        
        return listaPropietarios;
    }
    public Propietario buscarPropietario(string identificacion)
    {
        this.error = " ";
        Propietario unPropietario = objDatosPropietario.buscarPropietario(identificacion);
        this.error = objDatosPropietario.Error;
        return unPropietario;
    }
    public bool actualizarPropietario(Propietario propietario)
    {
        this.error = "";
        bool actualizado = objDatosPropietario.actualizarPropietario(propietario);
        this.error = objDatosPropietario.Error;
        return actualizado;
    }




    public string Error
    {
        get { return error; }
        set { error = value; }
    }
}

