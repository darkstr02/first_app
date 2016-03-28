﻿using System;
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

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarUsuarios frm = new frmAdministrarUsuarios();
            frm.ShowDialog();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioContrasena frm = new frmCambioContrasena();
            frm.ShowDialog();
        }

        private void administrarResponsablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarResponsables frm = new frmAdministrarResponsables();
            frm.ShowDialog();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.vw_ordenes' Puede moverla o quitarla según sea necesario.
            this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.ORDENES_DE_TRABAJO' Puede moverla o quitarla según sea necesario.
           // this.oRDENES_DE_TRABAJOTableAdapter.Fill(this.sistemaOTDataSet.ORDENES_DE_TRABAJO);

        }
    }
}
