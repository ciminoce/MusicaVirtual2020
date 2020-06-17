using System;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Windows
{
    public partial class PaisesAEForm : Form
    {
        public PaisesAEForm()
        {
            InitializeComponent();
        }

        private Pais pais;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (pais!=null)
            {
                PaisTextBox.Text = pais.Nombre;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (pais==null)
                {
                    pais=new Pais();
                }

                pais.Nombre = PaisTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(PaisTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(PaisTextBox,"Debe ingresar un país");
            }

            return valido;
        }

        public Pais GetPais()
        {
            return pais;
        }

        public void SetPais(Pais pais)
        {
            this.pais = pais;
        }
    }
}
