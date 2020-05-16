namespace CalculadoraRecetas.Forms
{
    partial class frmCostoServicioAddMod
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
            this.cboServicios = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCostoSugeridoEsp = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCostoFinal = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCostoSugeridoInc = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.memoNotas = new DevExpress.XtraEditors.MemoEdit();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPorcentajeInc = new DevExpress.XtraEditors.TextEdit();
            this.txtHorasTrabajadas = new DevExpress.XtraEditors.TextEdit();
            this.txtMontoFactura = new DevExpress.XtraEditors.TextEdit();
            this.bsCostoServicio = new System.Windows.Forms.BindingSource(this.components);
            this.bsServiciosLista = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cboServicios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoSugeridoEsp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoFinal.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoSugeridoInc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNotas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeInc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHorasTrabajadas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostoServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiciosLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // cboServicios
            // 
            this.cboServicios.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoServicio, "Id_Servicio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.cboServicios.EditValue = "";
            this.cboServicios.Location = new System.Drawing.Point(95, 38);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboServicios.Properties.DataSource = this.bsServiciosLista;
            this.cboServicios.Properties.DisplayMember = "Nombre";
            this.cboServicios.Properties.ValueMember = "Id";
            this.cboServicios.Properties.View = this.gridLookUpEdit1View;
            this.cboServicios.Size = new System.Drawing.Size(162, 20);
            this.cboServicios.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servicio:";
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCostoServicio, "FechaCreacion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(95, 64);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(162, 20);
            this.dtpFechaCreacion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto Factura:";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoServicio, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(95, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(162, 20);
            this.txtId.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 86);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtCostoSugeridoEsp);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtHorasTrabajadas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(242, 60);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Especifico";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Costo Sugerido:";
            // 
            // txtCostoSugeridoEsp
            // 
            this.txtCostoSugeridoEsp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoServicio, "CostoSugeridoEspecifico", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtCostoSugeridoEsp.Enabled = false;
            this.txtCostoSugeridoEsp.Location = new System.Drawing.Point(135, 32);
            this.txtCostoSugeridoEsp.Name = "txtCostoSugeridoEsp";
            this.txtCostoSugeridoEsp.Size = new System.Drawing.Size(100, 20);
            this.txtCostoSugeridoEsp.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Costo Final:";
            // 
            // txtCostoFinal
            // 
            this.txtCostoFinal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoServicio, "CostoTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtCostoFinal.Location = new System.Drawing.Point(95, 210);
            this.txtCostoFinal.Name = "txtCostoFinal";
            this.txtCostoFinal.Size = new System.Drawing.Size(162, 20);
            this.txtCostoFinal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Horas Trabajadas (Mes):";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtCostoSugeridoInc);
            this.tabPage2.Controls.Add(this.txtPorcentajeInc);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(242, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Porcentaje Directo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Costo Sugerido:";
            // 
            // txtCostoSugeridoInc
            // 
            this.txtCostoSugeridoInc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoServicio, "CostoSugeridoIncidencia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtCostoSugeridoInc.Enabled = false;
            this.txtCostoSugeridoInc.Location = new System.Drawing.Point(135, 32);
            this.txtCostoSugeridoInc.Name = "txtCostoSugeridoInc";
            this.txtCostoSugeridoInc.Size = new System.Drawing.Size(100, 20);
            this.txtCostoSugeridoInc.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Porcentaje Incidencia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Notas:";
            // 
            // memoNotas
            // 
            this.memoNotas.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoServicio, "Notas", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.memoNotas.Location = new System.Drawing.Point(263, 31);
            this.memoNotas.Name = "memoNotas";
            this.memoNotas.Size = new System.Drawing.Size(197, 199);
            this.memoNotas.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(386, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(305, 240);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // txtPorcentajeInc
            // 
            this.txtPorcentajeInc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoServicio, "IncidenciaPorce", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0"));
            this.txtPorcentajeInc.Location = new System.Drawing.Point(135, 6);
            this.txtPorcentajeInc.Name = "txtPorcentajeInc";
            this.txtPorcentajeInc.Properties.Mask.EditMask = "n0";
            this.txtPorcentajeInc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPorcentajeInc.Properties.NullValuePrompt = "0";
            this.txtPorcentajeInc.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentajeInc.TabIndex = 13;
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoServicio, "HorasLaborablesMensual", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0"));
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(135, 6);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Properties.Mask.EditMask = "n0";
            this.txtHorasTrabajadas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtHorasTrabajadas.Properties.NullValuePrompt = "0";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTrabajadas.TabIndex = 9;
            // 
            // txtMontoFactura
            // 
            this.txtMontoFactura.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoServicio, "PrecioFactura", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtMontoFactura.Location = new System.Drawing.Point(95, 90);
            this.txtMontoFactura.Name = "txtMontoFactura";
            this.txtMontoFactura.Properties.Mask.EditMask = "n2";
            this.txtMontoFactura.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMontoFactura.Size = new System.Drawing.Size(162, 20);
            this.txtMontoFactura.TabIndex = 23;
            // 
            // bsCostoServicio
            // 
            this.bsCostoServicio.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.CostoServicio);
            // 
            // bsServiciosLista
            // 
            this.bsServiciosLista.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.Servicio);
            // 
            // frmCostoServicioAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 271);
            this.Controls.Add(this.txtMontoFactura);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCostoFinal);
            this.Controls.Add(this.memoNotas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cboServicios);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCostoServicioAddMod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Costo Servicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCostoServicioAddMod_FormClosing);
            this.Load += new System.EventHandler(this.frmCostoServicioAddMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboServicios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoSugeridoEsp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoFinal.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoSugeridoInc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNotas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeInc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHorasTrabajadas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostoServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiciosLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit cboServicios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtCostoSugeridoEsp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtCostoSugeridoInc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtCostoFinal;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.MemoEdit memoNotas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.BindingSource bsCostoServicio;
        private System.Windows.Forms.BindingSource bsServiciosLista;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraEditors.TextEdit txtHorasTrabajadas;
        private DevExpress.XtraEditors.TextEdit txtPorcentajeInc;
        private DevExpress.XtraEditors.TextEdit txtMontoFactura;
    }
}