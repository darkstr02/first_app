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
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
            this.sistemaOTDataSet.EnforceConstraints = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCargando f = new frmCargando();
            f.Show();
            Application.DoEvents();
            try
            {                         
                this.cUENTAS_DE_USUARIOTableAdapter.Fill(this.sistemaOTDataSet.CUENTAS_DE_USUARIO);
                f.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                f.Close();
                return;
            }

            if ((int) this.cUENTAS_DE_USUARIOTableAdapter.ExistsAccount(txtNombre.Text, txtContraseña.Text) == 1)
            {
                int permiso = (int) this.cUENTAS_DE_USUARIOTableAdapter.FetchPermiso(txtNombre.Text);
       
                CredencialUsuario.SubscribirCuenta(txtNombre.Text, (permiso == 1) ? "Administrador" : "Registrado", txtContraseña.Text);
                this.cUENTAS_DE_USUARIOTableAdapter.actualizarUltimoAcceso(DateTime.Now, txtNombre.Text);       

                MessageBox.Show("Bienvenido/a, " + txtNombre.Text + ": " + CredencialUsuario.Permiso);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Combinación errónea de nombre de usuario y contraseña. Por favor, inténtelo de nuevo.");
            }

        }


        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.CUENTAS_DE_USUARIO' Puede moverla o quitarla según sea necesario.
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmCambiarServidor frm = new frmCambiarServidor();
            frm.ShowDialog();
        }
    }
}
