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

        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text != txtConfContrasena.Text)
            {
                MessageBox.Show("Escriba y confirme la contraseña de la cuenta.");
                return;
            }

            this.Validate();
            this.bindingSource1.EndEdit();
            this.cUENTAS_DE_USUARIOTableAdapter.Update(this.sistemaOTDataSet.CUENTAS_DE_USUARIO);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }



        //VALIDACIONES

        private void Control_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            Control txtBox = (Control)sender;

            if (!validateString(txtBox.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtBox.Select();

                //Validate by type of control

                // Set the ErrorProvider error with the text to display. 
                ErrorProviderExtensions.SetErrorWithCount(errorProvider1, txtBox, errorMsg);
            }
            else 
            {
                if (txtBox.Name == "txtEmail")
                {
                    txtBox.Select();
                    if(!validateEmail(txtBox.Text,out errorMsg))
                        ErrorProviderExtensions.SetErrorWithCount(errorProvider1, txtBox, errorMsg);
                }
                else if (txtBox.Name == "txtTelefono")
                {
                    txtBox.Select();
                    if (!validateTelephone(txtBox.Text, out errorMsg))
                        ErrorProviderExtensions.SetErrorWithCount(errorProvider1, txtBox, errorMsg);
                }

            }
        }


        private void Control_Validated(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            // If all conditions have been met, clear the ErrorProvider of errors.

            ErrorProviderExtensions.SetErrorWithCount(errorProvider1, (Control)sender, "");
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
            bool value = Regex.Match(str, @"^(\+[0-9]{9})$").Success;
            err = (value) ? "" : "Teléfono inválido.";
            return value;

        }

        private void frmAdministrarUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
