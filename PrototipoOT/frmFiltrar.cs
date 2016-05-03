using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationControls;

namespace PrototipoOT
{
    public partial class frmFiltrar : Form
    {
        public frmFiltrar()
        {
            InitializeComponent();
        }

        private void frmFiltrar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.vw_nombreresponsables' Puede moverla o quitarla según sea necesario.
            this.vw_nombreresponsablesTableAdapter.Fill(this.sistemaOTDataSet.vw_nombreresponsables);

            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.AREAS' Puede moverla o quitarla según sea necesario.         
            this.aREASTableAdapter.FillBy(this.sistemaOTDataSet.AREAS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.SERVICIOS' Puede moverla o quitarla según sea necesario.
            this.sERVICIOSTableAdapter.FillBy(this.sistemaOTDataSet.SERVICIOS);
            //Llenar CheckBox ComboBoxes aquí!!

            foreach (DataRow dr in this.sistemaOTDataSet.SERVICIOS)
                cbServicio.Items.Add(new ComboBoxCheckBoxItem(dr, "descripcion", "id_servicio"));         

            foreach (DataRow dr in this.sistemaOTDataSet.AREAS)
                cbArea.Items.Add(new ComboBoxCheckBoxItem(dr, "descripcion", "id_area"));

            foreach (DataRow dr in this.sistemaOTDataSet.vw_nombreresponsables)
                cbResponsable.Items.Add(new ComboBoxCheckBoxItem(dr, "Responsable", "id_responsable"));

            //cbServicio.ValueMember = "id_servicio";
            //cbArea.ValueMember = "id_area";
            //cbResponsable.ValueMember = "id_responsable";
        }

        private void checkBoxComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dtpFechaInicio.Value.Date > dtpFechaFinal.Value.Date)
            {   
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha final.", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;

            List<string> serv = new List<string>();
            List<string> area = new List<string>();
            List<string> resp = new List<string>();

            foreach (CheckBoxComboBoxItem cbcbi in cbServicio.CheckBoxItems)
                if(cbcbi.Checked) serv.Add(cbcbi.Text);

            foreach (CheckBoxComboBoxItem cbcbi in cbArea.CheckBoxItems)
                if (cbcbi.Checked) area.Add(cbcbi.Text);

            foreach (CheckBoxComboBoxItem cbcbi in cbResponsable.CheckBoxItems)
                if (cbcbi.Checked) resp.Add(cbcbi.Text);

            Form1.filtroServicio = serv;
            Form1.filtroArea = area;
            Form1.filtroResponsable = resp;

            Form1.filtro_fechainicio = dtpFechaInicio.Value;
            Form1.filtro_fechafin = dtpFechaFinal.Value;

            Form1.chkstatus = chkEntregado.CheckState;

            this.Close();
        }



        private class ComboBoxCheckBoxItem
        {
            public DataRow element;
            public String DisplayObject;
            public String ValueObject;

            public ComboBoxCheckBoxItem(DataRow dr)
            {
                element = dr;
            }

            public ComboBoxCheckBoxItem(DataRow dr, String dspObject, String valObject)
            {
                element = dr;
                DisplayObject = dspObject;
                ValueObject = valObject;
            }

            public override String ToString()
            {
                if (DisplayObject == null) throw new Exception("DisplayObject property was not set.");

                return element[DisplayObject].ToString();
            }

            public override bool Equals(object obj)
            {
                if (obj.GetType() == typeof(ComboBoxCheckBoxItem))
                    return Equals(((ComboBoxCheckBoxItem)obj).element, this.element);
                else return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
         

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}


