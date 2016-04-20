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
    public partial class frmNuevoResponsable : Form
    {
        string titulo;

        public frmNuevoResponsable()
        {
            InitializeComponent();
        }

        private void frmNuevoResponsable_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.ESTADOS' Puede moverla o quitarla según sea necesario.
            this.eSTADOSTableAdapter.Fill(this.sistemaOTDataSet.ESTADOS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.RESPONSABLES' Puede moverla o quitarla según sea necesario.
            this.rESPONSABLESTableAdapter.Fill(this.sistemaOTDataSet.RESPONSABLES);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.ESTADOS' Puede moverla o quitarla según sea necesario.
            //this.eSTADOSTableAdapter.Fill(this.sistemaOTDataSet.ESTADOS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.RESPONSABLES' Puede moverla o quitarla según sea necesario.
            this.rESPONSABLESTableAdapter.FillBy(this.sistemaOTDataSet.RESPONSABLES);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.vw_responsables' Puede moverla o quitarla según sea necesario.
            //this.vw_responsablesTableAdapter.Fill(this.sistemaOTDataSet.vw_responsables);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.RESPONSABLES' Puede moverla o quitarla según sea necesario.
            //this.rESPONSABLESTableAdapter.Fill(this.sistemaOTDataSet.RESPONSABLES);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Validate();
            this.bindingSource1.EndEdit();
            this.rESPONSABLESTableAdapter.Update(this.sistemaOTDataSet.RESPONSABLES);
            this.Close();
        }


        public int insertarResponsable()
        {

            return 0;
        }

        public int modificarResponsable()
        {

            return 0;
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource1.EndEdit();
            this.rESPONSABLESTableAdapter.Update(this.sistemaOTDataSet.RESPONSABLES);
        }
    }
}
