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
    public partial class frmItems : Form
    {

        BaseDeDatos bd;
        public frmItems()
        {
            InitializeComponent();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.AREAS' Puede moverla o quitarla según sea necesario.
            this.aREASTableAdapter.Fill(this.sistemaOTDataSet.AREAS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.SERVICIOS' Puede moverla o quitarla según sea necesario.
            this.sERVICIOSTableAdapter.Fill(this.sistemaOTDataSet.SERVICIOS);
            bd = new BaseDeDatos();
        }

        private void cmdAñadirServicio_Click(object sender, EventArgs e)
        {
            string[] param = new string[1];
            param[0] = txtServicio.Text;

            bd.insertData("SERVICIOS",param);
        }


    }
}
