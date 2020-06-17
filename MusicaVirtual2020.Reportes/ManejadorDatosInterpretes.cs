using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Reportes
{
    public class ManejadorDatosInterpretes
    {
        public MusicaVirtualDataSet PonerDatosDeInterpretes(List<Interprete> lista)
        {
            MusicaVirtualDataSet ds=new MusicaVirtualDataSet();
            foreach (var interprete in lista)
            {
                ds.Tables["InterpretesDataTable"].Rows.Add(interprete.Nombre,
                    interprete.Pais.Nombre);
            }
            return ds;
        }
        
    }
}
