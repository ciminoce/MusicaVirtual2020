using System;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Windows
{
    public partial class SoportesAEForm : Form
    {
        public SoportesAEForm()
        {
            InitializeComponent();
        }
        private Soporte soporte;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (soporte != null)
            {
                soporteTextBox.Text = soporte.Descripcion;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (soporte == null)
                {
                    soporte = new Soporte();
                }

                soporte.Descripcion = soporteTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(soporteTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(soporteTextBox, "Debe ingresar un soporte");
            }

            return valido;
        }

        public void SetSoporte(Soporte soporte)
        {
            this.soporte = soporte;
        }

        public Soporte GetSoporte()
        {
            return soporte;
        }
    }
}
