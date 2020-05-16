namespace CalculadoraRecetas.Forms
{
    partial class frmCostoMaterialesABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCostoMaterialesABM));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grdCostoMateriales = new DevExpress.XtraGrid.GridControl();
            this.bsCostoMateriales = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreMateriaPrima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMesCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpHastaCosto = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeCosto = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCostoMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostoMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(713, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(632, 415);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(551, 415);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grdCostoMateriales
            // 
            this.grdCostoMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCostoMateriales.DataSource = this.bsCostoMateriales;
            this.grdCostoMateriales.Location = new System.Drawing.Point(12, 55);
            this.grdCostoMateriales.MainView = this.gridView1;
            this.grdCostoMateriales.Name = "grdCostoMateriales";
            this.grdCostoMateriales.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1});
            this.grdCostoMateriales.Size = new System.Drawing.Size(776, 354);
            this.grdCostoMateriales.TabIndex = 4;
            this.grdCostoMateriales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdCostoMateriales.DoubleClick += new System.EventHandler(this.grdCostoMateriales_DoubleClick);
            // 
            // bsCostoMateriales
            // 
            this.bsCostoMateriales.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.CostoMateriales);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreMateriaPrima,
            this.colNombreProveedor,
            this.colFechaCompra,
            this.colMesCompra,
            this.colDetalle,
            this.colPrecioUnitario,
            this.colCantidad,
            this.colCostoTotal,
            this.colNotas});
            this.gridView1.GridControl = this.grdCostoMateriales;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colNombreMateriaPrima
            // 
            this.colNombreMateriaPrima.Caption = "Material";
            this.colNombreMateriaPrima.FieldName = "NombreMateriaPrima";
            this.colNombreMateriaPrima.Name = "colNombreMateriaPrima";
            this.colNombreMateriaPrima.OptionsColumn.AllowEdit = false;
            this.colNombreMateriaPrima.OptionsColumn.ReadOnly = true;
            this.colNombreMateriaPrima.Visible = true;
            this.colNombreMateriaPrima.VisibleIndex = 0;
            this.colNombreMateriaPrima.Width = 107;
            // 
            // colNombreProveedor
            // 
            this.colNombreProveedor.Caption = "Proveedor";
            this.colNombreProveedor.FieldName = "NombreProveedor";
            this.colNombreProveedor.Name = "colNombreProveedor";
            this.colNombreProveedor.OptionsColumn.AllowEdit = false;
            this.colNombreProveedor.OptionsColumn.ReadOnly = true;
            this.colNombreProveedor.Visible = true;
            this.colNombreProveedor.VisibleIndex = 1;
            this.colNombreProveedor.Width = 143;
            // 
            // colFechaCompra
            // 
            this.colFechaCompra.Caption = "Compra";
            this.colFechaCompra.FieldName = "FechaCompra";
            this.colFechaCompra.MaxWidth = 70;
            this.colFechaCompra.MinWidth = 70;
            this.colFechaCompra.Name = "colFechaCompra";
            this.colFechaCompra.OptionsColumn.AllowEdit = false;
            this.colFechaCompra.OptionsColumn.ReadOnly = true;
            this.colFechaCompra.Visible = true;
            this.colFechaCompra.VisibleIndex = 2;
            this.colFechaCompra.Width = 70;
            // 
            // colMesCompra
            // 
            this.colMesCompra.Caption = "Mes";
            this.colMesCompra.FieldName = "MesCompra";
            this.colMesCompra.Name = "colMesCompra";
            this.colMesCompra.OptionsColumn.AllowEdit = false;
            this.colMesCompra.OptionsColumn.ReadOnly = true;
            this.colMesCompra.Visible = true;
            this.colMesCompra.VisibleIndex = 3;
            this.colMesCompra.Width = 41;
            // 
            // colDetalle
            // 
            this.colDetalle.FieldName = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.OptionsColumn.AllowEdit = false;
            this.colDetalle.OptionsColumn.ReadOnly = true;
            this.colDetalle.Visible = true;
            this.colDetalle.VisibleIndex = 4;
            this.colDetalle.Width = 167;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.Caption = "Precio Uni.";
            this.colPrecioUnitario.FieldName = "PrecioUnitario";
            this.colPrecioUnitario.MaxWidth = 100;
            this.colPrecioUnitario.MinWidth = 50;
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.OptionsColumn.AllowEdit = false;
            this.colPrecioUnitario.OptionsColumn.ReadOnly = true;
            this.colPrecioUnitario.Visible = true;
            this.colPrecioUnitario.VisibleIndex = 5;
            this.colPrecioUnitario.Width = 50;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.MaxWidth = 100;
            this.colCantidad.MinWidth = 50;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.OptionsColumn.ReadOnly = true;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 6;
            this.colCantidad.Width = 52;
            // 
            // colCostoTotal
            // 
            this.colCostoTotal.FieldName = "CostoTotal";
            this.colCostoTotal.MaxWidth = 100;
            this.colCostoTotal.MinWidth = 70;
            this.colCostoTotal.Name = "colCostoTotal";
            this.colCostoTotal.OptionsColumn.AllowEdit = false;
            this.colCostoTotal.OptionsColumn.ReadOnly = true;
            this.colCostoTotal.Visible = true;
            this.colCostoTotal.VisibleIndex = 7;
            this.colCostoTotal.Width = 78;
            // 
            // colNotas
            // 
            this.colNotas.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colNotas.FieldName = "Notas";
            this.colNotas.MaxWidth = 50;
            this.colNotas.MinWidth = 50;
            this.colNotas.Name = "colNotas";
            this.colNotas.OptionsColumn.ReadOnly = true;
            this.colNotas.Visible = true;
            this.colNotas.VisibleIndex = 8;
            this.colNotas.Width = 50;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // btnProveedores
            // 
            this.btnProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProveedores.Location = new System.Drawing.Point(12, 415);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(75, 23);
            this.btnProveedores.TabIndex = 5;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAyuda);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dtpHastaCosto);
            this.groupBox1.Controls.Add(this.dtpDesdeCosto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 49);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(689, 15);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(24, 23);
            this.btnAyuda.TabIndex = 7;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(719, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpHastaCosto
            // 
            this.dtpHastaCosto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaCosto.Location = new System.Drawing.Point(217, 15);
            this.dtpHastaCosto.Name = "dtpHastaCosto";
            this.dtpHastaCosto.Size = new System.Drawing.Size(108, 20);
            this.dtpHastaCosto.TabIndex = 3;
            // 
            // dtpDesdeCosto
            // 
            this.dtpDesdeCosto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeCosto.Location = new System.Drawing.Point(59, 15);
            this.dtpDesdeCosto.Name = "dtpDesdeCosto";
            this.dtpDesdeCosto.Size = new System.Drawing.Size(108, 20);
            this.dtpDesdeCosto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // frmCostoMaterialesABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.grdCostoMateriales);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Name = "frmCostoMaterialesABM";
            this.Text = "frmCostoMaterialesABM";
            ((System.ComponentModel.ISupportInitialize)(this.grdCostoMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostoMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private DevExpress.XtraGrid.GridControl grdCostoMateriales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpHastaCosto;
        private System.Windows.Forms.DateTimePicker dtpDesdeCosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsCostoMateriales;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreMateriaPrima;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colMesCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colNotas;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}