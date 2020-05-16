namespace CalculadoraRecetas.Forms
{
    partial class frmCostoMaterialesAddMod
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.bsCostoMaterial = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.txtDetalle = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecioUnitario = new DevExpress.XtraEditors.TextEdit();
            this.txtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.txtCostoTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtNota = new DevExpress.XtraEditors.MemoEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboMateriaPrima = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsMateriaPrimaLista = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbreviatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboProveedores = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsProveedoresLista = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostoMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioUnitario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMateriaPrima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMateriaPrimaLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProveedores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedoresLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Detalle:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio Unitario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Costo Total:";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoMaterial, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(112, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(181, 20);
            this.txtId.TabIndex = 8;
            // 
            // bsCostoMaterial
            // 
            this.bsCostoMaterial.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.CostoMateriales);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia Prima:";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCostoMaterial, "FechaCompra", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCompra.Location = new System.Drawing.Point(112, 92);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(181, 20);
            this.dtpFechaCompra.TabIndex = 11;
            // 
            // txtDetalle
            // 
            this.txtDetalle.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoMaterial, "Detalle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDetalle.Location = new System.Drawing.Point(112, 118);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(181, 20);
            this.txtDetalle.TabIndex = 13;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoMaterial, "PrecioUnitario", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(112, 144);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Properties.Mask.EditMask = "n2";
            this.txtPrecioUnitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(181, 20);
            this.txtPrecioUnitario.TabIndex = 14;
            // 
            // txtCantidad
            // 
            this.txtCantidad.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoMaterial, "Cantidad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtCantidad.Location = new System.Drawing.Point(112, 170);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Properties.Mask.EditMask = "n0";
            this.txtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidad.Size = new System.Drawing.Size(181, 20);
            this.txtCantidad.TabIndex = 15;
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoMaterial, "CostoTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtCostoTotal.Location = new System.Drawing.Point(112, 222);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Properties.Mask.EditMask = "n2";
            this.txtCostoTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCostoTotal.Size = new System.Drawing.Size(181, 20);
            this.txtCostoTotal.TabIndex = 16;
            // 
            // txtNota
            // 
            this.txtNota.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoMaterial, "Notas", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNota.Location = new System.Drawing.Point(324, 31);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(249, 207);
            this.txtNota.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Notas:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(417, 244);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(498, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboMateriaPrima
            // 
            this.cboMateriaPrima.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoMaterial, "Id_MateriaPrima", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.cboMateriaPrima.EditValue = "";
            this.cboMateriaPrima.Location = new System.Drawing.Point(112, 38);
            this.cboMateriaPrima.Name = "cboMateriaPrima";
            this.cboMateriaPrima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMateriaPrima.Properties.DataSource = this.bsMateriaPrimaLista;
            this.cboMateriaPrima.Properties.DisplayMember = "Nombre";
            this.cboMateriaPrima.Properties.ValueMember = "Id";
            this.cboMateriaPrima.Properties.View = this.gridLookUpEdit1View;
            this.cboMateriaPrima.Size = new System.Drawing.Size(181, 20);
            this.cboMateriaPrima.TabIndex = 21;
            // 
            // bsMateriaPrimaLista
            // 
            this.bsMateriaPrimaLista.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.MateriaPrima);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre,
            this.colAbreviatura});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // colAbreviatura
            // 
            this.colAbreviatura.FieldName = "Abreviatura";
            this.colAbreviatura.Name = "colAbreviatura";
            this.colAbreviatura.Visible = true;
            this.colAbreviatura.VisibleIndex = 1;
            // 
            // cboProveedores
            // 
            this.cboProveedores.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoMaterial, "Id_Proveedor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.cboProveedores.EditValue = "";
            this.cboProveedores.Location = new System.Drawing.Point(112, 64);
            this.cboProveedores.Name = "cboProveedores";
            this.cboProveedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProveedores.Properties.DataSource = this.bsProveedoresLista;
            this.cboProveedores.Properties.DisplayMember = "Nombre";
            this.cboProveedores.Properties.ValueMember = "Id";
            this.cboProveedores.Properties.View = this.gridView1;
            this.cboProveedores.Size = new System.Drawing.Size(181, 20);
            this.cboProveedores.TabIndex = 22;
            // 
            // bsProveedoresLista
            // 
            this.bsProveedoresLista.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.Proveedor);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNombre1
            // 
            this.colNombre1.FieldName = "Nombre";
            this.colNombre1.Name = "colNombre1";
            this.colNombre1.Visible = true;
            this.colNombre1.VisibleIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Costo Sugerido:";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoMaterial, "CostoTotalSugerido", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(112, 196);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(181, 20);
            this.textEdit1.TabIndex = 24;
            // 
            // frmCostoMaterialesAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 276);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboProveedores);
            this.Controls.Add(this.cboMateriaPrima);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtCostoTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.dtpFechaCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCostoMaterialesAddMod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Costo de Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCostoMaterialesAddMod_FormClosing);
            this.Load += new System.EventHandler(this.frmCostoMaterialesAddMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostoMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioUnitario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMateriaPrima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMateriaPrimaLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProveedores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedoresLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private DevExpress.XtraEditors.TextEdit txtDetalle;
        private DevExpress.XtraEditors.TextEdit txtPrecioUnitario;
        private DevExpress.XtraEditors.TextEdit txtCantidad;
        private DevExpress.XtraEditors.TextEdit txtCostoTotal;
        private DevExpress.XtraEditors.MemoEdit txtNota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource bsCostoMaterial;
        private DevExpress.XtraEditors.GridLookUpEdit cboMateriaPrima;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit cboProveedores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsMateriaPrimaLista;
        private System.Windows.Forms.BindingSource bsProveedoresLista;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colAbreviatura;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre1;
    }
}