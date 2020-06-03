using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Servicios;

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
            ServicioPais servicio=new ServicioPais();
            var lista = servicio.GetLista();
            Pais defaultPais = new Pais {PaisId = 0, Nombre = "<Seleccione País>"};
            lista.Insert(0,defaultPais);
            PaisesCombox.DataSource = lista;
            PaisesCombox.DisplayMember = "Nombre";
            PaisesCombox.ValueMember = "PaisId";
            PaisesCombox.SelectedIndex = 0;
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
