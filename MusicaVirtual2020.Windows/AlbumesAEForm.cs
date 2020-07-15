using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades.DTOs.Album;
using MusicaVirtual2020.Entidades.DTOs.Tema;
using MusicaVirtual2020.Entidades.Entities;
using MusicaVirtual2020.Entidades.Mapas;
using MusicaVirtual2020.Windows.Helpers;

namespace MusicaVirtual2020.Windows
{
    public partial class AlbumesAEForm : Form
    {
        public AlbumesAEForm()
        {
            InitializeComponent();
        }

        private Album album;
        private List<Tema> temas=new List<Tema>();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarDatosComboEstilos(ref estiloComboBox);
            Helper.CargarDatosComboInterpretes(ref interpretesComboBox);
            Helper.CargarDatosComboNegocios(ref negocioComboBox);
            Helper.CargarDatosComboSoportes(ref soporteComboBox);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (album==null)
                {
                    album=new Album();
                }

                album.Titulo = TituloTextBox.Text;
                album.Interprete =(Interprete) interpretesComboBox.SelectedItem;
                album.Estilo=(Estilo) estiloComboBox.SelectedItem;
                album.Soporte = (Soporte) soporteComboBox.SelectedItem;
                album.Negocio = (Negocio) negocioComboBox.SelectedItem;
                album.Pistas = (Int16) pistasNumericUpDown.Value;
                album.Costo = decimal.Parse(costoTextBox.Text);
                album.AnioCompra = int.Parse(anioCompraTextBox.Text);

                album.Temas = temas;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TituloTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TituloTextBox,"El Título es requerido");
            }

            if (interpretesComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(interpretesComboBox,"Debe seleccionar un intérprete");
            }
            if (estiloComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(estiloComboBox, "Debe seleccionar un estilo");
            }
            if (negocioComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(negocioComboBox, "Debe seleccionar un negocio");
            }
            if (soporteComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(soporteComboBox, "Debe seleccionar un soporte");
            }

            if (!int.TryParse(anioCompraTextBox.Text,out int anio))
            {
                valido = false;
                errorProvider1.SetError(anioCompraTextBox,"Año mal ingresado");
            }else if (anio<1970 ||anio>DateTime.Now.Year)
            {
                valido = false;
                errorProvider1.SetError(anioCompraTextBox,"Año fuera del rango permitido");
            }

            if (!decimal.TryParse(costoTextBox.Text, out decimal costo))
            {
                valido = false;
                errorProvider1.SetError(costoTextBox,"Debe ingresar un costo");
            }else if (costo<0 ||costo>decimal.MaxValue-1)
            {
                valido = false;
                errorProvider1.SetError(costoTextBox,"Costo fuera del rango permitido");
            }
            return valido;
        }

        public Album GetAlbum()
        {
            return album;
        }

        private void agregarTemaButton_Click(object sender, EventArgs e)
        {
            TemasAEForm frm=new TemasAEForm();
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                Tema tema = frm.GetTema();

                if (!temas.Contains(tema))
                {
                    tema.PistaNro = temas.Count + 1;
                    temas.Add(tema);
                    DataGridViewRow r = ConstruirFila();
                    SetearFila(r, tema);
                    AgregarFila(r);
                    if (pistasNumericUpDown.Value == temas.Count)
                    {
                        agregarTemaButton.Enabled = false;
                    }
                    else
                    {
                        agregarTemaButton.Enabled = true;
                    }
                }
                else
                {
                    Helper.mensajeBox("Tema repetido... ", Tipo.Error);
                }
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            temasDatosGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Tema tema)
        {
            r.Cells[cmnNro.Index].Value = tema.PistaNro;
            r.Cells[cmnTema.Index].Value = tema.Nombre;
            r.Cells[cmnDuracion.Index].Value = tema.Duracion;

            r.Tag = tema;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r=new DataGridViewRow();
            r.CreateCells(temasDatosGridView);
            return r;
        }

        private void pistasNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (pistasNumericUpDown.Value>0)
            {
                agregarTemaButton.Enabled = true;
            }
            else
            {
                agregarTemaButton.Enabled = false;
            }
        }
    }
}
