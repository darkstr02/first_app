using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoOT
{
    public partial class frmAdministrarUsuarios : Form
    {

        bool editing;

        public frmAdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.CAT_CUENTAS' Puede moverla o quitarla según sea necesario.
            this.cAT_CUENTASTableAdapter.Fill(this.sistemaOTDataSet.CAT_CUENTAS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.ESTADOS' Puede moverla o quitarla según sea necesario.
            this.eSTADOSTableAdapter.Fill(this.sistemaOTDataSet.ESTADOS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.CUENTAS_DE_USUARIO' Puede moverla o quitarla según sea necesario.
            this.cUENTAS_DE_USUARIOTableAdapter.Fill(this.sistemaOTDataSet.CUENTAS_DE_USUARIO);

            editing = false;

        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string errorMsg = String.Empty;

            if (this.cUENTAS_DE_USUARIOTableAdapter.ExistsAccountName(txtNombre.Text.Trim()) == 1 && editing == true)
            {
                errorMsg = "El nombre de usuario ya existe, favor de elegir otro.";
            }
            else if(cbEstado.Text == "BAJA" && txtNombre.Text.Trim() == CredencialUsuario.Nombre)
            {
                errorMsg = "Error: No puede dar de baja su propia cuenta mientras está en sesión.";
            }
            else if (txtContrasena.Text != txtConfContrasena.Text || (txtConfContrasena.Text == String.Empty && txtContrasena.Text == String.Empty))
            {
                errorMsg = "Escriba y confirme la contraseña de la cuenta.";
            }
            else if (txtNombre.Text == "")
            {
                errorMsg = "Introduzca nombre";
            }
            else if (txtEmail.Text == "")
            {
                errorMsg = "Introduzca teléfono";
            }
            else if (!validateEmail(txtEmail.Text, out errorMsg))
            {
                errorMsg = "E-mail inválido";
            }
            else if (txtTelefono.Text == "")
            {
                errorMsg = "Introduzca teléfono";
            }
            else if (!validateTelephone(txtTelefono.Text, out errorMsg))
            {
                errorMsg = "Teléfono inválido";
            }
            else if (txtDireccion.Text == "")
            {
                errorMsg = "Introduzca dirección";
            }
            else if (cbEstado.Text == "")
            {
                errorMsg = "Especifique el estado de la cuenta";
            }
            else if (cbPermisos.Text == "")
            {
                errorMsg = "Especifique los permisos de la cuenta";
            }

            if (errorMsg != String.Empty)
            {
                MessageBox.Show(errorMsg);
                return;
            }
                     
            this.bindingSource1.EndEdit();
            this.sistemaOTDataSet.AcceptChanges();
            this.cUENTAS_DE_USUARIOTableAdapter.Update(this.sistemaOTDataSet.CUENTAS_DE_USUARIO);
            
            txtNombre.Focus();
            if (!bindingNavigatorMovePreviousItem.Enabled && editing)
                bindingNavigatorMovePreviousItem.Enabled = true;
            if (!bindingNavigatorMoveFirstItem.Enabled && editing)
                bindingNavigatorMoveFirstItem.Enabled = true;
            dataGridView1.Enabled = true;
            

            MessageBox.Show("Registro actualizado con éxito.");
            editing = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close(); 
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

        private bool validateEmail(string str, out string err)
        {
            try
            {
                MailAddress ma = new MailAddress(txtEmail.Text);
                err = "";
                return true;
            }
            catch (Exception ex)
            {
                err = "E-mail inválido.";
                return false;
            }
        }

        private bool validateTelephone(string str, out string err)
        {
            long result = 0;
            //bool value = Regex.Match(str, @"^(\+[0-9]{9})$").Success;
            bool value = Int64.TryParse(str, out result);
            err = (value) ? "" : "Teléfono inválido.";
            return value;

        }

        private void frmAdministrarUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            dataGridView1.Enabled = false;
            txtConfContrasena.Clear();
            editing = true;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            txtConfContrasena.Clear();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            txtConfContrasena.Clear();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            txtConfContrasena.Clear();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            txtConfContrasena.Clear();
        }




    }
}
