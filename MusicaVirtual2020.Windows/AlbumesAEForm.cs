﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private AlbumEditDto albumDto;
        private List<TemaListDto> temasDto=new List<TemaListDto>();
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
                if (albumDto==null)
                {
                    albumDto=new AlbumEditDto();
                }

                albumDto.Titulo = TituloTextBox.Text;
                albumDto.InterpreteListDto =Mapeador.ConvertirInterpreteListDto((Interprete) interpretesComboBox.SelectedItem);
                albumDto.EstiloListDto=Mapeador.ConvertirEstiloDto((Estilo) estiloComboBox.SelectedItem);
                albumDto.SoporteListDto = Mapeador.ConvertirSoporteDto((Soporte) soporteComboBox.SelectedItem);
                albumDto.NegocioListDto = Mapeador.ConvertirNegocioDto((Negocio) negocioComboBox.SelectedItem);
                albumDto.Pistas = (Int16) pistasNumericUpDown.Value;
                albumDto.Costo = decimal.Parse(costoTextBox.Text);
                albumDto.AnioCompra = int.Parse(anioCompraTextBox.Text);

                albumDto.TemasDto = temasDto;
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

        public AlbumEditDto GetAlbum()
        {
            return albumDto;
        }

        private void agregarTemaButton_Click(object sender, EventArgs e)
        {
            TemasAEForm frm=new TemasAEForm();
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                TemaListDto temaDto = frm.GetTema();
                temaDto.NroTema = temasDto.Count+1;
                //TODO: ver que el tema no esté repetido
                temasDto.Add(temaDto);
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, temaDto);
                AgregarFila(r);
                if (pistasNumericUpDown.Value==temasDto.Count)
                {
                    agregarTemaButton.Enabled = false;
                }
                else
                {
                    agregarTemaButton.Enabled = true;
                }
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            temasDatosGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TemaListDto temaDto)
        {
            r.Cells[cmnNro.Index].Value = temaDto.NroTema;
            r.Cells[cmnTema.Index].Value = temaDto.Nombre;
            r.Cells[cmnDuracion.Index].Value = temaDto.Duracion;

            r.Tag = temaDto;
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
