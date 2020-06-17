using System.Windows.Forms;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;
using MusicaVirtual2020.Servicios;

namespace MusicaVirtual2020.Windows.Helpers
{
    public class Helper
    {
        public static void CargarDatosComboPaises(ref ComboBox combo)
        {
            ServicioPais servicio = new ServicioPais();
            var lista = servicio.GetLista();
            Pais defaultPais = new Pais { PaisId = 0, Nombre = "<Seleccione País>" };
            lista.Insert(0, defaultPais);
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "PaisId";
            combo.SelectedIndex = 0;

        }

    }
}
