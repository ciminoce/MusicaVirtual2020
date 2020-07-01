using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades.DTOs.Tema;

namespace MusicaVirtual2020.Windows
{
    public partial class TemasAEForm : Form
    {
        public TemasAEForm()
        {
            InitializeComponent();
        }

        private TemaListDto temaDto;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (temaDto == null)
                {
                    temaDto=new TemaListDto();
                }

                temaDto.Nombre = TituloTextBox.Text;
                temaDto.Duracion = float.Parse(duracionTextBox.Text);

                DialogResult = DialogResult.OK;
            }
        }

        public TemaListDto GetTema()
        {
            return temaDto;
        }
        private bool ValidarDatos()
        {
            return true;
        }
    }
}
