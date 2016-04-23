using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoOT
{
    public partial class frmNuevoUsuario : Form
    {
        public frmNuevoUsuario()
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
            try
            {
                MailAddress ma = new MailAddress(txtEmail.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-mail no válido");
                return;
            }

            
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Introduzca nombre");
                return;
            }
            else if (txtDireccion.Text == "")
            {
                MessageBox.Show("Introduzca dirección");
                return;
            }
            else if (txtTelefono.Text == "")
            {
                MessageBox.Show("Introduzca teléfono.");
                return;
            }
            else if (cbEstado.Text == "")
            {
                MessageBox.Show("Especifique el estado de la cuenta.");
                return;
            }
            else if (txtContrasena.Text == txtConfContrasena.Text)
            {
                MessageBox.Show("Escriba y confirme la contraseña de la cuenta.");
                return;
            }
            else if (cbPermisos.Text == "")
            {
                MessageBox.Show("Especifique los permisos de la cuenta.");
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
    }
}
