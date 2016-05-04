using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoOT.SistemaOTDataSetTableAdapters;

namespace PrototipoOT
{
    public partial class frmInicioSesion : Form
    {
        private TableAdapterManager tableAdapterManager;

        public frmInicioSesion()
        {
            InitializeComponent();

            tableAdapterManager = new TableAdapterManager();
            tableAdapterManager.CUENTAS_DE_USUARIOTableAdapter = this.cUENTAS_DE_USUARIOTableAdapter;

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
                //if (ex.HResult == -2146232060)
               //     MessageBox.Show("La base de datos seleccionada es inválida. Por favor, seleccione la base de datos correcta en la ventana 'Cambiar Servidor...'.");
                //else
                if(ex.Message == "Invalid object name 'dbo.CUENTAS_DE_USUARIO'.")
                    MessageBox.Show("La base de datos seleccionada es inválida. Por favor, seleccione la base de datos correcta en la ventana 'Cambiar Servidor...'.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                f.Close();
                
                return;
            }

            if ((int) this.cUENTAS_DE_USUARIOTableAdapter.ExistsAccount(txtNombre.Text, txtContraseña.Text) == 1)
            {
                int permiso = (int) this.cUENTAS_DE_USUARIOTableAdapter.FetchPermiso(txtNombre.Text);
       
                CredencialUsuario.SubscribirCuenta(txtNombre.Text, (permiso == 1) ? "Administrador" : "Registrado", txtContraseña.Text);
                this.cUENTAS_DE_USUARIOTableAdapter.actualizarUltimoAcceso(DateTime.Now, txtNombre.Text);
                


                MessageBox.Show("Bienvenido/a, " + txtNombre.Text + ": " + CredencialUsuario.Permiso,"Información",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Combinación errónea de nombre de usuario y contraseña. Por favor, inténtelo de nuevo.", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }


        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.CUENTAS_DE_USUARIO' Puede moverla o quitarla según sea necesario.
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmCambiarServidor frm = new frmCambiarServidor();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string connString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).ConnectionStrings.ConnectionStrings["PrototipoOT.Properties.Settings.SistemaOTConnectionString"].ConnectionString;
                this.tableAdapterManager.Connection.ConnectionString = connString;
            }
        }
    }
}
