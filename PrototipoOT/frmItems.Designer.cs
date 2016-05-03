namespace PrototipoOT
{
    partial class frmItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.cmdAñadirServicio = new System.Windows.Forms.Button();
            this.cmdAñadirArea = new System.Windows.Forms.Button();
            this.lbServicios = new System.Windows.Forms.ListBox();
            this.sERVICIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaOTDataSet = new PrototipoOT.SistemaOTDataSet();
            this.lbAreas = new System.Windows.Forms.ListBox();
            this.aREASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.sERVICIOSTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.SERVICIOSTableAdapter();
            this.aREASTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.AREASTableAdapter();
            this.cmdBorrarServicio = new System.Windows.Forms.Button();
            this.cmdBorrarArea = new System.Windows.Forms.Button();
            this.tableAdapterManager = new PrototipoOT.SistemaOTDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aREASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(70, 22);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(100, 20);
            this.txtServicio.TabIndex = 1;
            this.txtServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServicio_KeyPress);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(243, 22);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 5;
            this.txtArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArea_KeyPress);
            // 
            // cmdAñadirServicio
            // 
            this.cmdAñadirServicio.Location = new System.Drawing.Point(83, 48);
            this.cmdAñadirServicio.Name = "cmdAñadirServicio";
            this.cmdAñadirServicio.Size = new System.Drawing.Size(75, 23);
            this.cmdAñadirServicio.TabIndex = 2;
            this.cmdAñadirServicio.Text = "Añadir";
            this.cmdAñadirServicio.UseVisualStyleBackColor = true;
            this.cmdAñadirServicio.Click += new System.EventHandler(this.cmdAñadirServicio_Click);
            // 
            // cmdAñadirArea
            // 
            this.cmdAñadirArea.Location = new System.Drawing.Point(257, 48);
            this.cmdAñadirArea.Name = "cmdAñadirArea";
            this.cmdAñadirArea.Size = new System.Drawing.Size(75, 23);
            this.cmdAñadirArea.TabIndex = 6;
            this.cmdAñadirArea.Text = "Añadir";
            this.cmdAñadirArea.UseVisualStyleBackColor = true;
            this.cmdAñadirArea.Click += new System.EventHandler(this.cmdAñadirArea_Click);
            // 
            // lbServicios
            // 
            this.lbServicios.DataSource = this.sERVICIOSBindingSource;
            this.lbServicios.DisplayMember = "descripcion";
            this.lbServicios.FormattingEnabled = true;
            this.lbServicios.Location = new System.Drawing.Point(56, 77);
            this.lbServicios.Name = "lbServicios";
            this.lbServicios.Size = new System.Drawing.Size(128, 95);
            this.lbServicios.TabIndex = 3;
            this.lbServicios.ValueMember = "id_servicio";
            // 
            // sERVICIOSBindingSource
            // 
            this.sERVICIOSBindingSource.DataMember = "SERVICIOS";
            this.sERVICIOSBindingSource.DataSource = this.sistemaOTDataSet;
            // 
            // sistemaOTDataSet
            // 
            this.sistemaOTDataSet.DataSetName = "SistemaOTDataSet";
            this.sistemaOTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbAreas
            // 
            this.lbAreas.DataSource = this.aREASBindingSource;
            this.lbAreas.DisplayMember = "descripcion";
            this.lbAreas.FormattingEnabled = true;
            this.lbAreas.Location = new System.Drawing.Point(234, 77);
            this.lbAreas.Name = "lbAreas";
            this.lbAreas.Size = new System.Drawing.Size(120, 95);
            this.lbAreas.TabIndex = 7;
            this.lbAreas.ValueMember = "id_area";
            // 
            // aREASBindingSource
            // 
            this.aREASBindingSource.DataMember = "AREAS";
            this.aREASBindingSource.DataSource = this.sistemaOTDataSet;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(81, 241);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(81, 41);
            this.cmdAceptar.TabIndex = 9;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(252, 241);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(81, 41);
            this.cmdCancelar.TabIndex = 10;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // sERVICIOSTableAdapter
            // 
            this.sERVICIOSTableAdapter.ClearBeforeFill = true;
            // 
            // aREASTableAdapter
            // 
            this.aREASTableAdapter.ClearBeforeFill = true;
            // 
            // cmdBorrarServicio
            // 
            this.cmdBorrarServicio.Location = new System.Drawing.Point(83, 178);
            this.cmdBorrarServicio.Name = "cmdBorrarServicio";
            this.cmdBorrarServicio.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrarServicio.TabIndex = 4;
            this.cmdBorrarServicio.Text = "Borrar";
            this.cmdBorrarServicio.UseVisualStyleBackColor = true;
            this.cmdBorrarServicio.Click += new System.EventHandler(this.cmdBorrarServicio_Click);
            // 
            // cmdBorrarArea
            // 
            this.cmdBorrarArea.Location = new System.Drawing.Point(254, 178);
            this.cmdBorrarArea.Name = "cmdBorrarArea";
            this.cmdBorrarArea.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrarArea.TabIndex = 8;
            this.cmdBorrarArea.Text = "Borrar";
            this.cmdBorrarArea.UseVisualStyleBackColor = true;
            this.cmdBorrarArea.Click += new System.EventHandler(this.cmdBorrarArea_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AREASTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAT_CUENTASTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CUENTAS_DE_USUARIOTableAdapter = null;
            this.tableAdapterManager.ESTADOSTableAdapter = null;
            this.tableAdapterManager.ORDENES_DE_TRABAJOTableAdapter = null;
            this.tableAdapterManager.RESPONSABLESTableAdapter = null;
            this.tableAdapterManager.SERVICIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrototipoOT.SistemaOTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Servicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Área:";
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdBorrarArea);
            this.Controls.Add(this.cmdBorrarServicio);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.lbAreas);
            this.Controls.Add(this.lbServicios);
            this.Controls.Add(this.cmdAñadirArea);
            this.Controls.Add(this.cmdAñadirServicio);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtServicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir o eliminar items...";
            this.Load += new System.EventHandler(this.frmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aREASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button cmdAñadirServicio;
        private System.Windows.Forms.Button cmdAñadirArea;
        private System.Windows.Forms.ListBox lbServicios;
        private System.Windows.Forms.ListBox lbAreas;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Button cmdCancelar;
        private SistemaOTDataSet sistemaOTDataSet;
        private System.Windows.Forms.BindingSource sERVICIOSBindingSource;
        private SistemaOTDataSetTableAdapters.SERVICIOSTableAdapter sERVICIOSTableAdapter;
        private System.Windows.Forms.BindingSource aREASBindingSource;
        private SistemaOTDataSetTableAdapters.AREASTableAdapter aREASTableAdapter;
        private System.Windows.Forms.Button cmdBorrarServicio;
        private System.Windows.Forms.Button cmdBorrarArea;
        private SistemaOTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}