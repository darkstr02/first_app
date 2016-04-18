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
    public partial class frmNuevoResponsable : Form
    {
        string titulo;

        public frmNuevoResponsable(String title)
        {
            InitializeComponent();
            titulo = title;
            this.Text = title + " Responsable...";
        }

        private void frmNuevoResponsable_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.RESPONSABLES' Puede moverla o quitarla según sea necesario.
            this.rESPONSABLESTableAdapter.FillBy(this.sistemaOTDataSet.RESPONSABLES);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.vw_responsables' Puede moverla o quitarla según sea necesario.
            //this.vw_responsablesTableAdapter.Fill(this.sistemaOTDataSet.vw_responsables);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.RESPONSABLES' Puede moverla o quitarla según sea necesario.
            //this.rESPONSABLESTableAdapter.Fill(this.sistemaOTDataSet.RESPONSABLES);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int returnValue;

            if (titulo.Equals("Nueva")) returnValue = insertarResponsable();
            else returnValue = modificarResponsable();

            if (returnValue != 0) return;

            this.DialogResult = DialogResult.OK;
            this.Close();

            //Validaciones (A agrupar en una clase aparte)
            //if (rbEntregadoSi.Checked && cbResponsable.SelectedItem == null)
            //{
            //    MessageBox.Show("Esta Orden de Trabajo no puede marcarse como entregada sin asignar un responsable");
            //    return;
            //}
            //else if (dtpFecha.Value > DateTime.Now)
            //{
            //    MessageBox.Show("No puede establecer una fecha a futuro como fecha de inicio!");
            //    return;
            //}
            //else if (txtConsecutivo.Text.Trim() == String.Empty)
            //{
            //    MessageBox.Show("Introduzca un consecutivo!");
            //    txtConsecutivo.Text = "";
            //    return;
            //}
            //else if (txtSolicitante.Text.Trim() == String.Empty)
            //{
            //    MessageBox.Show("Introduzca un solicitante!");
            //    txtConsecutivo.Text = "";
            //    return;
            //}
            //else if (txtDescripcion.Text.Trim() == String.Empty)
            //{
            //    MessageBox.Show("Introduzca una descripción!");
            //    txtConsecutivo.Text = "";
            //    return;
            //}


            //if (titulo.Equals("Nueva")) returnValue = insertarOrden();
            //else returnValue = modificarOrden();

            //if (returnValue != 0) return;

            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }


        public int insertarResponsable()
        {

            return 0;
        }

        public int modificarResponsable()
        {

            return 0;
        }

        private void vw_responsablesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void rESPONSABLESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rESPONSABLESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaOTDataSet);

        }

        private void id_estadoTextBox_TextChanged(object sender, EventArgs e)
        {

            if (id_estadoTextBox.Text == "" || id_estadoTextBox.Text == "ALTA" || id_estadoTextBox.Text == "BAJA")
                return;
            else if(id_estadoTextBox.Text == "1")
                id_estadoTextBox.Text = "ALTA";
            else
                id_estadoTextBox.Text = "BAJA";
        }
    }
}
