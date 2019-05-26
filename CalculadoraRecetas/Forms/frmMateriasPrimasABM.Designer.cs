namespace CalculadoraRecetas.Forms
{
    partial class frmMateriasPrimasABM
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
            this.grdMateriasPrimas = new DevExpress.XtraGrid.GridControl();
            this.bsMateriasPrimasList = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbreviatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMateriasPrimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMateriasPrimasList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMateriasPrimas
            // 
            this.grdMateriasPrimas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMateriasPrimas.DataSource = this.bsMateriasPrimasList;
            this.grdMateriasPrimas.Location = new System.Drawing.Point(12, 12);
            this.grdMateriasPrimas.MainView = this.gridView1;
            this.grdMateriasPrimas.Name = "grdMateriasPrimas";
            this.grdMateriasPrimas.Size = new System.Drawing.Size(684, 379);
            this.grdMateriasPrimas.TabIndex = 0;
            this.grdMateriasPrimas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdMateriasPrimas.DoubleClick += new System.EventHandler(this.grdMateriasPrimas_DoubleClick);
            // 
            // bsMateriasPrimasList
            // 
            this.bsMateriasPrimasList.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.MateriaPrima);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNombre,
            this.colAbreviatura,
            this.colUnidadMedida,
            this.colPrecio});
            this.gridView1.GridControl = this.grdMateriasPrimas;
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
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.OptionsColumn.ReadOnly = true;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colAbreviatura
            // 
            this.colAbreviatura.FieldName = "Abreviatura";
            this.colAbreviatura.Name = "colAbreviatura";
            this.colAbreviatura.OptionsColumn.AllowEdit = false;
            this.colAbreviatura.OptionsColumn.ReadOnly = true;
            this.colAbreviatura.Visible = true;
            this.colAbreviatura.VisibleIndex = 2;
            // 
            // colUnidadMedida
            // 
            this.colUnidadMedida.FieldName = "UnidadMedida";
            this.colUnidadMedida.Name = "colUnidadMedida";
            this.colUnidadMedida.OptionsColumn.AllowEdit = false;
            this.colUnidadMedida.OptionsColumn.ReadOnly = true;
            this.colUnidadMedida.Visible = true;
            this.colUnidadMedida.VisibleIndex = 3;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.AllowEdit = false;
            this.colPrecio.OptionsColumn.ReadOnly = true;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(621, 397);
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
            this.btnModificar.Location = new System.Drawing.Point(540, 397);
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
            this.btnNuevo.Location = new System.Drawing.Point(459, 397);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmMateriasPrimasABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 427);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grdMateriasPrimas);
            this.Name = "frmMateriasPrimasABM";
            this.Text = "frmMateriasPrimasABM";
            this.Load += new System.EventHandler(this.frmMateriasPrimasABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMateriasPrimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMateriasPrimasList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdMateriasPrimas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsMateriasPrimasList;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colAbreviatura;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
    }
}