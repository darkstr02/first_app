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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();

            string connString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).ConnectionStrings.ConnectionStrings["PrototipoOT.Properties.Settings.SistemaOTConnectionString"].ConnectionString;

            this.rESPONSABLESTableAdapter.Connection.ConnectionString = connString;
            this.aREASTableAdapter.Connection.ConnectionString = connString;
            this.sERVICIOSTableAdapter.Connection.ConnectionString = connString;
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.RESPONSABLES' Puede moverla o quitarla según sea necesario.
            this.rESPONSABLESTableAdapter.Fill(this.sistemaOTDataSet.RESPONSABLES);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.AREAS' Puede moverla o quitarla según sea necesario.
            this.aREASTableAdapter.Fill(this.sistemaOTDataSet.AREAS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.SERVICIOS' Puede moverla o quitarla según sea necesario.
            this.sERVICIOSTableAdapter.Fill(this.sistemaOTDataSet.SERVICIOS);
        }


        private void cmdBuscarConsecutivo_Click(object sender, EventArgs e)
        {
            Form1.findConsecutive = txtConsecutivo.Text.ToUpper();
            this.DialogResult = DialogResult.OK;
        }
    }
}
