namespace CalculadoraRecetas.Forms
{
    partial class frmRecetasABM
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
            this.bsRecetasList = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grdRecetasLista = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colCantidadComensales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilidadPorce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoIndirectoPorce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoTotalIngredientes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoIndirecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecetasList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecetasLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsRecetasList
            // 
            this.bsRecetasList.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.Receta);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(713, 402);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(632, 402);
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
            this.btnNuevo.Location = new System.Drawing.Point(551, 402);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grdRecetasLista
            // 
            this.grdRecetasLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRecetasLista.DataSource = this.bsRecetasList;
            this.grdRecetasLista.Location = new System.Drawing.Point(12, 12);
            this.grdRecetasLista.MainView = this.gridView1;
            this.grdRecetasLista.Name = "grdRecetasLista";
            this.grdRecetasLista.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1});
            this.grdRecetasLista.Size = new System.Drawing.Size(776, 384);
            this.grdRecetasLista.TabIndex = 4;
            this.grdRecetasLista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdRecetasLista.DoubleClick += new System.EventHandler(this.grdRecetasLista_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNombre,
            this.colDescripcion,
            this.colCantidadComensales,
            this.colUtilidadPorce,
            this.colCostoIndirectoPorce,
            this.colCostoTotalIngredientes,
            this.colCostoIndirecto,
            this.colUtilidad,
            this.colPrecioFinal});
            this.gridView1.GridControl = this.grdRecetasLista;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.OptionsColumn.ReadOnly = true;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colCantidadComensales
            // 
            this.colCantidadComensales.Caption = "Cant. Comen.";
            this.colCantidadComensales.FieldName = "CantidadComensales";
            this.colCantidadComensales.Name = "colCantidadComensales";
            this.colCantidadComensales.OptionsColumn.AllowEdit = false;
            this.colCantidadComensales.OptionsColumn.ReadOnly = true;
            this.colCantidadComensales.Visible = true;
            this.colCantidadComensales.VisibleIndex = 2;
            // 
            // colUtilidadPorce
            // 
            this.colUtilidadPorce.Caption = "Utilidad (%)";
            this.colUtilidadPorce.FieldName = "UtilidadPorce";
            this.colUtilidadPorce.Name = "colUtilidadPorce";
            this.colUtilidadPorce.OptionsColumn.AllowEdit = false;
            this.colUtilidadPorce.OptionsColumn.ReadOnly = true;
            this.colUtilidadPorce.Visible = true;
            this.colUtilidadPorce.VisibleIndex = 3;
            // 
            // colCostoIndirectoPorce
            // 
            this.colCostoIndirectoPorce.Caption = "Costo Ind. (%)";
            this.colCostoIndirectoPorce.FieldName = "CostoIndirectoPorce";
            this.colCostoIndirectoPorce.Name = "colCostoIndirectoPorce";
            this.colCostoIndirectoPorce.OptionsColumn.AllowEdit = false;
            this.colCostoIndirectoPorce.OptionsColumn.ReadOnly = true;
            this.colCostoIndirectoPorce.Visible = true;
            this.colCostoIndirectoPorce.VisibleIndex = 4;
            // 
            // colCostoTotalIngredientes
            // 
            this.colCostoTotalIngredientes.Caption = "Costo Neto ($)";
            this.colCostoTotalIngredientes.FieldName = "CostoTotalIngredientes";
            this.colCostoTotalIngredientes.Name = "colCostoTotalIngredientes";
            this.colCostoTotalIngredientes.OptionsColumn.AllowEdit = false;
            this.colCostoTotalIngredientes.OptionsColumn.ReadOnly = true;
            this.colCostoTotalIngredientes.Visible = true;
            this.colCostoTotalIngredientes.VisibleIndex = 5;
            // 
            // colCostoIndirecto
            // 
            this.colCostoIndirecto.Caption = "Costo Ind. ($)";
            this.colCostoIndirecto.FieldName = "CostoIndirecto";
            this.colCostoIndirecto.Name = "colCostoIndirecto";
            this.colCostoIndirecto.OptionsColumn.AllowEdit = false;
            this.colCostoIndirecto.OptionsColumn.ReadOnly = true;
            this.colCostoIndirecto.Visible = true;
            this.colCostoIndirecto.VisibleIndex = 6;
            // 
            // colUtilidad
            // 
            this.colUtilidad.Caption = "Utilidad ($)";
            this.colUtilidad.FieldName = "Utilidad";
            this.colUtilidad.Name = "colUtilidad";
            this.colUtilidad.OptionsColumn.AllowEdit = false;
            this.colUtilidad.OptionsColumn.ReadOnly = true;
            this.colUtilidad.Visible = true;
            this.colUtilidad.VisibleIndex = 7;
            // 
            // colPrecioFinal
            // 
            this.colPrecioFinal.Caption = "Precio Final ($)";
            this.colPrecioFinal.FieldName = "PrecioFinal";
            this.colPrecioFinal.Name = "colPrecioFinal";
            this.colPrecioFinal.OptionsColumn.AllowEdit = false;
            this.colPrecioFinal.OptionsColumn.ReadOnly = true;
            this.colPrecioFinal.Visible = true;
            this.colPrecioFinal.VisibleIndex = 8;
            // 
            // frmRecetasABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.grdRecetasLista);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Name = "frmRecetasABM";
            this.Text = "frmRecetasABM";
            this.Load += new System.EventHandler(this.frmRecetasABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRecetasList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecetasLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsRecetasList;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private DevExpress.XtraGrid.GridControl grdRecetasLista;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadComensales;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilidadPorce;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoIndirectoPorce;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoTotalIngredientes;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoIndirecto;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioFinal;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}