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
            this.bindingSource1.CancelEdit();
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

            //Validación;
            if (txtApPaterno.Text == "")
            {
                MessageBox.Show("Introduzca apellido paterno");
                return;
            }
            else if (txtApMaterno.Text == "")
            {
                MessageBox.Show("Introduzca apellido materno");
                return;
            }
            else if (txtNombre.Text == "")
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
                MessageBox.Show("Introduzca teléfono");
                return;
            }
            else if (cbEstado.Text == "")
            {
                MessageBox.Show("Especifique el estado del responsable");
                return;
            }
            
           

            this.bindingSource1.EndEdit();
            this.rESPONSABLESTableAdapter.Update(this.sistemaOTDataSet.RESPONSABLES);
        }
    }
}
