using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Reportes
{
    public class ManejadorDatosPaises
    {
        /*Método encargado de llenar el DataTable de Paises
         con los datos de la lista de Paises que me manda la capa
         de presentación
         */
        public MusicaVirtualDataSet PonerDatosDePaises(List<Pais> lista)
        {
            /* instancio el objeto MusicaVirtualDataSet */
            MusicaVirtualDataSet ds=new MusicaVirtualDataSet();

            /*Recorro la lista y por cada elemento de la misma
             voy agregando una fila en el datatable correspondiente tomando el
             nombre del país únicamente*/
            foreach (var pais in lista)
            {
                ds.Tables["PaisesDataTable"].Rows.Add(pais.Nombre);

            }

            /*En este punto ya tengo todos los datos en el dataSet */
            return ds; // lo retorno la manejador de reportes
        }
    }
}
