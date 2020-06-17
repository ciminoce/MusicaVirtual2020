using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades;
using MusicaVirtual2020.Entidades.Entities;
using MusicaVirtual2020.Reportes;
using MusicaVirtual2020.Servicios;

namespace MusicaVirtual2020.Windows
{
    public partial class NegociosForm : Form
    {
        private NegociosForm()
        {
            InitializeComponent();
        }
        private static NegociosForm instancia = null;

        public static NegociosForm GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new NegociosForm();
                instancia.FormClosed += form_Close;
            }

            return instancia;
        }

        private static void form_Close(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }


        private List<Negocio> lista;
        private ServicioNegocio servicio;
        private void NegociosForm_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioNegocio();
                lista = servicio.GetNegocios();
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
            foreach (var negocio in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, negocio);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Negocio negocio)
        {
            r.Cells[cmnNegocio.Index].Value = negocio.Nombre;
            r.Cells[cmnPais.Index].Value = negocio.Pais.Nombre;


            r.Tag = negocio;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void CerrarToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            NegociosAEForm frm = new NegociosAEForm();
            frm.Text = "Nuevo Intérprete";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Negocio negocio = frm.GetNegocio();

                    if (!servicio.Existe(negocio))
                    {
                        servicio.Agregar(negocio);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, negocio);
                        AgregarFila(r);
                        MessageBox.Show("Registro agregado", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Registro Duplicado \nAlta Denegada", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DatosDataGridView.SelectedRows[0];
                Negocio negocio = (Negocio)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja al intérprete {negocio.Nombre}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!servicio.EstaRelaciona(negocio))
                        {
                            servicio.Borrar(negocio);
                            DatosDataGridView.Rows.Remove(r);
                            MessageBox.Show("Registro Borrado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Intérprete con Álbumes \nBaja Denegada", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DatosDataGridView.SelectedRows[0];
                Negocio negocio = (Negocio)r.Tag;
                Negocio negocioAux = (Negocio)negocio.Clone();
                NegociosAEForm frm = new NegociosAEForm();
                frm.Text = "Editar Intérprete";
                frm.SetNegocio(negocio);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        negocio = frm.GetNegocio();

                        if (!servicio.Existe(negocio))
                        {
                            servicio.Agregar(negocio);
                            SetearFila(r, negocio);
                            MessageBox.Show("Registro agregado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            SetearFila(r, negocioAux);

                            MessageBox.Show("Registro Duplicado \nAlta Denegada", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lista = servicio.GetNegocios();
            //ManejadorDeReportes manejadorDeReportes = new ManejadorDeReportes();
            //NegociosReporte rpt = manejadorDeReportes.GetNegociosReporte(lista);
            //ReportesForm frm = new ReportesForm();
            //frm.SetReporte(rpt);
            //frm.ShowDialog(this);
        }

        private void agrupadoXPaísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lista = servicio.GetNegocios();
            //ManejadorDeReportes manejadorDeReportes = new ManejadorDeReportes();
            //NegociosAgrupadoPorPais rpt = manejadorDeReportes.GetReporteNegociosAgrupados(lista);
            //ReportesForm frm = new ReportesForm();
            //frm.SetReporte(rpt);
            //frm.ShowDialog(this);

        }

        private void filtradoXPaísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PaisFiltrarFrm frm = new PaisFiltrarFrm();
            //DialogResult dr = frm.ShowDialog(this);
            //if (dr == DialogResult.OK)
            //{
            //    try
            //    {
            //        Pais pais = frm.GetPais();
            //        var listaFiltrada = servicio.GetNegocios(pais);
            //        ManejadorDeReportes manejador = new ManejadorDeReportes();
            //        NegociosFiltrado rpt = manejador.GetNegociosReporteFiltrado(listaFiltrada);
            //        ReportesForm frmReporte = new ReportesForm();
            //        frmReporte.SetReporte(rpt);
            //        frmReporte.ShowDialog(this);


            //    }
            //    catch (Exception exception)
            //    {
            //        MessageBox.Show(exception.Message, "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
            //}
        }

        private void BuscarToolStripButton_Click(object sender, EventArgs e)
        {
            PaisFiltrarFrm frm = new PaisFiltrarFrm();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Pais pais = frm.GetPais();
                    lista = servicio.GetNegocios(pais);
                    MostrarDatosEnGrilla();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void ActualizarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioNegocio();
                lista = servicio.GetNegocios();
                MostrarDatosEnGrilla();
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
