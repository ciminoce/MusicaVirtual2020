using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicaVirtual2020.Entidades.DTOs.Interprete;
using MusicaVirtual2020.Servicios;
using MusicaVirtual2020.Windows.Helpers;

namespace MusicaVirtual2020.Windows
{
    public partial class AlbumesPorInterpretesForm : Form
    {
        public AlbumesPorInterpretesForm()
        {
            InitializeComponent();
        }

        private void CerrarlButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<InterpreteAlbumesDto> lista;
        private ServicioAlbumes servicio;
        private void AlbumesPorInterpretesForm_Load(object sender, EventArgs e)
        {
            servicio=new ServicioAlbumes();
            try
            {
                lista = servicio.GetCantidadPorInterprete();
                MostrarDatosEnGrilla();

            }
            catch (Exception ex)
            {

                Helper.mensajeBox(ex.Message,Tipo.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var interpreteAlbumesDto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, interpreteAlbumesDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, InterpreteAlbumesDto interpreteAlbumesDto)
        {
            r.Cells[cmnInterprete.Index].Value = interpreteAlbumesDto.Interprete;
            r.Cells[cmnCantidad.Index].Value = interpreteAlbumesDto.Cantidad;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r=new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }
    }
}
