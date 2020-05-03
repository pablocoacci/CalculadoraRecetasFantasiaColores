namespace CalculadoraRecetas.Forms
{
    partial class frmPedidosAddMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidosAddMod));
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.bsPedido = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtGananciaTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecioFinalSugerido = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsOrdenesLista = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreReceta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoIndirectoTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoTotalMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGananciaTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Receta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.bsClientesLista = new System.Windows.Forms.BindingSource(this.components);
            this.cboClientes = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCostoMP = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCostoInd = new DevExpress.XtraEditors.TextEdit();
            this.btnVerCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstado = new DevExpress.XtraEditors.TextEdit();
            this.btnEntragarPedido = new System.Windows.Forms.Button();
            this.btnAbortarPedido = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNotas = new DevExpress.XtraEditors.MemoEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGananciaTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioFinalSugerido.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdenesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClientes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoMP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoInd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Ingreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Entrega:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ganancia Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio Final Sugerido:";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPedido, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(101, 12);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Mask.EditMask = "n0";
            this.txtId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtId.Size = new System.Drawing.Size(115, 20);
            this.txtId.TabIndex = 6;
            // 
            // bsPedido
            // 
            this.bsPedido.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.Pedido);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPedido, "FechaPedido", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtpFechaIngreso.Enabled = false;
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(101, 38);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(115, 20);
            this.dtpFechaIngreso.TabIndex = 7;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(101, 64);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(115, 20);
            this.dtpFechaEntrega.TabIndex = 9;
            // 
            // txtGananciaTotal
            // 
            this.txtGananciaTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPedido, "GananciaTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtGananciaTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPedido, "GananciaTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtGananciaTotal.Enabled = false;
            this.txtGananciaTotal.Location = new System.Drawing.Point(599, 164);
            this.txtGananciaTotal.Name = "txtGananciaTotal";
            this.txtGananciaTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtGananciaTotal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtGananciaTotal.Properties.Appearance.Options.UseFont = true;
            this.txtGananciaTotal.Properties.Appearance.Options.UseForeColor = true;
            this.txtGananciaTotal.Properties.Mask.EditMask = "n2";
            this.txtGananciaTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGananciaTotal.Size = new System.Drawing.Size(115, 20);
            this.txtGananciaTotal.TabIndex = 11;
            this.txtGananciaTotal.ToolTip = "Ganancia total del pedido";
            // 
            // txtPrecioFinalSugerido
            // 
            this.txtPrecioFinalSugerido.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPedido, "PrecioVentaSugerido", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtPrecioFinalSugerido.Enabled = false;
            this.txtPrecioFinalSugerido.Location = new System.Drawing.Point(599, 48);
            this.txtPrecioFinalSugerido.Name = "txtPrecioFinalSugerido";
            this.txtPrecioFinalSugerido.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPrecioFinalSugerido.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPrecioFinalSugerido.Properties.Appearance.Options.UseFont = true;
            this.txtPrecioFinalSugerido.Properties.Appearance.Options.UseForeColor = true;
            this.txtPrecioFinalSugerido.Properties.Mask.EditMask = "n2";
            this.txtPrecioFinalSugerido.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecioFinalSugerido.Size = new System.Drawing.Size(115, 20);
            this.txtPrecioFinalSugerido.TabIndex = 12;
            this.txtPrecioFinalSugerido.ToolTip = "Precio total final de venta del pedido";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 289);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenes";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(92, 260);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(11, 260);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bsOrdenesLista;
            this.gridControl1.Location = new System.Drawing.Point(11, 19);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(688, 235);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsOrdenesLista
            // 
            this.bsOrdenesLista.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.Orden);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNombreReceta,
            this.colFormula,
            this.colCantidad,
            this.colCostoIndirectoTotal,
            this.colCostoTotalMP,
            this.colGananciaTotal,
            this.colPrecioTotal,
            this.colId_Receta});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // colNombreReceta
            // 
            this.colNombreReceta.Caption = "Receta";
            this.colNombreReceta.FieldName = "NombreReceta";
            this.colNombreReceta.Name = "colNombreReceta";
            this.colNombreReceta.OptionsColumn.AllowEdit = false;
            this.colNombreReceta.Visible = true;
            this.colNombreReceta.VisibleIndex = 0;
            this.colNombreReceta.Width = 114;
            // 
            // colFormula
            // 
            this.colFormula.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colFormula.FieldName = "Formula";
            this.colFormula.Name = "colFormula";
            this.colFormula.OptionsColumn.ReadOnly = true;
            this.colFormula.ToolTip = "(Abreviatura - Cantidad - Precio)";
            this.colFormula.Visible = true;
            this.colFormula.VisibleIndex = 1;
            this.colFormula.Width = 57;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.OptionsColumn.ReadOnly = true;
            this.colCantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", "Total: {0}")});
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            this.colCantidad.Width = 115;
            // 
            // colCostoIndirectoTotal
            // 
            this.colCostoIndirectoTotal.Caption = "Costo Ind.";
            this.colCostoIndirectoTotal.FieldName = "CostoIndirectoTotal";
            this.colCostoIndirectoTotal.Name = "colCostoIndirectoTotal";
            this.colCostoIndirectoTotal.OptionsColumn.AllowEdit = false;
            this.colCostoIndirectoTotal.OptionsColumn.ReadOnly = true;
            this.colCostoIndirectoTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CostoIndirectoTotal", "Total: {0:#.##}")});
            this.colCostoIndirectoTotal.ToolTip = "Costo Indirecto Total de la orden";
            this.colCostoIndirectoTotal.Visible = true;
            this.colCostoIndirectoTotal.VisibleIndex = 3;
            this.colCostoIndirectoTotal.Width = 98;
            // 
            // colCostoTotalMP
            // 
            this.colCostoTotalMP.Caption = "Costo MP";
            this.colCostoTotalMP.FieldName = "CostoTotalMP";
            this.colCostoTotalMP.Name = "colCostoTotalMP";
            this.colCostoTotalMP.OptionsColumn.AllowEdit = false;
            this.colCostoTotalMP.OptionsColumn.ReadOnly = true;
            this.colCostoTotalMP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CostoTotalMP", "Total: {0:#.##}")});
            this.colCostoTotalMP.ToolTip = "Costo de materias primas de la orden";
            this.colCostoTotalMP.Visible = true;
            this.colCostoTotalMP.VisibleIndex = 4;
            this.colCostoTotalMP.Width = 95;
            // 
            // colGananciaTotal
            // 
            this.colGananciaTotal.Caption = "Ganancia";
            this.colGananciaTotal.FieldName = "GananciaTotal";
            this.colGananciaTotal.Name = "colGananciaTotal";
            this.colGananciaTotal.OptionsColumn.AllowEdit = false;
            this.colGananciaTotal.OptionsColumn.ReadOnly = true;
            this.colGananciaTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GananciaTotal", "Total: {0:#.##}")});
            this.colGananciaTotal.ToolTip = "Ganancia total de la orden";
            this.colGananciaTotal.Visible = true;
            this.colGananciaTotal.VisibleIndex = 5;
            this.colGananciaTotal.Width = 85;
            // 
            // colPrecioTotal
            // 
            this.colPrecioTotal.FieldName = "PrecioTotal";
            this.colPrecioTotal.Name = "colPrecioTotal";
            this.colPrecioTotal.OptionsColumn.AllowEdit = false;
            this.colPrecioTotal.OptionsColumn.ReadOnly = true;
            this.colPrecioTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrecioTotal", "Total: {0:#.##}")});
            this.colPrecioTotal.ToolTip = "Precio final de venta de la orden";
            this.colPrecioTotal.Visible = true;
            this.colPrecioTotal.VisibleIndex = 6;
            this.colPrecioTotal.Width = 106;
            // 
            // colId_Receta
            // 
            this.colId_Receta.FieldName = "Id_Receta";
            this.colId_Receta.Name = "colId_Receta";
            this.colId_Receta.OptionsColumn.AllowEdit = false;
            this.colId_Receta.OptionsColumn.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(642, 485);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(561, 485);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // bsClientesLista
            // 
            this.bsClientesLista.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.Cliente);
            // 
            // cboClientes
            // 
            this.cboClientes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPedido, "Id_Cliente", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.cboClientes.Location = new System.Drawing.Point(101, 90);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClientes.Properties.DataSource = this.bsClientesLista;
            this.cboClientes.Properties.DisplayMember = "Nombre";
            this.cboClientes.Properties.NullText = "";
            this.cboClientes.Properties.PopupFormMinSize = new System.Drawing.Size(750, 300);
            this.cboClientes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboClientes.Properties.ValueMember = "Id";
            this.cboClientes.Properties.View = this.gridLookUpEdit1View;
            this.cboClientes.Size = new System.Drawing.Size(285, 20);
            this.cboClientes.TabIndex = 16;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colNombre,
            this.colTelefono,
            this.colCelular,
            this.colDireccion,
            this.colMail});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.MaxWidth = 40;
            this.colId1.MinWidth = 40;
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            this.colId1.Width = 40;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.MaxWidth = 300;
            this.colNombre.MinWidth = 300;
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 300;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.MaxWidth = 125;
            this.colTelefono.MinWidth = 125;
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 2;
            this.colTelefono.Width = 125;
            // 
            // colCelular
            // 
            this.colCelular.FieldName = "Celular";
            this.colCelular.MaxWidth = 125;
            this.colCelular.MinWidth = 125;
            this.colCelular.Name = "colCelular";
            this.colCelular.Visible = true;
            this.colCelular.VisibleIndex = 3;
            this.colCelular.Width = 125;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.MaxWidth = 400;
            this.colDireccion.MinWidth = 400;
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 4;
            this.colDireccion.Width = 400;
            // 
            // colMail
            // 
            this.colMail.FieldName = "Mail";
            this.colMail.MaxWidth = 200;
            this.colMail.MinWidth = 200;
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 5;
            this.colMail.Width = 200;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Costo MP:";
            // 
            // txtCostoMP
            // 
            this.txtCostoMP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPedido, "PercioMPTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtCostoMP.Enabled = false;
            this.txtCostoMP.Location = new System.Drawing.Point(599, 85);
            this.txtCostoMP.Name = "txtCostoMP";
            this.txtCostoMP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCostoMP.Properties.Appearance.Options.UseFont = true;
            this.txtCostoMP.Size = new System.Drawing.Size(115, 20);
            this.txtCostoMP.TabIndex = 18;
            this.txtCostoMP.ToolTip = "Costo de materia primas total de todas las ordenes del pedido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Costo Ind:";
            // 
            // txtCostoInd
            // 
            this.txtCostoInd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPedido, "CostoIndirectoTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtCostoInd.Enabled = false;
            this.txtCostoInd.Location = new System.Drawing.Point(599, 125);
            this.txtCostoInd.Name = "txtCostoInd";
            this.txtCostoInd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCostoInd.Properties.Appearance.Options.UseFont = true;
            this.txtCostoInd.Size = new System.Drawing.Size(115, 20);
            this.txtCostoInd.TabIndex = 20;
            this.txtCostoInd.ToolTip = "Costo indirecto total sumarizado de todas las orden del pedido";
            // 
            // btnVerCliente
            // 
            this.btnVerCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnVerCliente.Image")));
            this.btnVerCliente.Location = new System.Drawing.Point(392, 88);
            this.btnVerCliente.Name = "btnVerCliente";
            this.btnVerCliente.Size = new System.Drawing.Size(23, 22);
            this.btnVerCliente.TabIndex = 21;
            this.btnVerCliente.UseVisualStyleBackColor = true;
            this.btnVerCliente.Click += new System.EventHandler(this.btnVerCliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPedido, "EstadoStr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(271, 12);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtEstado.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtEstado.Properties.Appearance.Options.UseFont = true;
            this.txtEstado.Properties.Appearance.Options.UseForeColor = true;
            this.txtEstado.Properties.Mask.EditMask = "n0";
            this.txtEstado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEstado.Size = new System.Drawing.Size(115, 20);
            this.txtEstado.TabIndex = 23;
            // 
            // btnEntragarPedido
            // 
            this.btnEntragarPedido.Location = new System.Drawing.Point(271, 36);
            this.btnEntragarPedido.Name = "btnEntragarPedido";
            this.btnEntragarPedido.Size = new System.Drawing.Size(115, 23);
            this.btnEntragarPedido.TabIndex = 24;
            this.btnEntragarPedido.Text = "Entregar";
            this.btnEntragarPedido.UseVisualStyleBackColor = true;
            this.btnEntragarPedido.Click += new System.EventHandler(this.btnEntragar_Click);
            // 
            // btnAbortarPedido
            // 
            this.btnAbortarPedido.Location = new System.Drawing.Point(271, 61);
            this.btnAbortarPedido.Name = "btnAbortarPedido";
            this.btnAbortarPedido.Size = new System.Drawing.Size(115, 23);
            this.btnAbortarPedido.TabIndex = 25;
            this.btnAbortarPedido.Text = "Abortar";
            this.btnAbortarPedido.UseVisualStyleBackColor = true;
            this.btnAbortarPedido.Click += new System.EventHandler(this.btnAbortarPedido_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Notas:";
            // 
            // txtNotas
            // 
            this.txtNotas.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPedido, "Notas", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNotas.Location = new System.Drawing.Point(101, 116);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(285, 68);
            this.txtNotas.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(507, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Precio de Venta:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPedido, "PrecioVentaReal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtPrecioVenta.Location = new System.Drawing.Point(599, 13);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPrecioVenta.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtPrecioVenta.Properties.Appearance.Options.UseFont = true;
            this.txtPrecioVenta.Properties.Appearance.Options.UseForeColor = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(115, 20);
            this.txtPrecioVenta.TabIndex = 29;
            // 
            // frmPedidosAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 515);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAbortarPedido);
            this.Controls.Add(this.btnEntragarPedido);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnVerCliente);
            this.Controls.Add(this.txtCostoInd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCostoMP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrecioFinalSugerido);
            this.Controls.Add(this.txtGananciaTotal);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidosAddMod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle Pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPedidosAddMod_FormClosing);
            this.Load += new System.EventHandler(this.frmPedidosAddMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGananciaTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioFinalSugerido.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdenesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClientes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoMP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoInd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private DevExpress.XtraEditors.TextEdit txtGananciaTotal;
        private DevExpress.XtraEditors.TextEdit txtPrecioFinalSugerido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.BindingSource bsPedido;
        private System.Windows.Forms.BindingSource bsOrdenesLista;
        private System.Windows.Forms.BindingSource bsClientesLista;
        private DevExpress.XtraEditors.GridLookUpEdit cboClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreReceta;
        private DevExpress.XtraGrid.Columns.GridColumn colFormula;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colGananciaTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Receta;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoIndirectoTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoTotalMP;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtCostoMP;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtCostoInd;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private System.Windows.Forms.Button btnVerCliente;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtEstado;
        private System.Windows.Forms.Button btnEntragarPedido;
        private System.Windows.Forms.Button btnAbortarPedido;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.MemoEdit txtNotas;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtPrecioVenta;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}