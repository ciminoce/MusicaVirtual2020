using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicaVirtual2020.Reportes;

namespace MusicaVirtual2020.Windows
{
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
        }

        private PaisesReporte rpt;
        public void SetReporte(PaisesReporte rpt)
        {
            this.rpt = rpt;
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
            reportViewer.ReportSource = rpt;
        }
    }
}
