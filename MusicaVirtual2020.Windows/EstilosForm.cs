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
    public partial class EstilosForm : Form
    {
        private static EstilosForm instancia = null;

        public static EstilosForm GetInstancia()
        {
            if (instancia==null)
            {
                instancia=new EstilosForm();
                instancia.FormClosed += form_Close;
            }

            return instancia;
        }

        private static void form_Close(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }

        private EstilosForm()
        {
            InitializeComponent();
        }

        private ServicioEstilo servicio;
        private List<Estilo> lista;
        private void EstilosForm_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            try
            {
                servicio=new ServicioEstilo();
                lista = servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var estilo in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, estilo);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Estilo estilo)
        {
            r.Cells[cmnEstilo.Index].Value = estilo.Nombre;

            r.Tag = estilo;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r=new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void CerrarToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            EstiloAEForm frm=new EstiloAEForm();
            frm.Text = "Agregar Estilo";
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                try
                {
                    var estilo = frm.GetEstilo();
                    servicio.Agregar(estilo);
                    DataGridViewRow r = ConstruirFila();
                    SetearFila(r,estilo);
                    AgregarFila(r);
                    MessageBox.Show("Registro agregado con éxito",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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
