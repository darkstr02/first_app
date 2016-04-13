using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PrototipoOT
{
    public partial class frmReportViewer : Form
    {
        int id_responsable;
        int id_area;
        int id_servicio;
        string nombre_responsable;
        Reporte reporte;


        public frmReportViewer(Reporte rp, int resp, string nombre_resp, int area, int serv)
        {
            InitializeComponent();
            id_responsable = resp;
            id_area = area;
            id_servicio = serv;
            nombre_responsable = nombre_resp;
            reporte = rp;
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.ORDENES_DE_TRABAJO' Puede moverla o quitarla según sea necesario.
            this.ORDENES_DE_TRABAJOTableAdapter.Fill(this.DataSetReportes.ORDENES_DE_TRABAJO);


            ReportParameter p1 = new ReportParameter("rpResponsable", nombre_responsable);


            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });

            switch (reporte)
            {   //Responsables
                case Reporte.Responsables_Todos:
                {
                    this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_Todos(this.DataSetReportes.ORDENES_DE_TRABAJO, id_responsable);
                    break;
                }

                case Reporte.Responsables_Areas:
                {
                    this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_Areas(this.DataSetReportes.ORDENES_DE_TRABAJO, id_responsable,id_area);
                    break;
                }

                case Reporte.Responsables_Servicios:
                {
                    this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_Servicios(this.DataSetReportes.ORDENES_DE_TRABAJO, id_responsable,id_servicio);
                    break;
                }

                case Reporte.Responsables_DobleFiltro:
                {
                    this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_DobleFiltro(this.DataSetReportes.ORDENES_DE_TRABAJO, id_responsable,id_servicio,id_area);
                    break;
                }
                    // Areas
                case Reporte.Areas_Todos:
                {
                    this.ORDENES_DE_TRABAJOTableAdapter.FillByAreas_Todos(this.DataSetReportes.ORDENES_DE_TRABAJO, id_area);
                    break;
                }

                case Reporte.Areas_Responsables:
                {
                    this.ORDENES_DE_TRABAJOTableAdapter.FillByAreas_Responsables(this.DataSetReportes.ORDENES_DE_TRABAJO, id_area, id_responsable);
                    break;
                }

                case Reporte.Areas_Servicios:
                {
                    this.ORDENES_DE_TRABAJOTableAdapter.FillByAreas_Servicios(this.DataSetReportes.ORDENES_DE_TRABAJO, id_area, id_servicio);
                    break;
                }

                case Reporte.Areas_DobleFiltro:
                {
                    this.ORDENES_DE_TRABAJOTableAdapter.FillByAreas_DobleFiltro(this.DataSetReportes.ORDENES_DE_TRABAJO, id_area, id_responsable, id_servicio);
                    break;
                }

                // Servicios
                case Reporte.Servicios_Todos:
                {
                    this.ORDENES_DE_TRABAJOTableAdapter.FillByServicios_Todos(this.DataSetReportes.ORDENES_DE_TRABAJO, id_servicio);
                    break;
                }

                case Reporte.Servicios_Responsables:
                {
                    this.ORDENES_DE_TRABAJOTableAdapter.FillByServicios_Responsables(this.DataSetReportes.ORDENES_DE_TRABAJO, id_servicio, id_responsable);
                    break;
                }

                case Reporte.Servicios_Areas:
                {
                    this.ORDENES_DE_TRABAJOTableAdapter.FillByServicios_Areas(this.DataSetReportes.ORDENES_DE_TRABAJO, id_servicio, id_area);
                    break;
                }

                case Reporte.Servicios_DobleFiltro:
                {
                    this.ORDENES_DE_TRABAJOTableAdapter.FillByServicios_DobleFiltro(this.DataSetReportes.ORDENES_DE_TRABAJO, id_servicio, id_area, id_responsable );
                    break;
                }
            }



            //ReportParameter p1 = new ReportParameter("rpResponsable", nombre_responsable);
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });
            //this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_Areas(this.DataSetReportes.ORDENES_DE_TRABAJO,1,1);



            this.reportViewer1.RefreshReport();
        }
    }
}
