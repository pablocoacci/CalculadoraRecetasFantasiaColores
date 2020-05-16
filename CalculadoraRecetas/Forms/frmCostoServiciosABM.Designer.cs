namespace CalculadoraRecetas.Forms
{
    partial class frmCostoServiciosABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCostoServiciosABM));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsCostoServicios = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHorasLaborablesMensual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncidenciaPorce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMesCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpHastaCosto = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeCosto = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostoServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bsCostoServicios;
            this.gridControl1.Location = new System.Drawing.Point(12, 55);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1});
            this.gridControl1.Size = new System.Drawing.Size(776, 354);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // bsCostoServicios
            // 
            this.bsCostoServicios.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.CostoServicio);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreServicio,
            this.colFechaCreacion,
            this.colPrecioFactura,
            this.colHorasLaborablesMensual,
            this.colIncidenciaPorce,
            this.colCostoTotal,
            this.colMesCreacion,
            this.colNotas});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colNombreServicio
            // 
            this.colNombreServicio.FieldName = "NombreServicio";
            this.colNombreServicio.Name = "colNombreServicio";
            this.colNombreServicio.OptionsColumn.AllowEdit = false;
            this.colNombreServicio.OptionsColumn.ReadOnly = true;
            this.colNombreServicio.Visible = true;
            this.colNombreServicio.VisibleIndex = 0;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.OptionsColumn.AllowEdit = false;
            this.colFechaCreacion.OptionsColumn.ReadOnly = true;
            this.colFechaCreacion.Visible = true;
            this.colFechaCreacion.VisibleIndex = 1;
            // 
            // colPrecioFactura
            // 
            this.colPrecioFactura.FieldName = "PrecioFactura";
            this.colPrecioFactura.Name = "colPrecioFactura";
            this.colPrecioFactura.OptionsColumn.AllowEdit = false;
            this.colPrecioFactura.OptionsColumn.ReadOnly = true;
            this.colPrecioFactura.Visible = true;
            this.colPrecioFactura.VisibleIndex = 3;
            // 
            // colHorasLaborablesMensual
            // 
            this.colHorasLaborablesMensual.Caption = "Horas Trabajadas";
            this.colHorasLaborablesMensual.FieldName = "HorasLaborablesMensual";
            this.colHorasLaborablesMensual.Name = "colHorasLaborablesMensual";
            this.colHorasLaborablesMensual.OptionsColumn.AllowEdit = false;
            this.colHorasLaborablesMensual.OptionsColumn.ReadOnly = true;
            this.colHorasLaborablesMensual.Visible = true;
            this.colHorasLaborablesMensual.VisibleIndex = 4;
            // 
            // colIncidenciaPorce
            // 
            this.colIncidenciaPorce.FieldName = "IncidenciaPorce";
            this.colIncidenciaPorce.Name = "colIncidenciaPorce";
            this.colIncidenciaPorce.OptionsColumn.AllowEdit = false;
            this.colIncidenciaPorce.OptionsColumn.ReadOnly = true;
            this.colIncidenciaPorce.Visible = true;
            this.colIncidenciaPorce.VisibleIndex = 5;
            // 
            // colCostoTotal
            // 
            this.colCostoTotal.FieldName = "CostoTotal";
            this.colCostoTotal.Name = "colCostoTotal";
            this.colCostoTotal.OptionsColumn.AllowEdit = false;
            this.colCostoTotal.OptionsColumn.ReadOnly = true;
            this.colCostoTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CostoTotal", "Total: {0:#.##}")});
            this.colCostoTotal.Visible = true;
            this.colCostoTotal.VisibleIndex = 6;
            // 
            // colMesCreacion
            // 
            this.colMesCreacion.Caption = "Mes";
            this.colMesCreacion.FieldName = "MesCreacion";
            this.colMesCreacion.Name = "colMesCreacion";
            this.colMesCreacion.OptionsColumn.AllowEdit = false;
            this.colMesCreacion.OptionsColumn.ReadOnly = true;
            this.colMesCreacion.Visible = true;
            this.colMesCreacion.VisibleIndex = 2;
            // 
            // colNotas
            // 
            this.colNotas.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colNotas.FieldName = "Notas";
            this.colNotas.Name = "colNotas";
            this.colNotas.Visible = true;
            this.colNotas.VisibleIndex = 7;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
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
            this.groupBox1.TabIndex = 11;
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
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(551, 415);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(632, 415);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(713, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProveedores.Location = new System.Drawing.Point(12, 415);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(75, 23);
            this.btnProveedores.TabIndex = 15;
            this.btnProveedores.Text = "Servicios";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // frmCostoServiciosABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmCostoServiciosABM";
            this.Text = "frmCostoServiciosABM";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostoServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpHastaCosto;
        private System.Windows.Forms.DateTimePicker dtpDesdeCosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.BindingSource bsCostoServicios;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colHorasLaborablesMensual;
        private DevExpress.XtraGrid.Columns.GridColumn colIncidenciaPorce;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colMesCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNotas;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}