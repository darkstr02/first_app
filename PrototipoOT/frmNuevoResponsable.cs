using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PrototipoOT
{
    public partial class frmNuevoResponsable : Form
    {
        bool editing;

        public frmNuevoResponsable()
        {
            InitializeComponent();
            string connString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).ConnectionStrings.ConnectionStrings["PrototipoOT.Properties.Settings.SistemaOTConnectionString"].ConnectionString;

            this.eSTADOSTableAdapter.Connection.ConnectionString = connString;
            this.rESPONSABLESTableAdapter.Connection.ConnectionString = connString;

        }

        private void frmNuevoResponsable_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.ESTADOS' Puede moverla o quitarla según sea necesario.
            this.eSTADOSTableAdapter.Fill(this.sistemaOTDataSet.ESTADOS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.RESPONSABLES' Puede moverla o quitarla según sea necesario.
            this.rESPONSABLESTableAdapter.FillBy(this.sistemaOTDataSet.RESPONSABLES);

            editing = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Validate();
            this.bindingSource1.CancelEdit();
            this.rESPONSABLESTableAdapter.Update(this.sistemaOTDataSet.RESPONSABLES);
            this.Close();
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (editing == false && dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Haga clic en el botón 'añadir datos' antes de capturar el responsable", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.Validate();

            string errorMsg = String.Empty;

            if (txtApPaterno.Text == "")
            {
                errorMsg = "Introduzca apellido paterno";
            }
            else if (txtApMaterno.Text == "")
            {
                errorMsg = "Introduzca apellido materno";
            }
            else if (txtNombre.Text == "")
            {
                errorMsg = "Introduzca nombre";
            }
            else if (txtDireccion.Text == "")
            {
                errorMsg = "Introduzca dirección";
            }
            else if (txtTelefono.Text == "")
            {
                errorMsg = "Introduzca teléfono";
            }
            else if (!validateTelephone(txtTelefono.Text, out errorMsg))
            {
                errorMsg = "Teléfono inválido";
            }
            else if (cbEstado.Text == "")
            {
                errorMsg = "Especifique el estado de la cuenta";
            }

            if (errorMsg != String.Empty)
            {
                MessageBox.Show(errorMsg, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
      

            this.bindingSource1.EndEdit();
            this.rESPONSABLESTableAdapter.Update(this.sistemaOTDataSet.RESPONSABLES);

            txtNombre.Focus();
            if (!bindingNavigatorMovePreviousItem.Enabled && editing)
                bindingNavigatorMovePreviousItem.Enabled = true;
            if (!bindingNavigatorMoveFirstItem.Enabled && editing)
                bindingNavigatorMoveFirstItem.Enabled = true;
            dataGridView1.Enabled = true;

            MessageBox.Show("Registro(s) actualizado con éxito.");
            editing = false;
        }

        private bool validateTelephone(string str, out string err)
        {
            long result = 0;
            bool value = Int64.TryParse(str, out result);
            err = (value) ? "" : "Teléfono inválido.";
            return value;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            dataGridView1.Enabled = false;
            editing = true;
        }
    }
}
