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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.vw_nombreresponsables' Puede moverla o quitarla según sea necesario.
            this.vw_nombreresponsablesTableAdapter.Fill(this.sistemaOTDataSet.vw_nombreresponsables);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.RESPONSABLES' Puede moverla o quitarla según sea necesario.
            //this.rESPONSABLESTableAdapter.Fill(this.sistemaOTDataSet.RESPONSABLES);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.AREAS' Puede moverla o quitarla según sea necesario.
            this.aREASTableAdapter.FillBy(this.sistemaOTDataSet.AREAS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.SERVICIOS' Puede moverla o quitarla según sea necesario.
            this.sERVICIOSTableAdapter.FillBy(this.sistemaOTDataSet.SERVICIOS);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmReportViewer rv;
            Reporte rp;

            if (dtpFechaInicio.Value.Date > dtpFechaFinal.Value.Date)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (radResponsable.Checked)
            {
                if (cbArea.SelectedItem != null && cbServicio.SelectedItem != null)
                     rp = Reporte.Responsables_DobleFiltro;
                else if (cbArea.SelectedItem != null)
                    rp = Reporte.Responsables_Areas;
                else if (cbServicio.SelectedItem != null)
                    rp = Reporte.Responsables_Servicios;
                else
                    rp = Reporte.Responsables_Todos;

            }
            else if (radArea.Checked)
            {
                if (cbResponsable.SelectedItem != null && cbServicio.SelectedItem != null)
                    rp = Reporte.Areas_DobleFiltro;
                else if (cbResponsable.SelectedItem != null)
                    rp = Reporte.Areas_Responsables;
                else if (cbServicio.SelectedItem != null)
                    rp = Reporte.Areas_Servicios;
                else
                    rp = Reporte.Areas_Todos;
            }
            else
            {

                if (cbResponsable.SelectedItem != null && cbArea.SelectedItem != null)
                    rp = Reporte.Servicios_DobleFiltro;
                else if (cbResponsable.SelectedItem != null)
                    rp = Reporte.Servicios_Responsables;
                else if (cbArea.SelectedItem != null)
                    rp = Reporte.Servicios_Areas;
                else
                    rp = Reporte.Servicios_Todos;

            }

            if ((radResponsable.Checked && cbResponsable.SelectedItem != null) || (radArea.Checked && cbArea.SelectedItem != null) || (radServicio.Checked && cbServicio.SelectedItem != null))
            {
                rv = new frmReportViewer(rp, 
                    (cbResponsable.SelectedValue != null) ? (int)cbResponsable.SelectedValue : 0, 
                    ((radResponsable.Checked) ? cbResponsable.Text : ((radArea.Checked) ? cbArea.Text : cbServicio.Text)),                    
                    (cbArea.SelectedValue != null) ? (int)cbArea.SelectedValue : 0, 
                    (cbServicio.SelectedValue != null) ? (int)cbServicio.SelectedValue : 0,
                    chkEntregado.CheckState,
                    dtpFechaInicio.Value.ToString(),
                    dtpFechaFinal.Value.ToString()
                    );
                rv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se ha elegido un tipo de reporte, pero su lista correspondiente no ha sido seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }      
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdServicio_Click(object sender, EventArgs e)
        {
            cbServicio.SelectedItem = null;
        }

        private void cmbArea_Click(object sender, EventArgs e)
        {
            cbArea.SelectedItem = null;
        }

        private void cmdResponsable_Click(object sender, EventArgs e)
        {
            cbResponsable.SelectedItem = null;
        }
    }
}
