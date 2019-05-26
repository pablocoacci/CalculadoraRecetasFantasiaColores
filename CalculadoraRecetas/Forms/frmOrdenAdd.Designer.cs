namespace CalculadoraRecetas.Forms
{
    partial class frmOrdenAdd
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsRecetasList = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadComensales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilidadPorce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoIndirectoPorce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoTotalIngredientes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoIndirecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecetasList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bsRecetasList;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1});
            this.gridControl1.Size = new System.Drawing.Size(471, 385);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsRecetasList
            // 
            this.bsRecetasList.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.Receta);
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
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
            // 
            // colCantidadComensales
            // 
            this.colCantidadComensales.Caption = "Comensales";
            this.colCantidadComensales.FieldName = "CantidadComensales";
            this.colCantidadComensales.Name = "colCantidadComensales";
            this.colCantidadComensales.OptionsColumn.AllowEdit = false;
            this.colCantidadComensales.OptionsColumn.ReadOnly = true;
            this.colCantidadComensales.Visible = true;
            this.colCantidadComensales.VisibleIndex = 1;
            // 
            // colUtilidadPorce
            // 
            this.colUtilidadPorce.Caption = "Utilidad (%)";
            this.colUtilidadPorce.FieldName = "UtilidadPorce";
            this.colUtilidadPorce.Name = "colUtilidadPorce";
            this.colUtilidadPorce.OptionsColumn.AllowEdit = false;
            this.colUtilidadPorce.OptionsColumn.ReadOnly = true;
            // 
            // colCostoIndirectoPorce
            // 
            this.colCostoIndirectoPorce.Caption = "Costo Ind. (%)";
            this.colCostoIndirectoPorce.FieldName = "CostoIndirectoPorce";
            this.colCostoIndirectoPorce.Name = "colCostoIndirectoPorce";
            this.colCostoIndirectoPorce.OptionsColumn.AllowEdit = false;
            this.colCostoIndirectoPorce.OptionsColumn.ReadOnly = true;
            // 
            // colCostoTotalIngredientes
            // 
            this.colCostoTotalIngredientes.Caption = "Costo Neto";
            this.colCostoTotalIngredientes.FieldName = "CostoTotalIngredientes";
            this.colCostoTotalIngredientes.Name = "colCostoTotalIngredientes";
            this.colCostoTotalIngredientes.OptionsColumn.AllowEdit = false;
            this.colCostoTotalIngredientes.OptionsColumn.ReadOnly = true;
            this.colCostoTotalIngredientes.Visible = true;
            this.colCostoTotalIngredientes.VisibleIndex = 2;
            // 
            // colCostoIndirecto
            // 
            this.colCostoIndirecto.Caption = "Costo Ind.";
            this.colCostoIndirecto.FieldName = "CostoIndirecto";
            this.colCostoIndirecto.Name = "colCostoIndirecto";
            this.colCostoIndirecto.OptionsColumn.AllowEdit = false;
            this.colCostoIndirecto.OptionsColumn.ReadOnly = true;
            this.colCostoIndirecto.Visible = true;
            this.colCostoIndirecto.VisibleIndex = 3;
            // 
            // colUtilidad
            // 
            this.colUtilidad.FieldName = "Utilidad";
            this.colUtilidad.Name = "colUtilidad";
            this.colUtilidad.OptionsColumn.AllowEdit = false;
            this.colUtilidad.OptionsColumn.ReadOnly = true;
            this.colUtilidad.Visible = true;
            this.colUtilidad.VisibleIndex = 4;
            // 
            // colPrecioFinal
            // 
            this.colPrecioFinal.FieldName = "PrecioFinal";
            this.colPrecioFinal.Name = "colPrecioFinal";
            this.colPrecioFinal.OptionsColumn.AllowEdit = false;
            this.colPrecioFinal.OptionsColumn.ReadOnly = true;
            this.colPrecioFinal.Visible = true;
            this.colPrecioFinal.VisibleIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.Location = new System.Drawing.Point(70, 403);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Properties.Mask.EditMask = "n0";
            this.txtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidad.Size = new System.Drawing.Size(413, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(408, 429);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(327, 429);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // frmOrdenAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 458);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrdenAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccionar una Receta";
            this.Load += new System.EventHandler(this.frmOrdenAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecetasList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtCantidad;
        private System.Windows.Forms.BindingSource bsRecetasList;
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}