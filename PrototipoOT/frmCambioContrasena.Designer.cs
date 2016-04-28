namespace PrototipoOT
{
    partial class frmCambioContrasena
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.txtContraNueva = new System.Windows.Forms.TextBox();
            this.txtConfContraNueva = new System.Windows.Forms.TextBox();
            this.sistemaOTDataSet = new PrototipoOT.SistemaOTDataSet();
            this.cUENTAS_DE_USUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUENTAS_DE_USUARIOTableAdapter = new PrototipoOT.SistemaOTDataSetTableAdapters.CUENTAS_DE_USUARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUENTAS_DE_USUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña Nueva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Contraseña Nueva:";
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(91, 124);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(81, 41);
            this.cmdAceptar.TabIndex = 3;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.Location = new System.Drawing.Point(217, 124);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(81, 41);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // txtContraActual
            // 
            this.txtContraActual.Location = new System.Drawing.Point(155, 27);
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.Size = new System.Drawing.Size(195, 20);
            this.txtContraActual.TabIndex = 5;
            // 
            // txtContraNueva
            // 
            this.txtContraNueva.Location = new System.Drawing.Point(155, 62);
            this.txtContraNueva.Name = "txtContraNueva";
            this.txtContraNueva.Size = new System.Drawing.Size(195, 20);
            this.txtContraNueva.TabIndex = 6;
            // 
            // txtConfContraNueva
            // 
            this.txtConfContraNueva.Location = new System.Drawing.Point(155, 98);
            this.txtConfContraNueva.Name = "txtConfContraNueva";
            this.txtConfContraNueva.Size = new System.Drawing.Size(195, 20);
            this.txtConfContraNueva.TabIndex = 7;
            // 
            // sistemaOTDataSet
            // 
            this.sistemaOTDataSet.DataSetName = "SistemaOTDataSet";
            this.sistemaOTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUENTAS_DE_USUARIOBindingSource
            // 
            this.cUENTAS_DE_USUARIOBindingSource.DataMember = "CUENTAS_DE_USUARIO";
            this.cUENTAS_DE_USUARIOBindingSource.DataSource = this.sistemaOTDataSet;
            // 
            // cUENTAS_DE_USUARIOTableAdapter
            // 
            this.cUENTAS_DE_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // frmCambioContrasena
            // 
            this.AcceptButton = this.cmdAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(380, 182);
            this.Controls.Add(this.txtConfContraNueva);
            this.Controls.Add(this.txtContraNueva);
            this.Controls.Add(this.txtContraActual);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambioContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Contraseña";
            this.Load += new System.EventHandler(this.frmCambioContrasena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaOTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUENTAS_DE_USUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.TextBox txtContraActual;
        private System.Windows.Forms.TextBox txtContraNueva;
        private System.Windows.Forms.TextBox txtConfContraNueva;
        private SistemaOTDataSet sistemaOTDataSet;
        private System.Windows.Forms.BindingSource cUENTAS_DE_USUARIOBindingSource;
        private SistemaOTDataSetTableAdapters.CUENTAS_DE_USUARIOTableAdapter cUENTAS_DE_USUARIOTableAdapter;
    }
}