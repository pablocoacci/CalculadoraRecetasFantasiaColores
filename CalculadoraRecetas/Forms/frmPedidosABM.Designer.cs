namespace CalculadoraRecetas.Forms
{
    partial class frmPedidosABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidosABM));
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.bsPedidosLista = new System.Windows.Forms.BindingSource(this.components);
            this.grdPedidos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccionCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelularCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMailCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGananciaTota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioFinalTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoFecha = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpHastaPedido = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdePedido = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsClientes
            // 
            this.bsClientes.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.Cliente);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(713, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(632, 415);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
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
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // bsPedidosLista
            // 
            this.bsPedidosLista.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.Pedido);
            // 
            // grdPedidos
            // 
            this.grdPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPedidos.DataSource = this.bsPedidosLista;
            this.grdPedidos.Location = new System.Drawing.Point(0, 55);
            this.grdPedidos.MainView = this.gridView1;
            this.grdPedidos.Name = "grdPedidos";
            this.grdPedidos.Size = new System.Drawing.Size(800, 354);
            this.grdPedidos.TabIndex = 8;
            this.grdPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdPedidos.DoubleClick += new System.EventHandler(this.grdPedidos_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colId_Cliente,
            this.colFechaPedido,
            this.colFechaEntrega,
            this.colNombreCliente,
            this.colDireccionCliente,
            this.colTelefonoCliente,
            this.colCelularCliente,
            this.colMailCliente,
            this.colGananciaTota,
            this.colPrecioFinalTotal,
            this.colEstadoStr});
            this.gridView1.GridControl = this.grdPedidos;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEstadoStr, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            // colId_Cliente
            // 
            this.colId_Cliente.FieldName = "Id_Cliente";
            this.colId_Cliente.Name = "colId_Cliente";
            this.colId_Cliente.OptionsColumn.AllowEdit = false;
            this.colId_Cliente.OptionsColumn.ReadOnly = true;
            // 
            // colFechaPedido
            // 
            this.colFechaPedido.FieldName = "FechaPedido";
            this.colFechaPedido.Name = "colFechaPedido";
            this.colFechaPedido.OptionsColumn.AllowEdit = false;
            this.colFechaPedido.OptionsColumn.ReadOnly = true;
            this.colFechaPedido.Visible = true;
            this.colFechaPedido.VisibleIndex = 1;
            // 
            // colFechaEntrega
            // 
            this.colFechaEntrega.FieldName = "FechaEntrega";
            this.colFechaEntrega.Name = "colFechaEntrega";
            this.colFechaEntrega.OptionsColumn.AllowEdit = false;
            this.colFechaEntrega.OptionsColumn.ReadOnly = true;
            this.colFechaEntrega.Visible = true;
            this.colFechaEntrega.VisibleIndex = 2;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.Caption = "Nombre";
            this.colNombreCliente.FieldName = "NombreCliente";
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.OptionsColumn.AllowEdit = false;
            this.colNombreCliente.OptionsColumn.ReadOnly = true;
            this.colNombreCliente.Visible = true;
            this.colNombreCliente.VisibleIndex = 3;
            // 
            // colDireccionCliente
            // 
            this.colDireccionCliente.Caption = "Direccion";
            this.colDireccionCliente.FieldName = "DireccionCliente";
            this.colDireccionCliente.Name = "colDireccionCliente";
            this.colDireccionCliente.OptionsColumn.AllowEdit = false;
            this.colDireccionCliente.OptionsColumn.ReadOnly = true;
            // 
            // colTelefonoCliente
            // 
            this.colTelefonoCliente.Caption = "Telefono";
            this.colTelefonoCliente.FieldName = "TelefonoCliente";
            this.colTelefonoCliente.Name = "colTelefonoCliente";
            this.colTelefonoCliente.OptionsColumn.AllowEdit = false;
            this.colTelefonoCliente.OptionsColumn.ReadOnly = true;
            this.colTelefonoCliente.Visible = true;
            this.colTelefonoCliente.VisibleIndex = 4;
            // 
            // colCelularCliente
            // 
            this.colCelularCliente.Caption = "Celular";
            this.colCelularCliente.FieldName = "CelularCliente";
            this.colCelularCliente.Name = "colCelularCliente";
            this.colCelularCliente.OptionsColumn.AllowEdit = false;
            this.colCelularCliente.OptionsColumn.ReadOnly = true;
            this.colCelularCliente.Visible = true;
            this.colCelularCliente.VisibleIndex = 5;
            // 
            // colMailCliente
            // 
            this.colMailCliente.Caption = "Mail";
            this.colMailCliente.FieldName = "MailCliente";
            this.colMailCliente.Name = "colMailCliente";
            this.colMailCliente.OptionsColumn.AllowEdit = false;
            this.colMailCliente.OptionsColumn.ReadOnly = true;
            this.colMailCliente.Visible = true;
            this.colMailCliente.VisibleIndex = 6;
            // 
            // colGananciaTota
            // 
            this.colGananciaTota.Caption = "Ganancia Total";
            this.colGananciaTota.FieldName = "GananciaTota";
            this.colGananciaTota.Name = "colGananciaTota";
            this.colGananciaTota.OptionsColumn.AllowEdit = false;
            this.colGananciaTota.OptionsColumn.ReadOnly = true;
            this.colGananciaTota.Visible = true;
            this.colGananciaTota.VisibleIndex = 7;
            // 
            // colPrecioFinalTotal
            // 
            this.colPrecioFinalTotal.Caption = "Precio Total";
            this.colPrecioFinalTotal.FieldName = "PrecioFinalTotal";
            this.colPrecioFinalTotal.Name = "colPrecioFinalTotal";
            this.colPrecioFinalTotal.OptionsColumn.AllowEdit = false;
            this.colPrecioFinalTotal.OptionsColumn.ReadOnly = true;
            this.colPrecioFinalTotal.Visible = true;
            this.colPrecioFinalTotal.VisibleIndex = 8;
            // 
            // colEstadoStr
            // 
            this.colEstadoStr.Caption = "Estado";
            this.colEstadoStr.FieldName = "EstadoStr";
            this.colEstadoStr.Name = "colEstadoStr";
            this.colEstadoStr.OptionsColumn.AllowEdit = false;
            this.colEstadoStr.OptionsColumn.ReadOnly = true;
            this.colEstadoStr.Visible = true;
            this.colEstadoStr.VisibleIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAyuda);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboTipoFecha);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dtpHastaPedido);
            this.groupBox1.Controls.Add(this.dtpDesdePedido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 49);
            this.groupBox1.TabIndex = 9;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo Fecha:";
            // 
            // cboTipoFecha
            // 
            this.cboTipoFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFecha.FormattingEnabled = true;
            this.cboTipoFecha.Items.AddRange(new object[] {
            "Fecha Pedido",
            "Fecha Entrega",
            "Ninguna"});
            this.cboTipoFecha.Location = new System.Drawing.Point(401, 15);
            this.cboTipoFecha.Name = "cboTipoFecha";
            this.cboTipoFecha.Size = new System.Drawing.Size(121, 21);
            this.cboTipoFecha.TabIndex = 5;
            this.cboTipoFecha.SelectedIndexChanged += new System.EventHandler(this.cboTipoFecha_SelectedIndexChanged);
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
            // dtpHastaPedido
            // 
            this.dtpHastaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaPedido.Location = new System.Drawing.Point(217, 15);
            this.dtpHastaPedido.Name = "dtpHastaPedido";
            this.dtpHastaPedido.Size = new System.Drawing.Size(108, 20);
            this.dtpHastaPedido.TabIndex = 3;
            // 
            // dtpDesdePedido
            // 
            this.dtpDesdePedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdePedido.Location = new System.Drawing.Point(59, 15);
            this.dtpDesdePedido.Name = "dtpDesdePedido";
            this.dtpDesdePedido.Size = new System.Drawing.Size(108, 20);
            this.dtpDesdePedido.TabIndex = 2;
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
            // frmPedidosABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdPedidos);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Name = "frmPedidosABM";
            this.Text = "frmPedidosABM";
            this.Load += new System.EventHandler(this.frmPedidosABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsClientes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.BindingSource bsPedidosLista;
        private DevExpress.XtraGrid.GridControl grdPedidos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccionCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colCelularCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colMailCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colGananciaTota;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioFinalTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoStr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpHastaPedido;
        private System.Windows.Forms.DateTimePicker dtpDesdePedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoFecha;
        private System.Windows.Forms.Button btnAyuda;
    }
}