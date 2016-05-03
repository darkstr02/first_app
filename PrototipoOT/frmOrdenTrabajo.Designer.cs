namespace PrototipoOT
{
    partial class frmOrdenTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenTrabajo));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.sERVICIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaOTDataSet = new PrototipoOT.SistemaOTDataSet();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.aREASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaOTDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaOTDataSet1 = new PrototipoOT.SistemaOTDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.vwnombreresponsablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESPONSABLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdItems = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.rbEntregadoNo = new System.Windows.Forms.RadioButton();
            this.rbEntregadoSi = new System.Windows.Forms.RadioButton();
            this.sERVICIOSTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.SERVICIOSTableAdapter();
            this.aREASTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.AREASTableAdapter();
            this.rESPONSABLESTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.RESPONSABLESTableAdapter();
            this.vw_nombreresponsablesTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.vw_nombreresponsablesTableAdapter();
            this.oRDENES_DE_TRABAJOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDENES_DE_TRABAJOTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.ORDENES_DE_TRABAJOTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aREASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwnombreresponsablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESPONSABLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDENES_DE_TRABAJOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(87, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(192, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(349, 29);
            this.txtConsecutivo.MaxLength = 7;
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(84, 20);
            this.txtConsecutivo.TabIndex = 1;
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(87, 72);
            this.txtSolicitante.MaxLength = 100;
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(346, 20);
            this.txtSolicitante.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(87, 152);
            this.txtDescripcion.MaxLength = 300;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(346, 60);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(87, 260);
            this.txtObservaciones.MaxLength = 300;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(346, 68);
            this.txtObservaciones.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(269, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbServicio
            // 
            this.cbServicio.DataSource = this.sERVICIOSBindingSource;
            this.cbServicio.DisplayMember = "descripcion";
            this.cbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Location = new System.Drawing.Point(87, 113);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(121, 21);
            this.cbServicio.TabIndex = 3;
            this.cbServicio.ValueMember = "id_servicio";
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
            // cbArea
            // 
            this.cbArea.DataSource = this.aREASBindingSource;
            this.cbArea.DisplayMember = "descripcion";
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(255, 113);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(121, 21);
            this.cbArea.TabIndex = 4;
            this.cbArea.ValueMember = "id_area";
            // 
            // aREASBindingSource
            // 
            this.aREASBindingSource.DataMember = "AREAS";
            this.aREASBindingSource.DataSource = this.sistemaOTDataSet1BindingSource;
            // 
            // sistemaOTDataSet1BindingSource
            // 
            this.sistemaOTDataSet1BindingSource.DataSource = this.sistemaOTDataSet1;
            this.sistemaOTDataSet1BindingSource.Position = 0;
            // 
            // sistemaOTDataSet1
            // 
            this.sistemaOTDataSet1.DataSetName = "SistemaOTDataSet";
            this.sistemaOTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Consecutivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Solicitante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Servicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Área:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Responsable:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Observaciones:";
            // 
            // cbResponsable
            // 
            this.cbResponsable.DataSource = this.vwnombreresponsablesBindingSource;
            this.cbResponsable.DisplayMember = "Responsable";
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(87, 223);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(162, 21);
            this.cbResponsable.TabIndex = 7;
            this.cbResponsable.ValueMember = "id_responsable";
            // 
            // vwnombreresponsablesBindingSource
            // 
            this.vwnombreresponsablesBindingSource.DataMember = "vw_nombreresponsables";
            this.vwnombreresponsablesBindingSource.DataSource = this.sistemaOTDataSet;
            // 
            // rESPONSABLESBindingSource
            // 
            this.rESPONSABLESBindingSource.DataMember = "RESPONSABLES";
            this.rESPONSABLESBindingSource.DataSource = this.sistemaOTDataSet;
            // 
            // cmdItems
            // 
            this.cmdItems.Location = new System.Drawing.Point(382, 113);
            this.cmdItems.Name = "cmdItems";
            this.cmdItems.Size = new System.Drawing.Size(51, 23);
            this.cmdItems.TabIndex = 5;
            this.cmdItems.Text = "Items...";
            this.cmdItems.UseVisualStyleBackColor = true;
            this.cmdItems.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Entregado:";
            // 
            // rbEntregadoNo
            // 
            this.rbEntregadoNo.AutoSize = true;
            this.rbEntregadoNo.Checked = true;
            this.rbEntregadoNo.Location = new System.Drawing.Point(320, 222);
            this.rbEntregadoNo.Name = "rbEntregadoNo";
            this.rbEntregadoNo.Size = new System.Drawing.Size(39, 17);
            this.rbEntregadoNo.TabIndex = 8;
            this.rbEntregadoNo.TabStop = true;
            this.rbEntregadoNo.Text = "No";
            this.rbEntregadoNo.UseVisualStyleBackColor = true;
            this.rbEntregadoNo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbEntregadoSi
            // 
            this.rbEntregadoSi.AutoSize = true;
            this.rbEntregadoSi.Location = new System.Drawing.Point(397, 223);
            this.rbEntregadoSi.Name = "rbEntregadoSi";
            this.rbEntregadoSi.Size = new System.Drawing.Size(36, 17);
            this.rbEntregadoSi.TabIndex = 9;
            this.rbEntregadoSi.TabStop = true;
            this.rbEntregadoSi.Text = "Sí";
            this.rbEntregadoSi.UseVisualStyleBackColor = true;
            // 
            // sERVICIOSTableAdapter
            // 
            this.sERVICIOSTableAdapter.ClearBeforeFill = true;
            // 
            // aREASTableAdapter
            // 
            this.aREASTableAdapter.ClearBeforeFill = true;
            // 
            // rESPONSABLESTableAdapter
            // 
            this.rESPONSABLESTableAdapter.ClearBeforeFill = true;
            // 
            // vw_nombreresponsablesTableAdapter
            // 
            this.vw_nombreresponsablesTableAdapter.ClearBeforeFill = true;
            // 
            // oRDENES_DE_TRABAJOBindingSource
            // 
            this.oRDENES_DE_TRABAJOBindingSource.DataMember = "ORDENES_DE_TRABAJO";
            this.oRDENES_DE_TRABAJOBindingSource.DataSource = this.sistemaOTDataSet;
            // 
            // oRDENES_DE_TRABAJOTableAdapter
            // 
            this.oRDENES_DE_TRABAJOTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmOrdenTrabajo
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(472, 395);
            this.Controls.Add(this.rbEntregadoSi);
            this.Controls.Add(this.rbEntregadoNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmdItems);
            this.Controls.Add(this.cbResponsable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.cbServicio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtSolicitante);
            this.Controls.Add(this.txtConsecutivo);
            this.Controls.Add(this.dtpFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrdenTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Órden de Trabajo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrdenTrabajo_FormClosing);
            this.Load += new System.EventHandler(this.frmOrdenTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aREASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwnombreresponsablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESPONSABLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDENES_DE_TRABAJOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbResponsable;
        private System.Windows.Forms.Button cmdItems;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbEntregadoNo;
        private System.Windows.Forms.RadioButton rbEntregadoSi;
        private SistemaOTDataSet sistemaOTDataSet;
        private System.Windows.Forms.BindingSource sERVICIOSBindingSource;
        private SistemaOTDataSetTableAdapters.SERVICIOSTableAdapter sERVICIOSTableAdapter;
        private System.Windows.Forms.BindingSource sistemaOTDataSet1BindingSource;
        private SistemaOTDataSet sistemaOTDataSet1;
        private System.Windows.Forms.BindingSource aREASBindingSource;
        private SistemaOTDataSetTableAdapters.AREASTableAdapter aREASTableAdapter;
        private System.Windows.Forms.BindingSource rESPONSABLESBindingSource;
        private SistemaOTDataSetTableAdapters.RESPONSABLESTableAdapter rESPONSABLESTableAdapter;
        private System.Windows.Forms.BindingSource vwnombreresponsablesBindingSource;
        private SistemaOTDataSetTableAdapters.vw_nombreresponsablesTableAdapter vw_nombreresponsablesTableAdapter;
        private System.Windows.Forms.BindingSource oRDENES_DE_TRABAJOBindingSource;
        private SistemaOTDataSetTableAdapters.ORDENES_DE_TRABAJOTableAdapter oRDENES_DE_TRABAJOTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}