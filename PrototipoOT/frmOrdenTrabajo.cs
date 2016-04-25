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
        string titulo;
        DataRow modifyRow;
        int indice;

        public frmOrdenTrabajo(String title, int idx = 0)
        {
            InitializeComponent();
            this.Text = title + " Órden de Trabajo";
            titulo = title;
            indice = idx;
            
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
            this.aREASTableAdapter.FillBy(this.sistemaOTDataSet1.AREAS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.SERVICIOS' Puede moverla o quitarla según sea necesario.
            this.sERVICIOSTableAdapter.FillBy(this.sistemaOTDataSet.SERVICIOS);

            //Si el formulación está en modo "Modificación"
            if (indice != 0)
            {
                modifyRow = this.sistemaOTDataSet.ORDENES_DE_TRABAJO.Select("id_orden =" + indice)[0];

                //Llenar controles con datos de la columna seleccionada;
                dtpFecha.Value = (DateTime)modifyRow["fecha_inicio"];
                txtConsecutivo.Text = (string)modifyRow["consecutivo"];
                txtSolicitante.Text = (string)modifyRow["solicitante"];

                //NOTA: Crear una función estática para hacer esta operación <<<<<<<<<<<<<>>>>>>>>>>>>>>
                foreach (DataRowView drv in cbServicio.Items)
                {
                    if ((int) drv.Row[0] == (int) modifyRow["id_servicio"])
                    {
                        cbServicio.SelectedItem = drv;
                        break;
                    }
                }

                foreach (DataRowView drv in cbArea.Items)
                {
                    if ((int)drv.Row[0] == (int)modifyRow["id_area"])
                    {
                        cbArea.SelectedItem = drv;
                        break;
                    }
                }

                if ((string) modifyRow["id_responsable"].ToString() == "")
                {
                    cbResponsable.SelectedItem = null;
                }
                else
                {

                    foreach (DataRowView drv in cbResponsable.Items)
                    {
                        if ((int)drv.Row[0] == (int)modifyRow["id_responsable"])
                        {
                            cbResponsable.SelectedItem = drv;
                            break;
                        }
                    }
                }

                rbEntregadoSi.Checked = (bool)modifyRow["entregado"];
                txtDescripcion.Text = (string)modifyRow["descripcion"];
                if (modifyRow["observaciones"] != DBNull.Value)
                    txtObservaciones.Text = (string)modifyRow["observaciones"];
            }
            else
            {

                //Borrar Selección Default del ComboBox Responsables
                cbResponsable.SelectedItem = null;


            }
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
            int returnValue;

            if (this.ValidateChildren())
            {
                if (rbEntregadoSi.Checked && cbResponsable.SelectedItem == null)
                {
                    MessageBox.Show("Esta Orden de Trabajo no puede marcarse como entregada sin asignar un responsable");
                    return;
                }
                
                if (titulo.Equals("Nueva")) returnValue = insertarOrden();
                else returnValue = modificarOrden();

                if (returnValue != 0) return;
                else MessageBox.Show("Operación realizada con éxito!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan uno o más campor por llenar.");
                return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int insertarOrden()
        {
            DataRow nuevo = this.sistemaOTDataSet.ORDENES_DE_TRABAJO.NewRow();

            nuevo["consecutivo"] = txtConsecutivo.Text.ToUpper();
            nuevo["solicitante"] = txtSolicitante.Text;

            DataRowView serv = (DataRowView)cbServicio.SelectedItem;
            DataRowView area = (DataRowView)cbArea.SelectedItem;
            DataRowView resp = (DataRowView)cbResponsable.SelectedItem;

            nuevo["id_servicio"] = serv.Row[0];
            nuevo["id_area"] = area.Row[0];
            nuevo["id_responsable"] = (resp != null) ? resp.Row[0] : DBNull.Value;

            nuevo["entregado"] = rbEntregadoSi.Checked;
            nuevo["descripcion"] = txtDescripcion.Text;
            nuevo["observaciones"] = txtObservaciones.Text;
            nuevo["fecha_inicio"] = dtpFecha.Value;

            if (rbEntregadoSi.Checked)
                nuevo["fecha_entregado"] = DateTime.Now;
            else
                nuevo["fecha_entregado"] = System.DBNull.Value;

            try
            {
                this.sistemaOTDataSet.ORDENES_DE_TRABAJO.Rows.Add(nuevo);
                this.oRDENES_DE_TRABAJOTableAdapter.Update(this.sistemaOTDataSet.ORDENES_DE_TRABAJO);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Consecutivo ya existe!");
                return -1;
            }
        }

        private int modificarOrden()
        {
            modifyRow["consecutivo"] = txtConsecutivo.Text.ToUpper();
            modifyRow["solicitante"] = txtSolicitante.Text;

            DataRowView serv = (DataRowView)cbServicio.SelectedItem;
            DataRowView area = (DataRowView)cbArea.SelectedItem;
            DataRowView resp = (DataRowView)cbResponsable.SelectedItem;

            modifyRow["id_servicio"] = serv.Row[0];
            modifyRow["id_area"] = area.Row[0];
            modifyRow["id_responsable"] = (resp != null) ? resp.Row[0] : DBNull.Value;

            modifyRow["entregado"] = rbEntregadoSi.Checked;
            modifyRow["descripcion"] = txtDescripcion.Text;
            modifyRow["observaciones"] = txtObservaciones.Text;
            modifyRow["fecha_inicio"] = dtpFecha.Value;

            if (rbEntregadoSi.Checked)
            {
                if (modifyRow["fecha_entregado"] == System.DBNull.Value)
                    modifyRow["fecha_entregado"] = DateTime.Now;
            }
            else
                modifyRow["fecha_entregado"] = System.DBNull.Value;


            this.oRDENES_DE_TRABAJOTableAdapter.Update(this.sistemaOTDataSet.ORDENES_DE_TRABAJO);
            return 0;
            

        }



        //VALIDACIONES

        //Evento Validating para el Campo "Fecha de Inicio";
        private void dtpFecha_Validating(object sender, CancelEventArgs e)
        {

            if (dtpFecha.Value > DateTime.Now)
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                dtpFecha.Select();

                // Set the ErrorProvider error with the text to display. 
                ErrorProviderExtensions.SetErrorWithCount(errorProvider1, dtpFecha, "No se puede establecer una fecha en el futuro como fecha de inicio");
                //this.errorProvider1.SetError(dtpFecha, "No se puede establecer una fecha en el futuro como fecha de inicio");
            }
        }

        //Evento Validating para TODOS los TextBoxs
        private void Control_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            Control txtBox = (Control)sender;
   
            if (!validateString(txtBox.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                dtpFecha.Select();

                // Set the ErrorProvider error with the text to display. 
                ErrorProviderExtensions.SetErrorWithCount(errorProvider1, txtBox, errorMsg);
            }
        }


        private void Control_Validated(object sender, EventArgs e)
        {
            Control ctr = (Control) sender;
            // If all conditions have been met, clear the ErrorProvider of errors.

            ErrorProviderExtensions.SetErrorWithCount(errorProvider1, (Control) sender, "");
        }


        private bool validateString(string str, out string err)
        {
            if (str.Length != 0)
            {
                err = "";
                return true;
            }
            else
            {
                err = "El campo está vacío";
                return false;
            }           
        }



        private void frmOrdenTrabajo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

  


    }
}
