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
    public partial class frmReportViewer : Form
    {
        int id_responsable;
        int id_area;
        int id_servicio;

        public frmReportViewer(int resp, int area, int serv)
        {
            InitializeComponent();
            id_responsable = resp;
            id_area = area;
            id_servicio = serv;
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.ORDENES_DE_TRABAJO' Puede moverla o quitarla según sea necesario.
            this.ORDENES_DE_TRABAJOTableAdapter.Fill(this.DataSetReportes.ORDENES_DE_TRABAJO);
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.ORDENES_DE_TRABAJO' Puede moverla o quitarla según sea necesario.
            //this.ORDENES_DE_TRABAJOTableAdapter.Fill(this.DataSetReportes.ORDENES_DE_TRABAJO);
            this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_Areas(this.DataSetReportes.ORDENES_DE_TRABAJO,1,1);

            this.reportViewer1.RefreshReport();
        }
    }
}
