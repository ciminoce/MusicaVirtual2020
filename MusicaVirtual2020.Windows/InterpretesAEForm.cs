using System;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;
using MusicaVirtual2020.Servicios;
using MusicaVirtual2020.Windows.Helpers;

namespace MusicaVirtual2020.Windows
{
    public partial class InterpretesAEForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarDatosComboPaises(ref paisesComboBox);
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

        private void agregarPaisButton_Click(object sender, EventArgs e)
        {
            PaisesAEForm frm=new PaisesAEForm();
            frm.Text = "Agregar País...";
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                try
                {
                    ServicioPais servicioPais=new ServicioPais();
                    Pais pais = frm.GetPais();
                    if (!servicioPais.Existe(pais))
                    {
                        servicioPais.Agregar(pais);
                        Helper.CargarDatosComboPaises(ref paisesComboBox);
                    }
                    else
                    {
                        MessageBox.Show("País repetido", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
