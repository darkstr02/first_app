﻿using System;
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
            this.aREASTableAdapter.FillBy(this.sistemaOTDataSet.AREAS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.SERVICIOS' Puede moverla o quitarla según sea necesario.
            this.sERVICIOSTableAdapter.FillBy(this.sistemaOTDataSet.SERVICIOS);
            bd = new BaseDeDatos();
        }

        private void cmdAñadirServicio_Click(object sender, EventArgs e)
        {
            if (txtServicio.Text == String.Empty)
            {
                MessageBox.Show("Introduzca un nuevo servicio en el campo correspondiente.");
                return;
            }

            string[] param = new string[1];
            param[0] = txtServicio.Text;

            DataRow nuevo = this.sistemaOTDataSet.SERVICIOS.NewRow();
            nuevo["descripcion"] = param[0];

            for (int x = 0; x < lbServicios.Items.Count; x++)
            {
                DataRow indx = ((DataRowView)lbServicios.Items[x]).Row;

                if (indx["descripcion"].ToString() == txtServicio.Text.Trim())
                {
                    MessageBox.Show("Este servicio ya existe");
                    txtServicio.Clear();
                    return;
                }
            }
            this.sistemaOTDataSet.SERVICIOS.Rows.Add(nuevo);
            txtServicio.Clear();
        }

        private void cmdAñadirArea_Click(object sender, EventArgs e)
        {
            string area = txtArea.Text;

            if (area == String.Empty)
            {
                MessageBox.Show("Introduzca una nueva área en el campo correspondiente.");
                return;
            }

            DataRow nuevo = this.sistemaOTDataSet.AREAS.NewRow();
            nuevo["descripcion"] = area;

            for (int x = 0; x < lbAreas.Items.Count; x++)
            {
                DataRow indx = ((DataRowView) lbAreas.Items[x]).Row;
 
                if (indx["descripcion"].ToString() == txtArea.Text.Trim())
                {
                    MessageBox.Show("Esta área ya existe");
                    txtArea.Clear();
                    return;
                }
            }

            this.sistemaOTDataSet.AREAS.Rows.Add(nuevo);
            txtArea.Clear();
        }

        private void cmdBorrarServicio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea borrar este registro?", "Confirmación de Borrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataRowView borrar = (DataRowView) lbServicios.SelectedItem;
                string borrarString = borrar.Row["descripcion"].ToString();
                DataRow[] resultado = this.sistemaOTDataSet.SERVICIOS.Select("descripcion = '" + borrarString+"'");
                DataRow viejo = resultado[0];
                viejo.Delete();
                //this.sERVICIOSTableAdapter.Update(this.sistemaOTDataSet.SERVICIOS); 
            }
            //PENDIENTE LA VALIDACION
            
        }

        private void cmdBorrarArea_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea borrar este registro?", "Confirmación de Borrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataRowView borrar = (DataRowView)lbAreas.SelectedItem;
                string borrarString = borrar.Row["descripcion"].ToString();
                DataRow[] resultado = this.sistemaOTDataSet.AREAS.Select("descripcion = '" + borrarString + "'");
                DataRow viejo = resultado[0];
                viejo.Delete();
            }
            //this.aREASTableAdapter.Update(this.sistemaOTDataSet.AREAS);

            //PENDIENTE LA VALIDACION
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.sERVICIOSTableAdapter.Update(this.sistemaOTDataSet.SERVICIOS);
            this.aREASTableAdapter.Update(this.sistemaOTDataSet.AREAS);
            this.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.sistemaOTDataSet.SERVICIOS.RejectChanges();
            this.sistemaOTDataSet.AREAS.RejectChanges();
            this.Close();
        }
    }
}
