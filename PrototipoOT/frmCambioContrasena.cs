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
    public partial class frmCambioContrasena : Form
    {
        public frmCambioContrasena()
        {
            InitializeComponent();
        }

        private void frmCambioContrasena_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.CUENTAS_DE_USUARIO' Puede moverla o quitarla según sea necesario.
            this.cUENTAS_DE_USUARIOTableAdapter.Fill(this.sistemaOTDataSet.CUENTAS_DE_USUARIO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtConfContraNueva.Text == txtContraNueva.Text && txtContraActual.Text == CredencialUsuario.Contrasena)
            {
                this.cUENTAS_DE_USUARIOTableAdapter.actualizarContrasena(txtContraNueva.Text, CredencialUsuario.Nombre);
                MessageBox.Show("La contraseña se ha acutalizado con éxito.");
                CredencialUsuario.Contrasena = txtContraNueva.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (txtConfContraNueva.Text != txtContraNueva.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, confirme correctamente la contraseña");
            }
            else
            {
                MessageBox.Show("Contraseña actual errónea. Favor de intentarlo de nuevo.");
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
