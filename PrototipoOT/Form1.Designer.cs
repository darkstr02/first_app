namespace PrototipoOT
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.órdenesDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarResponsablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.áreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwordenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaOTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaOTDataSet = new PrototipoOT.SistemaOTDataSet();
            this.oRDENESDETRABAJOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDENES_DE_TRABAJOTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.ORDENES_DE_TRABAJOTableAdapter();
            this.sistemaOTDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_ordenesTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.vw_ordenesTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbConectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbPermisos = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwordenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDENESDETRABAJOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSetBindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.órdenesDeTrabajoToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // órdenesDeTrabajoToolStripMenuItem
            // 
            this.órdenesDeTrabajoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.modificaciónToolStripMenuItem,
            this.borrarToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.filtrarToolStripMenuItem});
            this.órdenesDeTrabajoToolStripMenuItem.Name = "órdenesDeTrabajoToolStripMenuItem";
            this.órdenesDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.órdenesDeTrabajoToolStripMenuItem.Text = "Órdenes de Trabajo";
            this.órdenesDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.órdenesDeTrabajoToolStripMenuItem_Click);
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // modificaciónToolStripMenuItem
            // 
            this.modificaciónToolStripMenuItem.Name = "modificaciónToolStripMenuItem";
            this.modificaciónToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.modificaciónToolStripMenuItem.Text = "Modificación";
            this.modificaciónToolStripMenuItem.Click += new System.EventHandler(this.modificaciónToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // filtrarToolStripMenuItem
            // 
            this.filtrarToolStripMenuItem.Name = "filtrarToolStripMenuItem";
            this.filtrarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.filtrarToolStripMenuItem.Text = "Filtrar";
            this.filtrarToolStripMenuItem.Click += new System.EventHandler(this.filtrarToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarUsuariosToolStripMenuItem,
            this.administrarResponsablesToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            this.administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            this.administrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.administrarUsuariosToolStripMenuItem.Text = "Administrar Usuarios...";
            this.administrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.administrarUsuariosToolStripMenuItem_Click);
            // 
            // administrarResponsablesToolStripMenuItem
            // 
            this.administrarResponsablesToolStripMenuItem.Name = "administrarResponsablesToolStripMenuItem";
            this.administrarResponsablesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.administrarResponsablesToolStripMenuItem.Text = "Administrar Responsables...";
            this.administrarResponsablesToolStripMenuItem.Click += new System.EventHandler(this.administrarResponsablesToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aToolStripMenuItem.Text = "Ayuda";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(641, 63);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton1.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton1.Text = "Nuevo";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton1.ToolTipText = "Registra una nueva orden de trabajo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripButton2.Image = global::PrototipoOT.Properties.Resources.edit2;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton2.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton2.Text = "Modificar";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.Image = global::PrototipoOT.Properties.Resources.delete2;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton3.Text = "Borrar";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.Image = global::PrototipoOT.Properties.Resources.report;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton4.Text = "Reportes";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.Image = global::PrototipoOT.Properties.Resources.search;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton5.Text = "Buscar";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.Image = global::PrototipoOT.Properties.Resources.filter2;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton6.Text = "Filtrar";
            this.toolStripButton6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.consecutivoDataGridViewTextBoxColumn,
            this.solicitanteDataGridViewTextBoxColumn,
            this.áreaDataGridViewTextBoxColumn,
            this.servicioDataGridViewTextBoxColumn,
            this.responsableDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.entregadoDataGridViewCheckBoxColumn,
            this.fechaEntregaDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwordenesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 331);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consecutivoDataGridViewTextBoxColumn
            // 
            this.consecutivoDataGridViewTextBoxColumn.DataPropertyName = "consecutivo";
            this.consecutivoDataGridViewTextBoxColumn.HeaderText = "Consecutivo";
            this.consecutivoDataGridViewTextBoxColumn.Name = "consecutivoDataGridViewTextBoxColumn";
            this.consecutivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // solicitanteDataGridViewTextBoxColumn
            // 
            this.solicitanteDataGridViewTextBoxColumn.DataPropertyName = "solicitante";
            this.solicitanteDataGridViewTextBoxColumn.HeaderText = "Solicitante";
            this.solicitanteDataGridViewTextBoxColumn.Name = "solicitanteDataGridViewTextBoxColumn";
            this.solicitanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // áreaDataGridViewTextBoxColumn
            // 
            this.áreaDataGridViewTextBoxColumn.DataPropertyName = "Área";
            this.áreaDataGridViewTextBoxColumn.HeaderText = "Área";
            this.áreaDataGridViewTextBoxColumn.Name = "áreaDataGridViewTextBoxColumn";
            this.áreaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicioDataGridViewTextBoxColumn
            // 
            this.servicioDataGridViewTextBoxColumn.DataPropertyName = "Servicio";
            this.servicioDataGridViewTextBoxColumn.HeaderText = "Servicio";
            this.servicioDataGridViewTextBoxColumn.Name = "servicioDataGridViewTextBoxColumn";
            this.servicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responsableDataGridViewTextBoxColumn
            // 
            this.responsableDataGridViewTextBoxColumn.DataPropertyName = "Responsable";
            this.responsableDataGridViewTextBoxColumn.HeaderText = "Responsable";
            this.responsableDataGridViewTextBoxColumn.Name = "responsableDataGridViewTextBoxColumn";
            this.responsableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha de Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entregadoDataGridViewCheckBoxColumn
            // 
            this.entregadoDataGridViewCheckBoxColumn.DataPropertyName = "entregado";
            this.entregadoDataGridViewCheckBoxColumn.HeaderText = "Entregado";
            this.entregadoDataGridViewCheckBoxColumn.Name = "entregadoDataGridViewCheckBoxColumn";
            this.entregadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fechaEntregaDataGridViewTextBoxColumn
            // 
            this.fechaEntregaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Entrega";
            this.fechaEntregaDataGridViewTextBoxColumn.HeaderText = "Fecha de Entrega";
            this.fechaEntregaDataGridViewTextBoxColumn.Name = "fechaEntregaDataGridViewTextBoxColumn";
            this.fechaEntregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vwordenesBindingSource
            // 
            this.vwordenesBindingSource.DataMember = "vw_ordenes";
            this.vwordenesBindingSource.DataSource = this.sistemaOTDataSetBindingSource;
            // 
            // sistemaOTDataSetBindingSource
            // 
            this.sistemaOTDataSetBindingSource.DataSource = this.sistemaOTDataSet;
            this.sistemaOTDataSetBindingSource.Position = 0;
            // 
            // sistemaOTDataSet
            // 
            this.sistemaOTDataSet.DataSetName = "SistemaOTDataSet";
            this.sistemaOTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRDENESDETRABAJOBindingSource
            // 
            this.oRDENESDETRABAJOBindingSource.DataMember = "ORDENES_DE_TRABAJO";
            this.oRDENESDETRABAJOBindingSource.DataSource = this.sistemaOTDataSetBindingSource;
            // 
            // oRDENES_DE_TRABAJOTableAdapter
            // 
            this.oRDENES_DE_TRABAJOTableAdapter.ClearBeforeFill = true;
            // 
            // sistemaOTDataSetBindingSource1
            // 
            this.sistemaOTDataSetBindingSource1.DataSource = this.sistemaOTDataSet;
            this.sistemaOTDataSetBindingSource1.Position = 0;
            // 
            // vw_ordenesTableAdapter
            // 
            this.vw_ordenesTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbConectado,
            this.toolStripStatusLabel2,
            this.lbPermisos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(641, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(105, 17);
            this.toolStripStatusLabel1.Text = "Conectado como: ";
            // 
            // lbConectado
            // 
            this.lbConectado.Name = "lbConectado";
            this.lbConectado.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel2.Text = "Permisos: ";
            // 
            // lbPermisos
            // 
            this.lbPermisos.Name = "lbPermisos";
            this.lbPermisos.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 420);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Órdenes de Trabajo IPN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwordenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDENESDETRABAJOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSetBindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem órdenesDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarResponsablesToolStripMenuItem;
        private System.Windows.Forms.BindingSource sistemaOTDataSetBindingSource;
        private SistemaOTDataSet sistemaOTDataSet;
        private System.Windows.Forms.BindingSource oRDENESDETRABAJOBindingSource;
        private SistemaOTDataSetTableAdapters.ORDENES_DE_TRABAJOTableAdapter oRDENES_DE_TRABAJOTableAdapter;
        private System.Windows.Forms.BindingSource sistemaOTDataSetBindingSource1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn consecutivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwordenesBindingSource;
        private SistemaOTDataSetTableAdapters.vw_ordenesTableAdapter vw_ordenesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn áreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn entregadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbConectado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbPermisos;
    }
}

