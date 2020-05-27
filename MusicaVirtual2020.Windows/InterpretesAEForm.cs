using System;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Servicios;

namespace MusicaVirtual2020.Windows
{
    public partial class InterpretesAEForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ServicioPais servicioPais=new ServicioPais();
            var listaPais = servicioPais.GetLista();
            var defaultPais = new Pais
            {
                PaisId = 0,
                Nombre = "<Seleccione País>"
            };
            listaPais.Insert(0,defaultPais);
            paisesComboBox.DataSource = listaPais;
            paisesComboBox.DisplayMember = "Nombre";
            paisesComboBox.ValueMember = "PaisId";
            paisesComboBox.SelectedIndex = 0;

            if (interprete!=null)
            {
                interpreteTextBox.Text = interprete.Nombre;
                paisesComboBox.SelectedValue = interprete.Pais.PaisId;
            }
        }

        private Interprete interprete;
        public InterpretesAEForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (interprete==null)
                {
                    interprete=new Interprete();
                }

                interprete.Nombre = interpreteTextBox.Text;
                interprete.Pais =(Pais) paisesComboBox.SelectedItem;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(interpreteTextBox.Text) && string.IsNullOrWhiteSpace(interpreteTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(interpreteTextBox,"El nombre del intérprete es requerido");
            }

            if (paisesComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(paisesComboBox, "Debe seleccionar un país");

            }

            return valido;
        }

        public Interprete GetInterprete()
        {
            return interprete;
        }

        public void SetInterprete(Interprete interprete)
        {
            this.interprete = interprete;
        }
    }
}
