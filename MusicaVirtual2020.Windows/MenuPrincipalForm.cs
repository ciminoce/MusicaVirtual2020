using System;
using System.Windows.Forms;

namespace MusicaVirtual2020.Windows
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PaisesToolStripButton_Click(object sender, EventArgs e)
        {
            var frm = PaisesForm.GetInstancia();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
           
            frm.Show();
        }

       
        

        private void EstilosToolStripButton_Click(object sender, EventArgs e)
        {
            EstilosForm frm = EstilosForm.GetInstancia();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            

            frm.Show();

        }

        private void InterpretesToolStripButton_Click(object sender, EventArgs e)
        {
            InterpretesForm frm = InterpretesForm.GetInstancia();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;


            frm.Show();

        }

        private void SoportesToolStripButton_Click(object sender, EventArgs e)
        {
            SoportesForm frm = SoportesForm.GetInstancia();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;


            frm.Show();

        }

        private void NegociosToolStripButton_Click(object sender, EventArgs e)
        {
            NegociosForm frm = NegociosForm.GetInstancia();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;


            frm.Show();

        }
    }
}
