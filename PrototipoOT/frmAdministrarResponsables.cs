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
    public partial class frmAdministrarResponsables : Form
    {
        public frmAdministrarResponsables()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevoResponsable frm = new frmNuevoResponsable("Nuevo");
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNuevoResponsable frm = new frmNuevoResponsable("Modificar");
            frm.ShowDialog();
        }

        private void frmAdministrarResponsables_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.vw_responsables' Puede moverla o quitarla según sea necesario.
            this.vw_responsablesTableAdapter.Fill(this.sistemaOTDataSet.vw_responsables);

        }
    }
}
