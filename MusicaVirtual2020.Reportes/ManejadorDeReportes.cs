using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Reportes
{
    /*Clase encargada de recibir los datos de la capa
     de presentación, de seleccionar un manejador de datos correspondiente
     y de enviar a la capa de presentación el reporte con sus datos*/
    public class ManejadorDeReportes
    {
        /*Método encargado de enviar el reporte de paises */
        public PaisesReporte GetPaisesReporte(List<Pais> lista)
        {
            //Creo un reporte de tipo PaisesReporte
            PaisesReporte rpt=new PaisesReporte();
            //Instancio el manejador de datos de paises
            ManejadorDatosPaises manejadorDatos=new ManejadorDatosPaises();
            /* Uso el método PonerDatosDePaises par que se encargue de
             llenar el DataTable correspondiente con los datos de la 
             lista que me pasó la capa de datos*/
            var ds = manejadorDatos.PonerDatosDePaises(lista);
            /*En este punto ya tengo el reporte y los datos */
            rpt.SetDataSource(ds); //Asigno el objeto ds como fuente de datos del reporte
            return rpt;//retorno el reporte a la capa de presentación.
        }
        public InterpretesFiltrado GetInterpretesReporteFiltrado(List<Interprete> lista)
        {
            InterpretesFiltrado rpt = new InterpretesFiltrado();
            ManejadorDatosInterpretes manejadorDatos = new ManejadorDatosInterpretes();
            var ds = manejadorDatos.PonerDatosDeInterpretes(lista);
            rpt.SetDataSource(ds);
            return rpt;
        }

        public InterpretesReporte GetInterpretesReporte(List<Interprete> lista)
        {
            InterpretesReporte rpt=new InterpretesReporte();
            ManejadorDatosInterpretes manejadorDatos=new ManejadorDatosInterpretes();
            var ds = manejadorDatos.PonerDatosDeInterpretes(lista);
            rpt.SetDataSource(ds);
            return rpt;
        }

        public InterpretesAgrupadoPorPais GetReporteInterpretesAgrupados(List<Interprete> lista)
        {
            InterpretesAgrupadoPorPais rpt = new InterpretesAgrupadoPorPais();
            ManejadorDatosInterpretes manejadorDatos = new ManejadorDatosInterpretes();
            var ds = manejadorDatos.PonerDatosDeInterpretes(lista);
            rpt.SetDataSource(ds);
            return rpt;
        }
    }
}
