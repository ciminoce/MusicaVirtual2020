using System;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;
using MusicaVirtual2020.Servicios;
using MusicaVirtual2020.Windows.Helpers;

namespace MusicaVirtual2020.Windows
{
    public partial class NegociosAEForm : Form
    {
        public NegociosAEForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarDatosComboPaises(ref paisesComboBox);
            if (negocio != null)
            {
                negocioTextBox.Text = negocio.Nombre;
                paisesComboBox.SelectedValue = negocio.Pais.PaisId;
            }
        }

        private Negocio negocio;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (negocio == null)
                {
                    negocio = new Negocio();
                }

                negocio.Nombre = negocioTextBox.Text;
                negocio.Pais = (Pais)paisesComboBox.SelectedItem;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(negocioTextBox.Text) && string.IsNullOrWhiteSpace(negocioTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(negocioTextBox, "El nombre del intérprete es requerido");
            }

            if (paisesComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(paisesComboBox, "Debe seleccionar un país");

            }

            return valido;
        }

        public Negocio GetNegocio()
        {
            return negocio;
        }

        public void SetNegocio(Negocio negocio)
        {
            this.negocio = negocio;
        }

    }
}
