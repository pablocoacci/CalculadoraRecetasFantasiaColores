namespace CalculadoraRecetas
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMateriasPrimas = new DevExpress.XtraBars.BarButtonItem();
            this.btnRecetas = new DevExpress.XtraBars.BarButtonItem();
            this.btnClientes = new DevExpress.XtraBars.BarButtonItem();
            this.btnPedidos = new DevExpress.XtraBars.BarButtonItem();
            this.btnEstadisticas = new DevExpress.XtraBars.BarButtonItem();
            this.btnCostosMateriles = new DevExpress.XtraBars.BarButtonItem();
            this.btnCostoServicios = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnMateriasPrimas,
            this.btnRecetas,
            this.btnClientes,
            this.btnPedidos,
            this.btnEstadisticas,
            this.btnCostosMateriles,
            this.btnCostoServicios});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1058, 141);
            // 
            // btnMateriasPrimas
            // 
            this.btnMateriasPrimas.Caption = "Materias Primas";
            this.btnMateriasPrimas.Id = 1;
            this.btnMateriasPrimas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMateriasPrimas.ImageOptions.Image")));
            this.btnMateriasPrimas.Name = "btnMateriasPrimas";
            this.btnMateriasPrimas.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnMateriasPrimas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMateriasPrimas_ItemClick);
            // 
            // btnRecetas
            // 
            this.btnRecetas.Caption = "Recetas";
            this.btnRecetas.Id = 2;
            this.btnRecetas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRecetas.ImageOptions.Image")));
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnRecetas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRecetas_ItemClick);
            // 
            // btnClientes
            // 
            this.btnClientes.Caption = "Clientes";
            this.btnClientes.Id = 3;
            this.btnClientes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.ImageOptions.Image")));
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClientes_ItemClick);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Caption = "Pedidos";
            this.btnPedidos.Id = 4;
            this.btnPedidos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.ImageOptions.Image")));
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnPedidos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPedidos_ItemClick);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Caption = "Estadistica";
            this.btnEstadisticas.Id = 5;
            this.btnEstadisticas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEstadisticas.ImageOptions.Image")));
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnEstadisticas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEstadisticas_ItemClick);
            // 
            // btnCostosMateriles
            // 
            this.btnCostosMateriles.Caption = "Materiales";
            this.btnCostosMateriles.Id = 6;
            this.btnCostosMateriles.Name = "btnCostosMateriles";
            this.btnCostosMateriles.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnCostosMateriles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCostosMateriles_ItemClick);
            // 
            // btnCostoServicios
            // 
            this.btnCostoServicios.Caption = "Servicios";
            this.btnCostoServicios.Id = 7;
            this.btnCostoServicios.Name = "btnCostoServicios";
            this.btnCostoServicios.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnCostoServicios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCostoServicios_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Modulos";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMateriasPrimas);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRecetas);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClientes);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPedidos);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEstadisticas);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Costos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCostosMateriles);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCostoServicios);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 141);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1058, 569);
            this.panelPrincipal.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 710);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Calculadora Receta";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnMateriasPrimas;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnRecetas;
        private System.Windows.Forms.Panel panelPrincipal;
        private DevExpress.XtraBars.BarButtonItem btnClientes;
        private DevExpress.XtraBars.BarButtonItem btnPedidos;
        private DevExpress.XtraBars.BarButtonItem btnEstadisticas;
        private DevExpress.XtraBars.BarButtonItem btnCostosMateriles;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnCostoServicios;
    }
}

