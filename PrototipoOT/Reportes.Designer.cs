namespace PrototipoOT
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdResponsable = new System.Windows.Forms.Button();
            this.chkEntregado = new System.Windows.Forms.CheckBox();
            this.cmbArea = new System.Windows.Forms.Button();
            this.cmdServicio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.vwnombreresponsablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaOTDataSet = new PrototipoOT.SistemaOTDataSet();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.aREASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.sERVICIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.sERVICIOSTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.SERVICIOSTableAdapter();
            this.aREASTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.AREASTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radResponsable = new System.Windows.Forms.RadioButton();
            this.radArea = new System.Windows.Forms.RadioButton();
            this.radServicio = new System.Windows.Forms.RadioButton();
            this.vw_nombreresponsablesTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.vw_nombreresponsablesTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwnombreresponsablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aREASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOSBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaFinal);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Location = new System.Drawing.Point(35, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(69, 81);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(68, 36);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdResponsable);
            this.groupBox2.Controls.Add(this.chkEntregado);
            this.groupBox2.Controls.Add(this.cmbArea);
            this.groupBox2.Controls.Add(this.cmdServicio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbResponsable);
            this.groupBox2.Controls.Add(this.cbArea);
            this.groupBox2.Controls.Add(this.cbServicio);
            this.groupBox2.Location = new System.Drawing.Point(129, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // cmdResponsable
            // 
            this.cmdResponsable.Image = global::PrototipoOT.Properties.Resources.limpiar;
            this.cmdResponsable.Location = new System.Drawing.Point(220, 90);
            this.cmdResponsable.Name = "cmdResponsable";
            this.cmdResponsable.Size = new System.Drawing.Size(36, 23);
            this.cmdResponsable.TabIndex = 8;
            this.cmdResponsable.UseVisualStyleBackColor = true;
            this.cmdResponsable.Click += new System.EventHandler(this.cmdResponsable_Click);
            // 
            // chkEntregado
            // 
            this.chkEntregado.AutoSize = true;
            this.chkEntregado.Checked = true;
            this.chkEntregado.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkEntregado.Location = new System.Drawing.Point(95, 121);
            this.chkEntregado.Name = "chkEntregado";
            this.chkEntregado.Size = new System.Drawing.Size(80, 17);
            this.chkEntregado.TabIndex = 4;
            this.chkEntregado.Text = "Entregados";
            this.chkEntregado.ThreeState = true;
            this.chkEntregado.UseVisualStyleBackColor = true;
            // 
            // cmbArea
            // 
            this.cmbArea.Image = global::PrototipoOT.Properties.Resources.limpiar;
            this.cmbArea.Location = new System.Drawing.Point(220, 55);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(36, 23);
            this.cmbArea.TabIndex = 7;
            this.cmbArea.UseVisualStyleBackColor = true;
            this.cmbArea.Click += new System.EventHandler(this.cmbArea_Click);
            // 
            // cmdServicio
            // 
            this.cmdServicio.Image = global::PrototipoOT.Properties.Resources.limpiar;
            this.cmdServicio.Location = new System.Drawing.Point(220, 20);
            this.cmdServicio.Name = "cmdServicio";
            this.cmdServicio.Size = new System.Drawing.Size(36, 29);
            this.cmdServicio.TabIndex = 6;
            this.cmdServicio.UseVisualStyleBackColor = true;
            this.cmdServicio.Click += new System.EventHandler(this.cmdServicio_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Responsable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Área:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Servicio:";
            // 
            // cbResponsable
            // 
            this.cbResponsable.DataSource = this.vwnombreresponsablesBindingSource;
            this.cbResponsable.DisplayMember = "Responsable";
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(82, 91);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(121, 21);
            this.cbResponsable.TabIndex = 2;
            this.cbResponsable.ValueMember = "id_responsable";
            // 
            // vwnombreresponsablesBindingSource
            // 
            this.vwnombreresponsablesBindingSource.DataMember = "vw_nombreresponsables";
            this.vwnombreresponsablesBindingSource.DataSource = this.sistemaOTDataSet;
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
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(82, 56);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(121, 21);
            this.cbArea.TabIndex = 1;
            this.cbArea.ValueMember = "id_area";
            // 
            // aREASBindingSource
            // 
            this.aREASBindingSource.DataMember = "AREAS";
            this.aREASBindingSource.DataSource = this.sistemaOTDataSet;
            // 
            // cbServicio
            // 
            this.cbServicio.DataSource = this.sERVICIOSBindingSource;
            this.cbServicio.DisplayMember = "descripcion";
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Location = new System.Drawing.Point(82, 21);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(121, 21);
            this.cbServicio.TabIndex = 0;
            this.cbServicio.ValueMember = "id_servicio";
            // 
            // sERVICIOSBindingSource
            // 
            this.sERVICIOSBindingSource.DataMember = "SERVICIOS";
            this.sERVICIOSBindingSource.DataSource = this.sistemaOTDataSet;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(113, 317);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(81, 41);
            this.cmdAceptar.TabIndex = 2;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.Location = new System.Drawing.Point(233, 317);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(81, 41);
            this.cmdCancelar.TabIndex = 3;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radResponsable);
            this.groupBox3.Controls.Add(this.radArea);
            this.groupBox3.Controls.Add(this.radServicio);
            this.groupBox3.Location = new System.Drawing.Point(35, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(93, 142);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reporte por:";
            // 
            // radResponsable
            // 
            this.radResponsable.AutoSize = true;
            this.radResponsable.Location = new System.Drawing.Point(6, 93);
            this.radResponsable.Name = "radResponsable";
            this.radResponsable.Size = new System.Drawing.Size(87, 17);
            this.radResponsable.TabIndex = 14;
            this.radResponsable.Text = "Responsable";
            this.radResponsable.UseVisualStyleBackColor = true;
            // 
            // radArea
            // 
            this.radArea.AutoSize = true;
            this.radArea.Location = new System.Drawing.Point(6, 58);
            this.radArea.Name = "radArea";
            this.radArea.Size = new System.Drawing.Size(47, 17);
            this.radArea.TabIndex = 13;
            this.radArea.Text = "Área";
            this.radArea.UseVisualStyleBackColor = true;
            // 
            // radServicio
            // 
            this.radServicio.AutoSize = true;
            this.radServicio.Checked = true;
            this.radServicio.Location = new System.Drawing.Point(6, 23);
            this.radServicio.Name = "radServicio";
            this.radServicio.Size = new System.Drawing.Size(63, 17);
            this.radServicio.TabIndex = 12;
            this.radServicio.TabStop = true;
            this.radServicio.Text = "Servicio";
            this.radServicio.UseVisualStyleBackColor = true;
            // 
            // vw_nombreresponsablesTableAdapter
            // 
            this.vw_nombreresponsablesTableAdapter.ClearBeforeFill = true;
            // 
            // Reportes
            // 
            this.AcceptButton = this.cmdAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(424, 387);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwnombreresponsablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aREASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOSBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbResponsable;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.Button cmdResponsable;
        private System.Windows.Forms.Button cmbArea;
        private System.Windows.Forms.Button cmdServicio;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.CheckBox chkEntregado;
        private SistemaOTDataSet sistemaOTDataSet;
        private System.Windows.Forms.BindingSource sERVICIOSBindingSource;
        private SistemaOTDataSetTableAdapters.SERVICIOSTableAdapter sERVICIOSTableAdapter;
        private System.Windows.Forms.BindingSource aREASBindingSource;
        private SistemaOTDataSetTableAdapters.AREASTableAdapter aREASTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radResponsable;
        private System.Windows.Forms.RadioButton radArea;
        private System.Windows.Forms.RadioButton radServicio;
        private System.Windows.Forms.BindingSource vwnombreresponsablesBindingSource;
        private SistemaOTDataSetTableAdapters.vw_nombreresponsablesTableAdapter vw_nombreresponsablesTableAdapter;
    }
}