using CrystalDecisions.Shared;
using System.Data;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba2.Modelo;

namespace Prueba2.Reporte.Factura
{
  public   class CgGenerarFacturaT
    {
        public void generar(Modelo.Factura unaFactura, Tramite unTramite, string placa, string idenPropietario  )
        {
            DsFactura dsF = new DsFactura();
            DataRow fila1 = dsF.FACTURATRAMITE.NewRow();
            DatosPropietario objDatosPropi = new DatosPropietario();
            Propietario unPropietario = new Propietario();
           unPropietario= objDatosPropi.buscarPropietario(idenPropietario);
            fila1["FT_NUMERO"] = unaFactura.numero;
            fila1["FT_FECHA"] = unaFactura.fecha;
            fila1["FT_PLACA"] = placa;
            fila1["FT_IDENTIFICACION_PROPI"] = idenPropietario;
            fila1["FT_PROPIETARIO_NOMBRE"] = unPropietario.nombres;
            fila1["FT_PROPIETARIO_APELLIDO"] = unPropietario.apellidos;
            fila1["FT_VALOR"] = unTramite.valor;
            fila1["FT_DESCRIPCION"] = unTramite.descripcion;
           dsF.FACTURATRAMITE.Rows.Add(fila1);
            frmGenerarFacturaT frm = new frmGenerarFacturaT(dsF);
            frm.ShowDialog();
            dsF.FACTURATRAMITE.Dispose();
            dsF = null;





        }

    }
}
