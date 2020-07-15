using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades.DTOs.Album;
using MusicaVirtual2020.Entidades.Entities;
using MusicaVirtual2020.Entidades.Mapas;
using MusicaVirtual2020.Servicios;
using MusicaVirtual2020.Windows.Helpers;

namespace MusicaVirtual2020.Windows
{
    public partial class AlbumesForm : Form
    {
        private static AlbumesForm _instancia = null;

        public static AlbumesForm GetInstancia()
        {
            if (_instancia==null)
            {
                _instancia=new AlbumesForm();
                _instancia.FormClosed += Form_close;
            }

            return _instancia;
        }

        private static void Form_close(object sender, FormClosedEventArgs e)
        {
            _instancia = null;
        }

        private AlbumesForm()
        {
            InitializeComponent();
        }

        private ServicioAlbumes servicio;
        private List<AlbumListDto> lista;
        private void AlbumesForm_Load(object sender, System.EventArgs e)
        {
            servicio=new ServicioAlbumes();
            try
            {
                lista = servicio.GetAlbumes();
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
            foreach (var albumListDto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, albumListDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, AlbumListDto album)
        {
            r.Cells[cmnAlbum.Index].Value = album.Titulo;
            r.Cells[cmnInterprete.Index].Value = album.Interprete;
            r.Cells[cmnPistas.Index].Value = album.Pistas;

            r.Tag = album;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r=new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void CerrarToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            AlbumesAEForm frm=new AlbumesAEForm();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK) 
            {
                try
                {
                    Album album = frm.GetAlbum();
                    servicio.Agregar(album);
                    DataGridViewRow r = ConstruirFila();
                    AlbumListDto albumListDto = Mapeador.ConvertirDesdeAlbum(album);
                    SetearFila(r,albumListDto);
                    AgregarFila(r);
                    Helper.mensajeBox("Registro agregado con éxito", Tipo.Success);
                }
                catch (Exception exception)
                {
                    Helper.mensajeBox(exception.Message, Tipo.Error);

                }
            }
        }
    }
}
