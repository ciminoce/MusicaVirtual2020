using System;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades.Entities;

namespace MusicaVirtual2020.Windows
{
    public partial class TemasAEForm : Form
    {
        public TemasAEForm()
        {
            InitializeComponent();
        }

        private Tema tema;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tema == null)
                {
                    tema=new Tema();
                }

                tema.Nombre = TituloTextBox.Text;
                tema.Duracion = float.Parse(duracionTextBox.Text);

                DialogResult = DialogResult.OK;
            }
        }

        public Tema GetTema()
        {
            return tema;
        }
        private bool ValidarDatos()
        {
            return true;
        }
    }
}
