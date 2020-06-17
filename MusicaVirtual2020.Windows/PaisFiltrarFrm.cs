using System;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;
using MusicaVirtual2020.Servicios;
using MusicaVirtual2020.Windows.Helpers;

namespace MusicaVirtual2020.Windows
{
    public partial class PaisFiltrarFrm : Form
    {
        public PaisFiltrarFrm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarDatosComboPaises(ref PaisesCombox);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private Pais _pais;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                _pais =(Pais) PaisesCombox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (PaisesCombox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(PaisesCombox,"Debe seleccionar un país");
            }

            return valido;
        }

        public Pais GetPais()
        {
            return _pais;
        }
    }
}
