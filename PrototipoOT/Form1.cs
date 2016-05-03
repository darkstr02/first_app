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
        public static List<string> filtroServicio;
        public static List<string> filtroArea;
        public static List<string> filtroResponsable;
        public static DateTime filtro_fechainicio;
        public static DateTime filtro_fechafin;
        public static CheckState chkstatus;

        public static string findConsecutive;
        public static int dtgIndex;


        public Form1()
        {
            InitializeComponent();
            this.sistemaOTDataSet.EnforceConstraints = false;
        }

        private string filtroString()
        {

            int paramIndx = 0;
            List<string>[] coleccion = { filtroServicio, filtroArea, filtroResponsable };
            List<string> cadenas = new List<string>();
            string[] parametros = { "Servicio", "Área", "Responsable" };
            string resultado = "";

            if (filtro_fechainicio < filtro_fechafin)
                cadenas.Add("(Fecha_Inicio >= #" + filtro_fechainicio.ToString("yyyy-MM-dd") + "# AND Fecha_Inicio <= #" + filtro_fechafin.ToString("yyyy-MM-dd") + "#)");

            if (chkstatus != CheckState.Indeterminate)
                cadenas.Add( "entregado = " + ((chkstatus == CheckState.Checked) ? "TRUE " : "FALSE "));
            

            foreach (List<string> list in coleccion)
            {   
                string cadena = "";
                if (list.Count != 0)
                {
                    cadena += (list.Count > 1) ? "(" : "";
                    for (int x = 0; x < list.Count; x++)
                    {
                        cadena += parametros[paramIndx]+ " = '" + list[x] + "'";
                        cadena += (x != list.Count - 1) ? " OR " : ((list.Count > 1) ? ")" : "");
                    }
                    cadenas.Add(cadena);
                }

                paramIndx++;
            }


            if (cadenas.Count != 0)
            {
                string last = cadenas[cadenas.Count - 1];
                foreach (string str in cadenas)
                {
                    resultado += str;
                    if (str != last)
                        resultado += " AND ";
                }
                return resultado;
            }

            return null;
        }

        private void órdenesDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //NUEVA ORDEN TOOL STRIP
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmOrdenTrabajo frm = new frmOrdenTrabajo("Nueva");
            //if (frm.ShowDialog() == DialogResult.OK || frm.ShowDialog() == DialogResult.Cancel)
            frm.ShowDialog();
                this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes);
        }

        //NUEVA ORDEN MENU STRIP
        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenTrabajo frm = new frmOrdenTrabajo("Nueva");
            if (frm.ShowDialog() == DialogResult.OK)
                this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes);
        }

        //MODIFICAR ORDEN TOOL STRIP
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow indexDataRow = ((DataRowView)dataGridView1.SelectedCells[0].OwningRow.DataBoundItem).Row;
                int index = Int32.Parse(indexDataRow["ID"].ToString());

                frmOrdenTrabajo frm = new frmOrdenTrabajo("Modificar", index);
                if (frm.ShowDialog() == DialogResult.OK)
                    this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes);
            }
            catch (Exception ex)
            {
                    MessageBox.Show("No existen registros de ordenes de trabajo");
            }
        }

        //MODIFICAR ORDEN MENU STRIP
        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow indexDataRow = ((DataRowView)dataGridView1.SelectedCells[0].OwningRow.DataBoundItem).Row;
                int index = Int32.Parse(indexDataRow["ID"].ToString());

                frmOrdenTrabajo frm = new frmOrdenTrabajo("Modificar", index);
                if (frm.ShowDialog() == DialogResult.OK)
                    this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes);
            }
            catch (Exception ex)
            {
                 MessageBox.Show("No existen registros de ordenes de trabajo");
            }
            
        }

        //REPORTES TOOL STRIP
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes();
            frm.ShowDialog();
        }

        //REPORTES MENU STRIP
        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes();
            frm.ShowDialog();
        }


        //BUSCAR TOOL STRIP
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmBuscar frm = new frmBuscar();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // 0 is the column index
                    if (row.Cells[1].Value.ToString().Equals(findConsecutive))
                    {
                        row.Selected = true;
                        dtgIndex = row.Index;
                        return;
                    }
                }
                
                if(dtgIndex != -1)
                    dataGridView1.Rows[dtgIndex].Selected = false;
                MessageBox.Show("El registro no existe");
                dtgIndex = -1;
            }
               

        }

        //BUSCAR MENU STRIP
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscar frm = new frmBuscar();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // 0 is the column index
                    if (row.Cells[1].Value.ToString().Equals(findConsecutive))
                    {
                        row.Selected = true;
                        dtgIndex = row.Index;
                        return;
                    }
                }

                if (dtgIndex != -1)
                    dataGridView1.Rows[dtgIndex].Selected = false;
                MessageBox.Show("El registro no existe");
                dtgIndex = -1;
            }
        }

        //FILTRAR TOOL STRIP
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmFiltrar frm = new frmFiltrar();

            if (frm.ShowDialog() == DialogResult.OK)
            {
               // if (filtroServicio.Count != 0 || filtroArea.Count != 0 || filtroResponsable.Count != 0 || chkstatus != CheckState.Indeterminate)
                    this.vwordenesBindingSource.Filter = filtroString();
                    //else
                    //    this.vwordenesBindingSource.Filter = "";

                this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes);
            }
        }

        //FILTRAR MENU STRIP
        private void filtrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltrar frm = new frmFiltrar();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                //if (filtroServicio.Count != 0 || filtroArea.Count != 0 || filtroResponsable.Count != 0 || chkstatus != CheckState.Indeterminate)
                    this.vwordenesBindingSource.Filter = filtroString();
                //else
                //    this.vwordenesBindingSource.Filter = "";
                    
                this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes);         
            }
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
            frmNuevoResponsable frm = new frmNuevoResponsable();
            if(frm.ShowDialog() == DialogResult.OK)
                this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes); 
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmInicioSesion frm = new frmInicioSesion();
            
            if (frm.ShowDialog() != DialogResult.OK)
            {
                this.Close();
                return;
            }

            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.vw_ordenes' Puede moverla o quitarla según sea necesario.
            this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes);
            this.oRDENES_DE_TRABAJOTableAdapter.Fill(this.sistemaOTDataSet.ORDENES_DE_TRABAJO);

            lbConectado.Text = CredencialUsuario.Nombre;
            lbPermisos.Text = CredencialUsuario.Permiso;

            if (CredencialUsuario.Permiso != "Administrador")
            {
                administrarUsuariosToolStripMenuItem.Enabled = false;
                administrarResponsablesToolStripMenuItem.Enabled = false;
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //DataRow indexDataRow = ((DataRowView)dataGridView1.SelectedCells[0].OwningRow.DataBoundItem).Row;
            //int index = Int32.Parse(indexDataRow["ID"].ToString());

            //frmOrdenTrabajo frm = new frmOrdenTrabajo("Modificar", index);
            //if (frm.ShowDialog() == DialogResult.OK)
            //    this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes);

            try
            {
                DataRow indexDataRow = ((DataRowView)dataGridView1.SelectedCells[0].OwningRow.DataBoundItem).Row;
                int index = Int32.Parse(indexDataRow["ID"].ToString());

                frmOrdenTrabajo frm = new frmOrdenTrabajo("Modificar", index);
                if (frm.ShowDialog() == DialogResult.OK)
                    this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes);
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146232022)
                    MessageBox.Show("Consecutivo ya existe");
                else
                    MessageBox.Show("No existen registros de ordenes de trabajo");
            }
        }

        //BORRAR ORDEN TOOL STRIP
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DataRow selectedRow = null;
            try
            {
                DataRow indexDataRow = ((DataRowView)dataGridView1.SelectedCells[0].OwningRow.DataBoundItem).Row;
                int index = Int32.Parse(indexDataRow["ID"].ToString());
                

                this.oRDENES_DE_TRABAJOTableAdapter.Fill(sistemaOTDataSet.ORDENES_DE_TRABAJO);

                foreach (DataRow dr in sistemaOTDataSet.ORDENES_DE_TRABAJO)
                {
                    if ((int)dr[0] == (int)index)
                    {
                        selectedRow = dr;
                        break;
                    }
                }

                if (MessageBox.Show("¿Está seguro que desea borrar este registro?","Confirmación de Borrado",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    selectedRow.Delete();

                    this.oRDENES_DE_TRABAJOTableAdapter.Update(this.sistemaOTDataSet.ORDENES_DE_TRABAJO);
                    this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ha seleccionado un registro o no existen registros de Órdenes de Trabajo.");
            }
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //BORRAR ORDEN MENU STRIP
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow selectedRow = null;
            try
            {
                DataRow indexDataRow = ((DataRowView)dataGridView1.SelectedCells[0].OwningRow.DataBoundItem).Row;
                int index = Int32.Parse(indexDataRow["ID"].ToString());


                this.oRDENES_DE_TRABAJOTableAdapter.Fill(sistemaOTDataSet.ORDENES_DE_TRABAJO);

                foreach (DataRow dr in sistemaOTDataSet.ORDENES_DE_TRABAJO)
                {
                    if ((int)dr[0] == (int)index)
                    {
                        selectedRow = dr;
                        break;
                    }
                }

                if (MessageBox.Show("¿Está seguro que desea borrar este registro?", "Confirmación de Borrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    selectedRow.Delete();

                    this.oRDENES_DE_TRABAJOTableAdapter.Update(this.sistemaOTDataSet.ORDENES_DE_TRABAJO);
                    this.vw_ordenesTableAdapter.Fill(this.sistemaOTDataSet.vw_ordenes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ha seleccionado un registro o no existen registros de Órdenes de Trabajo.");
            }
        }
    }
}
