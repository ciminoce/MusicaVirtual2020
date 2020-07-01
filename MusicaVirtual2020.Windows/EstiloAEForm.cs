using System;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Windows
{
    public partial class EstiloAEForm : Form
    {
        public EstiloAEForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private Estilo estilo;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (estilo==null)
                {
                    estilo=new Estilo();
                }

                estilo.Nombre = EstiloTextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(EstiloTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(EstiloTextBox,"Debe ingrese un estilo");
            }

            return valido;
        }

        public Estilo GetEstilo()
        {
            return estilo;
        }
    }
}
