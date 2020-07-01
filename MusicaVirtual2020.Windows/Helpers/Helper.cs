using System.Windows.Forms;
using MusicaVirtual2020.Entidades.DTOs.Estilo;
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

        public static void CargarDatosComboInterpretes(ref ComboBox combo)
        {
            ServicioInterprete servicio = new ServicioInterprete();
            var lista = servicio.GetInterpretes();
            Interprete defaultInterprete = new Interprete() { InterpreteId = 0, Nombre = "<Seleccione Interprete>" };
            lista.Insert(0, defaultInterprete);
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "InterpreteId";
            combo.SelectedIndex = 0;

        }

        public static void CargarDatosComboNegocios(ref ComboBox combo)
        {
            ServicioNegocio servicio = new ServicioNegocio();
            var lista = servicio.GetNegocios();
            Negocio defaultNegocio = new Negocio() { NegocioId = 0, Nombre = "<Seleccione Negocio>" };
            lista.Insert(0, defaultNegocio);
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "NegocioId";
            combo.SelectedIndex = 0;

        }

        public static void CargarDatosComboSoportes(ref ComboBox combo)
        {
            ServicioSoporte servicio = new ServicioSoporte();
            var lista = servicio.GetLista();
            Soporte defaultSoporte = new Soporte() { SoporteId = 0, Descripcion = "<Seleccione Soporte>" };
            lista.Insert(0, defaultSoporte);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "SoporteId";
            combo.SelectedIndex = 0;

        }
        public static void CargarDatosComboEstilos(ref ComboBox combo)
        {
            ServicioEstilo servicio = new ServicioEstilo();
            var lista = servicio.GetLista();
            Estilo defaultEstilo = new Estilo() { EstiloId = 0, Nombre = "<Seleccione Estilo>" };
            lista.Insert(0, defaultEstilo);
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "EstiloId";
            combo.SelectedIndex = 0;

        }



        public static void mensajeBox(string mensaje, Tipo tipo)
        {
            switch (tipo)
            {
                case Tipo.Success:
                    MessageBox.Show(mensaje, "Operación Exitosa", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                case Tipo.Error:
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    break;
                //case Tipo.Warning:
                //    break;
                //case Tipo.Question:
                //    break;
                //default:
                //    break;
            }
        }
        public static DialogResult mensajeBox(string mensaje)
        {
            return MessageBox.Show(mensaje, "Confirmar operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

    }
}
