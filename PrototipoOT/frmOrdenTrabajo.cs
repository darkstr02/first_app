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
    public partial class frmOrdenTrabajo : Form
    {
        public frmOrdenTrabajo(String title)
        {
            InitializeComponent();
            this.Text = title + " Órden de Trabajo";
        }

        private void frmOrdenTrabajo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.ORDENES_DE_TRABAJO' Puede moverla o quitarla según sea necesario.
            this.oRDENES_DE_TRABAJOTableAdapter.Fill(this.sistemaOTDataSet.ORDENES_DE_TRABAJO);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.vw_nombreresponsables' Puede moverla o quitarla según sea necesario.
            this.vw_nombreresponsablesTableAdapter.Fill(this.sistemaOTDataSet.vw_nombreresponsables);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.RESPONSABLES' Puede moverla o quitarla según sea necesario.
            this.rESPONSABLESTableAdapter.Fill(this.sistemaOTDataSet.RESPONSABLES);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet1.AREAS' Puede moverla o quitarla según sea necesario.
            this.aREASTableAdapter.Fill(this.sistemaOTDataSet1.AREAS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.SERVICIOS' Puede moverla o quitarla según sea necesario.
            this.sERVICIOSTableAdapter.Fill(this.sistemaOTDataSet.SERVICIOS);

            //

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sERVICIOSTableAdapter.FillBy(this.sistemaOTDataSet.SERVICIOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmItems frm = new frmItems();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                this.sERVICIOSTableAdapter.Fill(this.sistemaOTDataSet.SERVICIOS);
                this.aREASTableAdapter.Fill(this.sistemaOTDataSet1.AREAS);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            DataRow nuevo = this.sistemaOTDataSet.ORDENES_DE_TRABAJO.NewRow();

            nuevo["consecutivo"] = txtConsecutivo.Text;
            nuevo["solicitante"] = txtSolicitante.Text;

            DataRowView serv = (DataRowView) cbServicio.SelectedItem;
            DataRowView area = (DataRowView) cbArea.SelectedItem;
            DataRowView resp = (DataRowView)cbResponsable.SelectedItem;

            nuevo["id_servicio"] = serv.Row[0];
            nuevo["id_area"] = area.Row[0];
            nuevo["id_responsable"] = resp.Row[0];

            nuevo["entregado"] = rbEntregadoSi.Checked;
            nuevo["descripcion"] = txtDescripcion.Text;
            nuevo["observaciones"] = txtObservaciones.Text;
            nuevo["fecha_inicio"] = dtpFecha.Value;

            if (rbEntregadoSi.Checked)
                nuevo["fecha_entregado"] = DateTime.Now;
            else
                nuevo["fecha_entregado"] = System.DBNull.Value;

            this.sistemaOTDataSet.ORDENES_DE_TRABAJO.Rows.Add(nuevo);
            this.oRDENES_DE_TRABAJOTableAdapter.Update(this.sistemaOTDataSet.ORDENES_DE_TRABAJO);
            this.Close();
        }
    }
}
