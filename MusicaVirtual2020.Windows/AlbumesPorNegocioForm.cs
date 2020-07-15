using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades.DTOs.Negocio;
using MusicaVirtual2020.Servicios;
using MusicaVirtual2020.Windows.Helpers;

namespace MusicaVirtual2020.Windows
{
    public partial class AlbumesPorNegocioForm : Form
    {
        public AlbumesPorNegocioForm()
        {
            InitializeComponent();
        }

        private List<NegocioAlbumesDto> lista;
        private ServicioAlbumes servicio;
        private void CerrarlButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlbumesPorNegocioForm_Load(object sender, EventArgs e)
        {
            servicio=new ServicioAlbumes();
            try
            {
                lista = servicio.GetCantidadPorNegocio();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                Helper.mensajeBox(ex.Message, Tipo.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var negocioAlbumesDto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, negocioAlbumesDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, NegocioAlbumesDto negocioAlbumesDto)
        {
            r.Cells[cmnNegocio.Index].Value = negocioAlbumesDto.Negocio;
            r.Cells[cmnCantidad.Index].Value = negocioAlbumesDto.Cantidad;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

    }
}
