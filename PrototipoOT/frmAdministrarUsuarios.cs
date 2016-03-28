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
    public partial class frmAdministrarUsuarios : Form
    {
        public frmAdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario frm = new frmNuevoUsuario();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmModificarUsuariocs frm = new frmModificarUsuariocs();
            frm.ShowDialog();
        }

        private void frmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.vw_cuentas' Puede moverla o quitarla según sea necesario.
            this.vw_cuentasTableAdapter.Fill(this.sistemaOTDataSet.vw_cuentas);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.CUENTAS_DE_USUARIO' Puede moverla o quitarla según sea necesario.
            this.cUENTAS_DE_USUARIOTableAdapter.Fill(this.sistemaOTDataSet.CUENTAS_DE_USUARIO);

        }
    }
}
