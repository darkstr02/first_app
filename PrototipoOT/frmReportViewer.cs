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
        CheckState entregado;
        string fecha_ini;
        string fecha_fin;

        public frmReportViewer(Reporte rp, int resp, string nombre_resp, int area, int serv, CheckState chkSt, string fecha_inicio, string fecha_f)
        {
            InitializeComponent();
            id_responsable = resp;
            id_area = area;
            id_servicio = serv;
            nombre_responsable = nombre_resp;
            reporte = rp;
            entregado = chkSt;
            fecha_ini = fecha_inicio;
            fecha_fin = fecha_f;
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.ORDENES_DE_TRABAJO' Puede moverla o quitarla según sea necesario.

            if ((int)reporte >= (int)Reporte.Responsables_Todos && (int)reporte <= (int)Reporte.Responsables_DobleFiltro)
                reportViewer1.LocalReport.ReportEmbeddedResource = "PrototipoOT.Report1.rdlc";
            else if ((int)reporte >= (int)Reporte.Areas_Todos && (int)reporte <= (int)Reporte.Areas_DobleFiltro)
                reportViewer1.LocalReport.ReportEmbeddedResource = "PrototipoOT.Report2.rdlc";
            else
                reportViewer1.LocalReport.ReportEmbeddedResource = "PrototipoOT.Report3.rdlc";

            this.DataSetReportes.EnforceConstraints = false;
            this.ORDENES_DE_TRABAJOTableAdapter.Fill(this.DataSetReportes.ORDENES_DE_TRABAJO);


            ReportParameter p1 = new ReportParameter("rpParametro", nombre_responsable);


            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });


          
            switch (reporte)
            {   //Responsables
                case Reporte.Responsables_Todos:
                    {
                        if (entregado == CheckState.Indeterminate) 
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_Todos(this.DataSetReportes.ORDENES_DE_TRABAJO, id_responsable, fecha_ini, fecha_fin);
                        else
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_TodosEntr(this.DataSetReportes.ORDENES_DE_TRABAJO, id_responsable, fecha_ini, fecha_fin, (entregado == CheckState.Checked));
                        break;
                    }

                case Reporte.Responsables_Areas:
                    {
                        if (entregado == CheckState.Indeterminate) 
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_Areas(this.DataSetReportes.ORDENES_DE_TRABAJO, id_responsable, id_area, fecha_ini, fecha_fin);
                        else
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_AreasEntr(this.DataSetReportes.ORDENES_DE_TRABAJO, id_responsable, id_area, fecha_ini, fecha_fin, (entregado == CheckState.Checked));
                        break;
                    }

                case Reporte.Responsables_Servicios:
                    {
                        if (entregado == CheckState.Indeterminate)
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_Servicios(this.DataSetReportes.ORDENES_DE_TRABAJO, id_responsable, id_servicio, fecha_ini, fecha_fin);
                        else
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_ServiciosEntr(this.DataSetReportes.ORDENES_DE_TRABAJO, id_responsable, id_servicio, fecha_ini, fecha_fin, (entregado == CheckState.Checked));
                        break;
                    }

                case Reporte.Responsables_DobleFiltro:
                    {
                        if (entregado == CheckState.Indeterminate)
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_DobleFiltro(this.DataSetReportes.ORDENES_DE_TRABAJO, id_responsable, id_servicio, id_area, fecha_ini, fecha_fin);
                        else
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByResponsables_DobleFiltroEntr(this.DataSetReportes.ORDENES_DE_TRABAJO, id_responsable, id_servicio, id_area, fecha_ini, fecha_fin, (entregado == CheckState.Checked));
                        break;
                    }
                // Areas
                case Reporte.Areas_Todos:
                    {
                        if (entregado == CheckState.Indeterminate)
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByAreas_Todos(this.DataSetReportes.ORDENES_DE_TRABAJO, id_area, fecha_ini, fecha_fin);
                        else
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByAreas_TodosEntr(this.DataSetReportes.ORDENES_DE_TRABAJO, id_area, fecha_ini, fecha_fin, (entregado == CheckState.Checked));
                        //this.DataSetReportes.EnforceConstraints = true;
                        break;
                    }

                case Reporte.Areas_Responsables:
                    {
                        if (entregado == CheckState.Indeterminate)
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByAreas_Responsables(this.DataSetReportes.ORDENES_DE_TRABAJO, id_area, id_responsable, fecha_ini, fecha_fin);
                        else
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByAreas_ResponsablesEntr(this.DataSetReportes.ORDENES_DE_TRABAJO, id_area, id_responsable, fecha_ini, fecha_fin, (entregado == CheckState.Checked));
                        break;
                    }

                case Reporte.Areas_Servicios:
                    {
                        if (entregado == CheckState.Indeterminate)
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByAreas_Servicios(this.DataSetReportes.ORDENES_DE_TRABAJO, id_area, id_servicio, fecha_ini, fecha_fin);
                        else
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByAreas_ServiciosEntr(this.DataSetReportes.ORDENES_DE_TRABAJO, id_area, id_servicio, fecha_ini, fecha_fin, (entregado == CheckState.Checked));
                        break;
                    }

                case Reporte.Areas_DobleFiltro:
                    {
                        if (entregado == CheckState.Indeterminate)
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByAreas_DobleFiltro(this.DataSetReportes.ORDENES_DE_TRABAJO, id_area, id_responsable, id_servicio, fecha_ini, fecha_fin);
                        else
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByAreas_DobleFiltroEntr(this.DataSetReportes.ORDENES_DE_TRABAJO, id_area, id_responsable, id_servicio, fecha_ini, fecha_fin, (entregado == CheckState.Checked));
                        break;
                    }

                // Servicios
                case Reporte.Servicios_Todos:
                    {
                        if (entregado == CheckState.Indeterminate)
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByServicios_Todos(this.DataSetReportes.ORDENES_DE_TRABAJO, id_servicio, fecha_ini, fecha_fin);
                        else
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByServicios_TodosEntr(this.DataSetReportes.ORDENES_DE_TRABAJO, id_servicio, fecha_ini, fecha_fin, (entregado == CheckState.Checked));

                        break;
                    }

                case Reporte.Servicios_Responsables:
                    {
                        if (entregado == CheckState.Indeterminate)
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByServicios_Responsables(this.DataSetReportes.ORDENES_DE_TRABAJO, id_servicio, id_responsable, fecha_ini, fecha_fin);
                        else
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByServicios_ResponsablesEntr(this.DataSetReportes.ORDENES_DE_TRABAJO, id_servicio, id_responsable, fecha_ini, fecha_fin, (entregado == CheckState.Checked));
                        break;
                    }

                case Reporte.Servicios_Areas:
                    {
                        if (entregado == CheckState.Indeterminate)
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByServicios_Areas(this.DataSetReportes.ORDENES_DE_TRABAJO, id_servicio, id_area, fecha_ini, fecha_fin);
                        else
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByServicios_AreasEntr(this.DataSetReportes.ORDENES_DE_TRABAJO, id_servicio, id_area, fecha_ini, fecha_fin, (entregado == CheckState.Checked));
                        break;
                    }

                case Reporte.Servicios_DobleFiltro:
                    {
                        if (entregado == CheckState.Indeterminate)
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByServicios_DobleFiltro(this.DataSetReportes.ORDENES_DE_TRABAJO, id_servicio, id_responsable, id_area, fecha_ini, fecha_fin);
                        else
                            this.ORDENES_DE_TRABAJOTableAdapter.FillByServicios_DobleFiltroEntr(this.DataSetReportes.ORDENES_DE_TRABAJO, id_servicio, id_responsable, id_area, fecha_ini, fecha_fin, (entregado == CheckState.Checked));
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
