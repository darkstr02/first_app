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
            this.aREASTableAdapter.Fill(this.sistemaOTDataSet.AREAS);
            // TODO: esta línea de código carga datos en la tabla 'sistemaOTDataSet.SERVICIOS' Puede moverla o quitarla según sea necesario.
            this.sERVICIOSTableAdapter.Fill(this.sistemaOTDataSet.SERVICIOS);
            bd = new BaseDeDatos();
        }

        private void cmdAñadirServicio_Click(object sender, EventArgs e)
        {
            string[] param = new string[1];
            param[0] = txtServicio.Text;

            //bd.insertData("SERVICIOS",param);

            DataRow nuevo = this.sistemaOTDataSet.SERVICIOS.NewRow();
            nuevo["descripcion"] = param[0];
            this.sistemaOTDataSet.SERVICIOS.Rows.Add(nuevo);

            this.sERVICIOSTableAdapter.Update(this.sistemaOTDataSet.SERVICIOS);       
        }

        private void cmdAñadirArea_Click(object sender, EventArgs e)
        {
            string area = txtArea.Text;

            DataRow nuevo = this.sistemaOTDataSet.AREAS.NewRow();
            nuevo["descripcion"] = area;
            this.sistemaOTDataSet.AREAS.Rows.Add(nuevo);
            this.aREASTableAdapter.Update(this.sistemaOTDataSet.AREAS);
        }

        private void cmdBorrarServicio_Click(object sender, EventArgs e)
        {
            DataRowView borrar = (DataRowView) lbServicios.SelectedItem;
            string borrarString = borrar.Row["descripcion"].ToString();
            DataRow[] resultado = this.sistemaOTDataSet.SERVICIOS.Select("descripcion = '" + borrarString+"'");
            DataRow viejo = resultado[0];
            viejo.Delete();
            this.sERVICIOSTableAdapter.Update(this.sistemaOTDataSet.SERVICIOS); 
        }

        private void cmdBorrarArea_Click(object sender, EventArgs e)
        {
            DataRowView borrar = (DataRowView)lbAreas.SelectedItem;
            string borrarString = borrar.Row["descripcion"].ToString();
            DataRow[] resultado = this.sistemaOTDataSet.AREAS.Select("descripcion = '" + borrarString + "'");
            DataRow viejo = resultado[0];
            viejo.Delete();
            this.aREASTableAdapter.Update(this.sistemaOTDataSet.AREAS); 
        }


    }
}
