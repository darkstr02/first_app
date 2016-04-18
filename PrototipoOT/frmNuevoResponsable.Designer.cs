namespace PrototipoOT
{
    partial class frmNuevoResponsable
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
            System.Windows.Forms.Label apellido_patLabel;
            System.Windows.Forms.Label apellido_matLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label id_estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoResponsable));
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.sistemaOTDataSet = new PrototipoOT.SistemaOTDataSet();
            this.rESPONSABLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESPONSABLESTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.RESPONSABLESTableAdapter();
            this.tableAdapterManager = new PrototipoOT.SistemaOTDataSetTableAdapters.TableAdapterManager();
            this.rESPONSABLESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rESPONSABLESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rESPONSABLESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_patTextBox = new System.Windows.Forms.TextBox();
            this.apellido_matTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.id_estadoTextBox = new System.Windows.Forms.TextBox();
            apellido_patLabel = new System.Windows.Forms.Label();
            apellido_matLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            id_estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESPONSABLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESPONSABLESBindingNavigator)).BeginInit();
            this.rESPONSABLESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rESPONSABLESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // apellido_patLabel
            // 
            apellido_patLabel.AutoSize = true;
            apellido_patLabel.Location = new System.Drawing.Point(2, 76);
            apellido_patLabel.Name = "apellido_patLabel";
            apellido_patLabel.Size = new System.Drawing.Size(87, 13);
            apellido_patLabel.TabIndex = 26;
            apellido_patLabel.Text = "Apellido Paterno:";
            // 
            // apellido_matLabel
            // 
            apellido_matLabel.AutoSize = true;
            apellido_matLabel.Location = new System.Drawing.Point(233, 76);
            apellido_matLabel.Name = "apellido_matLabel";
            apellido_matLabel.Size = new System.Drawing.Size(89, 13);
            apellido_matLabel.TabIndex = 27;
            apellido_matLabel.Text = "Apellido Materno:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(42, 103);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 28;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(34, 129);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 29;
            direccionLabel.Text = "Dirección:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(37, 155);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 30;
            telefonoLabel.Text = "Teléfono:";
            // 
            // id_estadoLabel
            // 
            id_estadoLabel.AutoSize = true;
            id_estadoLabel.Enabled = false;
            id_estadoLabel.Location = new System.Drawing.Point(32, 184);
            id_estadoLabel.Name = "id_estadoLabel";
            id_estadoLabel.Size = new System.Drawing.Size(46, 13);
            id_estadoLabel.TabIndex = 31;
            id_estadoLabel.Text = "Estado: ";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(285, 207);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(81, 41);
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(158, 207);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(81, 41);
            this.cmdAceptar.TabIndex = 6;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // sistemaOTDataSet
            // 
            this.sistemaOTDataSet.DataSetName = "SistemaOTDataSet";
            this.sistemaOTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rESPONSABLESBindingSource
            // 
            this.rESPONSABLESBindingSource.DataMember = "RESPONSABLES";
            this.rESPONSABLESBindingSource.DataSource = this.sistemaOTDataSet;
            // 
            // rESPONSABLESTableAdapter
            // 
            this.rESPONSABLESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AREASTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAT_CUENTASTableAdapter = null;
            this.tableAdapterManager.CUENTAS_DE_USUARIOTableAdapter = null;
            this.tableAdapterManager.ESTADOSTableAdapter = null;
            this.tableAdapterManager.ORDENES_DE_TRABAJOTableAdapter = null;
            this.tableAdapterManager.RESPONSABLESTableAdapter = this.rESPONSABLESTableAdapter;
            this.tableAdapterManager.SERVICIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrototipoOT.SistemaOTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rESPONSABLESBindingNavigator
            // 
            this.rESPONSABLESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rESPONSABLESBindingNavigator.BindingSource = this.rESPONSABLESBindingSource;
            this.rESPONSABLESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rESPONSABLESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rESPONSABLESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rESPONSABLESBindingNavigatorSaveItem});
            this.rESPONSABLESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rESPONSABLESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rESPONSABLESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rESPONSABLESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rESPONSABLESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rESPONSABLESBindingNavigator.Name = "rESPONSABLESBindingNavigator";
            this.rESPONSABLESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rESPONSABLESBindingNavigator.Size = new System.Drawing.Size(887, 25);
            this.rESPONSABLESBindingNavigator.TabIndex = 25;
            this.rESPONSABLESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rESPONSABLESBindingNavigatorSaveItem
            // 
            this.rESPONSABLESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rESPONSABLESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rESPONSABLESBindingNavigatorSaveItem.Image")));
            this.rESPONSABLESBindingNavigatorSaveItem.Name = "rESPONSABLESBindingNavigatorSaveItem";
            this.rESPONSABLESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rESPONSABLESBindingNavigatorSaveItem.Text = "Guardar datos";
            this.rESPONSABLESBindingNavigatorSaveItem.Click += new System.EventHandler(this.rESPONSABLESBindingNavigatorSaveItem_Click);
            // 
            // rESPONSABLESDataGridView
            // 
            this.rESPONSABLESDataGridView.AutoGenerateColumns = false;
            this.rESPONSABLESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rESPONSABLESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.rESPONSABLESDataGridView.DataSource = this.rESPONSABLESBindingSource;
            this.rESPONSABLESDataGridView.Location = new System.Drawing.Point(495, 28);
            this.rESPONSABLESDataGridView.Name = "rESPONSABLESDataGridView";
            this.rESPONSABLESDataGridView.Size = new System.Drawing.Size(372, 220);
            this.rESPONSABLESDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_responsable";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "apellido_pat";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido Paterno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellido_mat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido Materno";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn6.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // apellido_patTextBox
            // 
            this.apellido_patTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rESPONSABLESBindingSource, "apellido_pat", true));
            this.apellido_patTextBox.Location = new System.Drawing.Point(91, 73);
            this.apellido_patTextBox.Name = "apellido_patTextBox";
            this.apellido_patTextBox.Size = new System.Drawing.Size(136, 20);
            this.apellido_patTextBox.TabIndex = 27;
            // 
            // apellido_matTextBox
            // 
            this.apellido_matTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rESPONSABLESBindingSource, "apellido_mat", true));
            this.apellido_matTextBox.Location = new System.Drawing.Point(326, 73);
            this.apellido_matTextBox.Name = "apellido_matTextBox";
            this.apellido_matTextBox.Size = new System.Drawing.Size(147, 20);
            this.apellido_matTextBox.TabIndex = 28;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rESPONSABLESBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(91, 99);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(382, 20);
            this.nombreTextBox.TabIndex = 29;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rESPONSABLESBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(91, 125);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(382, 20);
            this.direccionTextBox.TabIndex = 30;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rESPONSABLESBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(91, 152);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(382, 20);
            this.telefonoTextBox.TabIndex = 31;
            // 
            // id_estadoTextBox
            // 
            this.id_estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rESPONSABLESBindingSource, "id_estado", true));
            this.id_estadoTextBox.Enabled = false;
            this.id_estadoTextBox.Location = new System.Drawing.Point(91, 181);
            this.id_estadoTextBox.Name = "id_estadoTextBox";
            this.id_estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_estadoTextBox.TabIndex = 32;
            this.id_estadoTextBox.Text = "1";
            this.id_estadoTextBox.TextChanged += new System.EventHandler(this.id_estadoTextBox_TextChanged);
            // 
            // frmNuevoResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 279);
            this.Controls.Add(id_estadoLabel);
            this.Controls.Add(this.id_estadoTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellido_matLabel);
            this.Controls.Add(this.apellido_matTextBox);
            this.Controls.Add(apellido_patLabel);
            this.Controls.Add(this.apellido_patTextBox);
            this.Controls.Add(this.rESPONSABLESDataGridView);
            this.Controls.Add(this.rESPONSABLESBindingNavigator);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNuevoResponsable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevoResponsable";
            this.Load += new System.EventHandler(this.frmNuevoResponsable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESPONSABLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESPONSABLESBindingNavigator)).EndInit();
            this.rESPONSABLESBindingNavigator.ResumeLayout(false);
            this.rESPONSABLESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rESPONSABLESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdAceptar;
        private SistemaOTDataSet sistemaOTDataSet;
        private System.Windows.Forms.BindingSource rESPONSABLESBindingSource;
        private SistemaOTDataSetTableAdapters.RESPONSABLESTableAdapter rESPONSABLESTableAdapter;
        private SistemaOTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rESPONSABLESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rESPONSABLESBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rESPONSABLESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox apellido_patTextBox;
        private System.Windows.Forms.TextBox apellido_matTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox id_estadoTextBox;
    }
}