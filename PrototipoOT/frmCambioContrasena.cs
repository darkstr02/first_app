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
    public partial class frmCambioContrasena : Form
    {
        public frmCambioContrasena()
        {
            InitializeComponent();
            //Actualiza las conexiones de los TableAdapters con la configuración escogida en el inicio de sesión;
            string connString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).ConnectionStrings.ConnectionStrings["PrototipoOT.Properties.Settings.SistemaOTConnectionString"].ConnectionString;
            this.cUENTAS_DE_USUARIOTableAdapter.Connection.ConnectionString = connString;
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
                MessageBox.Show("La contraseña se ha acutalizado con éxito.", "Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
                CredencialUsuario.Contrasena = txtContraNueva.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (txtConfContraNueva.Text != txtContraNueva.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, confirme correctamente la contraseña.", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Contraseña actual errónea. Favor de intentarlo de nuevo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
