using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void órdenesDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmOrdenTrabajo frm = new frmOrdenTrabajo("Nueva");
            frm.ShowDialog();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenTrabajo frm = new frmOrdenTrabajo("Nueva");
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmOrdenTrabajo frm = new frmOrdenTrabajo("Modificar");
            frm.ShowDialog();
        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenTrabajo frm = new frmOrdenTrabajo("Modificar");
            frm.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes();
            frm.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes();
            frm.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmBuscar frm = new frmBuscar();
            frm.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscar frm = new frmBuscar();
            frm.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmFiltrar frm = new frmFiltrar();
            frm.ShowDialog();
        }

        private void filtrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltrar frm = new frmFiltrar();
            frm.ShowDialog();
        }
    }
}
