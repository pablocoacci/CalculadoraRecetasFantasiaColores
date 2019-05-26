namespace CalculadoraRecetas.Forms
{
    partial class frmRecetasAddMod
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecetasAddMod));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.bsReceta = new System.Windows.Forms.BindingSource(this.components);
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCostoIndirectoMon = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsIngredientesLista = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_MateriaPrima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Receta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMPNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMPAbreviatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMPUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMPPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoNetoMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtComensales = new DevExpress.XtraEditors.TextEdit();
            this.txtUtilidadesPorce = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioFinal = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUtilidadesMon = new DevExpress.XtraEditors.TextEdit();
            this.txtCostoIndirectoPorce = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCostoNetoMon = new DevExpress.XtraEditors.TextEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartCompPrecio = new DevExpress.XtraCharts.ChartControl();
            this.btnAyudaReceta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoIndirectoMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIngredientesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComensales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadesPorce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadesMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoIndirectoPorce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoNetoMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comensales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Utilidades (%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Costo Indirecto (%):";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReceta, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(118, 11);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Mask.EditMask = "n0";
            this.txtId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtId.Size = new System.Drawing.Size(130, 20);
            this.txtId.TabIndex = 100;
            // 
            // bsReceta
            // 
            this.bsReceta.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.Receta);
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReceta, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNombre.Location = new System.Drawing.Point(118, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCostoIndirectoMon
            // 
            this.txtCostoIndirectoMon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReceta, "CostoIndirecto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtCostoIndirectoMon.Enabled = false;
            this.txtCostoIndirectoMon.Location = new System.Drawing.Point(356, 233);
            this.txtCostoIndirectoMon.Name = "txtCostoIndirectoMon";
            this.txtCostoIndirectoMon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCostoIndirectoMon.Properties.Appearance.Options.UseFont = true;
            this.txtCostoIndirectoMon.Properties.Mask.EditMask = "n2";
            this.txtCostoIndirectoMon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCostoIndirectoMon.Size = new System.Drawing.Size(130, 20);
            this.txtCostoIndirectoMon.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReceta, "Descripcion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDescripcion.Location = new System.Drawing.Point(118, 65);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(368, 136);
            this.txtDescripcion.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Location = new System.Drawing.Point(12, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 322);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredientes";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bsIngredientesLista;
            this.gridControl1.Location = new System.Drawing.Point(7, 19);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(878, 268);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsIngredientesLista
            // 
            this.bsIngredientesLista.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.Ingrediente);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colId_MateriaPrima,
            this.colId_Receta,
            this.colCantidad,
            this.colMPNombre,
            this.colMPAbreviatura,
            this.colMPUnidad,
            this.colMPPrecio,
            this.colCostoNetoMP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId1
            // 
            this.colId1.Caption = "Id";
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.OptionsColumn.AllowEdit = false;
            this.colId1.OptionsColumn.ReadOnly = true;
            // 
            // colId_MateriaPrima
            // 
            this.colId_MateriaPrima.FieldName = "Id_MateriaPrima";
            this.colId_MateriaPrima.Name = "colId_MateriaPrima";
            this.colId_MateriaPrima.OptionsColumn.AllowEdit = false;
            this.colId_MateriaPrima.OptionsColumn.ReadOnly = true;
            // 
            // colId_Receta
            // 
            this.colId_Receta.FieldName = "Id_Receta";
            this.colId_Receta.Name = "colId_Receta";
            this.colId_Receta.OptionsColumn.AllowEdit = false;
            this.colId_Receta.OptionsColumn.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.OptionsColumn.ReadOnly = true;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 4;
            // 
            // colMPNombre
            // 
            this.colMPNombre.Caption = "Nombre";
            this.colMPNombre.FieldName = "MPNombre";
            this.colMPNombre.Name = "colMPNombre";
            this.colMPNombre.OptionsColumn.AllowEdit = false;
            this.colMPNombre.OptionsColumn.ReadOnly = true;
            this.colMPNombre.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MPNombre", "Total de Ingredientes: {0}")});
            this.colMPNombre.Visible = true;
            this.colMPNombre.VisibleIndex = 0;
            // 
            // colMPAbreviatura
            // 
            this.colMPAbreviatura.Caption = "Abreviatura";
            this.colMPAbreviatura.FieldName = "MPAbreviatura";
            this.colMPAbreviatura.Name = "colMPAbreviatura";
            this.colMPAbreviatura.OptionsColumn.AllowEdit = false;
            this.colMPAbreviatura.OptionsColumn.ReadOnly = true;
            this.colMPAbreviatura.Visible = true;
            this.colMPAbreviatura.VisibleIndex = 1;
            // 
            // colMPUnidad
            // 
            this.colMPUnidad.Caption = "Tipo Unidad";
            this.colMPUnidad.FieldName = "MPUnidad";
            this.colMPUnidad.Name = "colMPUnidad";
            this.colMPUnidad.OptionsColumn.AllowEdit = false;
            this.colMPUnidad.OptionsColumn.ReadOnly = true;
            this.colMPUnidad.Visible = true;
            this.colMPUnidad.VisibleIndex = 2;
            // 
            // colMPPrecio
            // 
            this.colMPPrecio.Caption = "Precio";
            this.colMPPrecio.FieldName = "MPPrecio";
            this.colMPPrecio.Name = "colMPPrecio";
            this.colMPPrecio.OptionsColumn.AllowEdit = false;
            this.colMPPrecio.OptionsColumn.ReadOnly = true;
            this.colMPPrecio.Visible = true;
            this.colMPPrecio.VisibleIndex = 3;
            // 
            // colCostoNetoMP
            // 
            this.colCostoNetoMP.Caption = "Costo Neto";
            this.colCostoNetoMP.FieldName = "CostoNetoMP";
            this.colCostoNetoMP.Name = "colCostoNetoMP";
            this.colCostoNetoMP.OptionsColumn.AllowEdit = false;
            this.colCostoNetoMP.OptionsColumn.ReadOnly = true;
            this.colCostoNetoMP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CostoNetoMP", "Total: {0:#.##}")});
            this.colCostoNetoMP.ToolTip = "Costo neto del ingrediente";
            this.colCostoNetoMP.Visible = true;
            this.colCostoNetoMP.VisibleIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(7, 293);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(88, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(828, 618);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(747, 618);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Acepar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtComensales
            // 
            this.txtComensales.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReceta, "CantidadComensales", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtComensales.Location = new System.Drawing.Point(356, 37);
            this.txtComensales.Name = "txtComensales";
            this.txtComensales.Properties.Mask.EditMask = "n0";
            this.txtComensales.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtComensales.Size = new System.Drawing.Size(130, 20);
            this.txtComensales.TabIndex = 2;
            // 
            // txtUtilidadesPorce
            // 
            this.txtUtilidadesPorce.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReceta, "UtilidadPorce", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtUtilidadesPorce.Location = new System.Drawing.Point(118, 259);
            this.txtUtilidadesPorce.Name = "txtUtilidadesPorce";
            this.txtUtilidadesPorce.Properties.Mask.EditMask = "n2";
            this.txtUtilidadesPorce.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUtilidadesPorce.Size = new System.Drawing.Size(130, 20);
            this.txtUtilidadesPorce.TabIndex = 7;
            this.txtUtilidadesPorce.ToolTip = "Porcentaje aplicado directamente sobre el costo neto + costo indirecto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio Final:";
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReceta, "PrecioFinal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtPrecioFinal.Enabled = false;
            this.txtPrecioFinal.Location = new System.Drawing.Point(356, 11);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPrecioFinal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPrecioFinal.Properties.Appearance.Options.UseFont = true;
            this.txtPrecioFinal.Properties.Appearance.Options.UseForeColor = true;
            this.txtPrecioFinal.Properties.Mask.EditMask = "n2";
            this.txtPrecioFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecioFinal.Size = new System.Drawing.Size(130, 20);
            this.txtPrecioFinal.TabIndex = 101;
            this.txtPrecioFinal.ToolTip = "Precio Final de venta de la receta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Costo Indirecto ($):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Utilidades ($):";
            // 
            // txtUtilidadesMon
            // 
            this.txtUtilidadesMon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReceta, "Utilidad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtUtilidadesMon.Enabled = false;
            this.txtUtilidadesMon.Location = new System.Drawing.Point(356, 259);
            this.txtUtilidadesMon.Name = "txtUtilidadesMon";
            this.txtUtilidadesMon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtUtilidadesMon.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtUtilidadesMon.Properties.Appearance.Options.UseFont = true;
            this.txtUtilidadesMon.Properties.Appearance.Options.UseForeColor = true;
            this.txtUtilidadesMon.Properties.Mask.EditMask = "n2";
            this.txtUtilidadesMon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUtilidadesMon.Size = new System.Drawing.Size(130, 20);
            this.txtUtilidadesMon.TabIndex = 8;
            // 
            // txtCostoIndirectoPorce
            // 
            this.txtCostoIndirectoPorce.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReceta, "CostoIndirectoPorce", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtCostoIndirectoPorce.Location = new System.Drawing.Point(118, 233);
            this.txtCostoIndirectoPorce.Name = "txtCostoIndirectoPorce";
            this.txtCostoIndirectoPorce.Properties.Mask.EditMask = "n2";
            this.txtCostoIndirectoPorce.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCostoIndirectoPorce.Size = new System.Drawing.Size(130, 20);
            this.txtCostoIndirectoPorce.TabIndex = 5;
            this.txtCostoIndirectoPorce.ToolTip = "Porcentaje que se aplica de manera directa sobre el costo neto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Costo Neto ($):";
            // 
            // txtCostoNetoMon
            // 
            this.txtCostoNetoMon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReceta, "CostoTotalIngredientes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtCostoNetoMon.Enabled = false;
            this.txtCostoNetoMon.Location = new System.Drawing.Point(118, 207);
            this.txtCostoNetoMon.Name = "txtCostoNetoMon";
            this.txtCostoNetoMon.Properties.Mask.EditMask = "n2";
            this.txtCostoNetoMon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCostoNetoMon.Size = new System.Drawing.Size(368, 20);
            this.txtCostoNetoMon.TabIndex = 4;
            this.txtCostoNetoMon.ToolTip = "Costo total de compra de los ingredientes";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // chartCompPrecio
            // 
            this.chartCompPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCompPrecio.DataBindings = null;
            this.chartCompPrecio.Legend.Name = "Default Legend";
            this.chartCompPrecio.Location = new System.Drawing.Point(492, 12);
            this.chartCompPrecio.Name = "chartCompPrecio";
            series1.LegendName = "Default Legend";
            series1.LegendTextPattern = "{A}:{VP:p0}";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.chartCompPrecio.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartCompPrecio.Size = new System.Drawing.Size(411, 267);
            this.chartCompPrecio.TabIndex = 25;
            // 
            // btnAyudaReceta
            // 
            this.btnAyudaReceta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyudaReceta.Image = ((System.Drawing.Image)(resources.GetObject("btnAyudaReceta.Image")));
            this.btnAyudaReceta.Location = new System.Drawing.Point(873, 252);
            this.btnAyudaReceta.Name = "btnAyudaReceta";
            this.btnAyudaReceta.Size = new System.Drawing.Size(24, 23);
            this.btnAyudaReceta.TabIndex = 102;
            this.btnAyudaReceta.UseVisualStyleBackColor = true;
            this.btnAyudaReceta.Click += new System.EventHandler(this.btnAyudaReceta_Click);
            // 
            // frmRecetasAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 654);
            this.Controls.Add(this.btnAyudaReceta);
            this.Controls.Add(this.chartCompPrecio);
            this.Controls.Add(this.txtCostoNetoMon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCostoIndirectoPorce);
            this.Controls.Add(this.txtUtilidadesMon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecioFinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtComensales);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtUtilidadesPorce);
            this.Controls.Add(this.txtCostoIndirectoMon);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecetasAddMod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle Receta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRecetasAddMod_FormClosing);
            this.Load += new System.EventHandler(this.frmRecetasAddMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReceta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoIndirectoMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIngredientesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComensales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadesPorce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadesMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoIndirectoPorce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoNetoMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtCostoIndirectoMon;
        private DevExpress.XtraEditors.MemoEdit txtDescripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.BindingSource bsReceta;
        private System.Windows.Forms.BindingSource bsIngredientesLista;
        private DevExpress.XtraEditors.TextEdit txtComensales;
        private DevExpress.XtraEditors.TextEdit txtUtilidadesPorce;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtPrecioFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtUtilidadesMon;
        private DevExpress.XtraEditors.TextEdit txtCostoIndirectoPorce;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtCostoNetoMon;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colId_MateriaPrima;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Receta;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colMPNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colMPAbreviatura;
        private DevExpress.XtraGrid.Columns.GridColumn colMPUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colMPPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoNetoMP;
        private DevExpress.XtraCharts.ChartControl chartCompPrecio;
        private System.Windows.Forms.Button btnAyudaReceta;
    }
}