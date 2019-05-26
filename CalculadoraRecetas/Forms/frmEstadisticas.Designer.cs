namespace CalculadoraRecetas.Forms
{
    partial class frmEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticas));
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.charVentasMes = new DevExpress.XtraCharts.ChartControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAyudaTab1 = new System.Windows.Forms.Button();
            this.btnGenerarUtilidadesMes = new System.Windows.Forms.Button();
            this.dtpHastaUtilidadesMes = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesdeUtilidadesMes = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.charUtilidadProd = new DevExpress.XtraCharts.ChartControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAyuda2 = new System.Windows.Forms.Button();
            this.txtTotalUtilidadesPord = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUtilidadProd = new System.Windows.Forms.Button();
            this.dtpHastaUtilidadProd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDesdeUtilidadProd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.charCantVtasProd = new DevExpress.XtraCharts.ChartControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAyuda3 = new System.Windows.Forms.Button();
            this.txtCantVtasProd = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCantVtasProd = new System.Windows.Forms.Button();
            this.dtpHastaCantVtasProd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDesdeCantVtasProd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.charHistorialProd = new DevExpress.XtraCharts.ChartControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAyuda4 = new System.Windows.Forms.Button();
            this.chkHistorialProdUtilidades = new System.Windows.Forms.CheckBox();
            this.chkHistorialProdVentas = new System.Windows.Forms.CheckBox();
            this.chkHistorialProdCantidad = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHistorialProd = new System.Windows.Forms.Button();
            this.dtpHastaHistorialProd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDesdeHistorialProd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cboHistorialProd = new DevExpress.XtraEditors.LookUpEdit();
            this.bsRecetasCombo = new System.Windows.Forms.BindingSource(this.components);
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charVentasMes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charUtilidadProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalUtilidadesPord.Properties)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charCantVtasProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantVtasProd.Properties)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charHistorialProd)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboHistorialProd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecetasCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Controls.Add(this.tabPage3);
            this.tab1.Controls.Add(this.tabPage4);
            this.tab1.Location = new System.Drawing.Point(12, 12);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(776, 426);
            this.tab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.charVentasMes);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vtas x Mes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // charVentasMes
            // 
            this.charVentasMes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charVentasMes.DataBindings = null;
            this.charVentasMes.Legend.Name = "Default Legend";
            this.charVentasMes.Location = new System.Drawing.Point(6, 56);
            this.charVentasMes.Name = "charVentasMes";
            this.charVentasMes.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.charVentasMes.Size = new System.Drawing.Size(756, 338);
            this.charVentasMes.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAyudaTab1);
            this.groupBox1.Controls.Add(this.btnGenerarUtilidadesMes);
            this.groupBox1.Controls.Add(this.dtpHastaUtilidadesMes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDesdeUtilidadesMes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAyudaTab1
            // 
            this.btnAyudaTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyudaTab1.Image = ((System.Drawing.Image)(resources.GetObject("btnAyudaTab1.Image")));
            this.btnAyudaTab1.Location = new System.Drawing.Point(651, 14);
            this.btnAyudaTab1.Name = "btnAyudaTab1";
            this.btnAyudaTab1.Size = new System.Drawing.Size(24, 23);
            this.btnAyudaTab1.TabIndex = 8;
            this.btnAyudaTab1.UseVisualStyleBackColor = true;
            this.btnAyudaTab1.Click += new System.EventHandler(this.btnAyudaTab1_Click);
            // 
            // btnGenerarUtilidadesMes
            // 
            this.btnGenerarUtilidadesMes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerarUtilidadesMes.Location = new System.Drawing.Point(681, 14);
            this.btnGenerarUtilidadesMes.Name = "btnGenerarUtilidadesMes";
            this.btnGenerarUtilidadesMes.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarUtilidadesMes.TabIndex = 4;
            this.btnGenerarUtilidadesMes.Text = "Generar";
            this.btnGenerarUtilidadesMes.UseVisualStyleBackColor = true;
            this.btnGenerarUtilidadesMes.Click += new System.EventHandler(this.btnGenerarUtilidadesMes_Click);
            // 
            // dtpHastaUtilidadesMes
            // 
            this.dtpHastaUtilidadesMes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaUtilidadesMes.Location = new System.Drawing.Point(212, 14);
            this.dtpHastaUtilidadesMes.Name = "dtpHastaUtilidadesMes";
            this.dtpHastaUtilidadesMes.Size = new System.Drawing.Size(108, 20);
            this.dtpHastaUtilidadesMes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // dtpDesdeUtilidadesMes
            // 
            this.dtpDesdeUtilidadesMes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeUtilidadesMes.Location = new System.Drawing.Point(54, 14);
            this.dtpDesdeUtilidadesMes.Name = "dtpDesdeUtilidadesMes";
            this.dtpDesdeUtilidadesMes.Size = new System.Drawing.Size(108, 20);
            this.dtpDesdeUtilidadesMes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.charUtilidadProd);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Utilidades x Prod.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // charUtilidadProd
            // 
            this.charUtilidadProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charUtilidadProd.DataBindings = null;
            this.charUtilidadProd.Legend.Name = "Default Legend";
            this.charUtilidadProd.Location = new System.Drawing.Point(4, 56);
            this.charUtilidadProd.Name = "charUtilidadProd";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.charUtilidadProd.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.charUtilidadProd.Size = new System.Drawing.Size(762, 338);
            this.charUtilidadProd.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAyuda2);
            this.groupBox2.Controls.Add(this.txtTotalUtilidadesPord);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnUtilidadProd);
            this.groupBox2.Controls.Add(this.dtpHastaUtilidadProd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpDesdeUtilidadProd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnAyuda2
            // 
            this.btnAyuda2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda2.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda2.Image")));
            this.btnAyuda2.Location = new System.Drawing.Point(651, 14);
            this.btnAyuda2.Name = "btnAyuda2";
            this.btnAyuda2.Size = new System.Drawing.Size(24, 23);
            this.btnAyuda2.TabIndex = 9;
            this.btnAyuda2.UseVisualStyleBackColor = true;
            this.btnAyuda2.Click += new System.EventHandler(this.btnAyuda2_Click);
            // 
            // txtTotalUtilidadesPord
            // 
            this.txtTotalUtilidadesPord.Enabled = false;
            this.txtTotalUtilidadesPord.Location = new System.Drawing.Point(416, 14);
            this.txtTotalUtilidadesPord.Name = "txtTotalUtilidadesPord";
            this.txtTotalUtilidadesPord.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalUtilidadesPord.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtTotalUtilidadesPord.Properties.Appearance.Options.UseFont = true;
            this.txtTotalUtilidadesPord.Properties.Appearance.Options.UseForeColor = true;
            this.txtTotalUtilidadesPord.Size = new System.Drawing.Size(100, 20);
            this.txtTotalUtilidadesPord.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Utilidades:";
            // 
            // btnUtilidadProd
            // 
            this.btnUtilidadProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUtilidadProd.Location = new System.Drawing.Point(681, 14);
            this.btnUtilidadProd.Name = "btnUtilidadProd";
            this.btnUtilidadProd.Size = new System.Drawing.Size(75, 23);
            this.btnUtilidadProd.TabIndex = 4;
            this.btnUtilidadProd.Text = "Generar";
            this.btnUtilidadProd.UseVisualStyleBackColor = true;
            this.btnUtilidadProd.Click += new System.EventHandler(this.btnUtilidadProd_Click);
            // 
            // dtpHastaUtilidadProd
            // 
            this.dtpHastaUtilidadProd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaUtilidadProd.Location = new System.Drawing.Point(212, 14);
            this.dtpHastaUtilidadProd.Name = "dtpHastaUtilidadProd";
            this.dtpHastaUtilidadProd.Size = new System.Drawing.Size(108, 20);
            this.dtpHastaUtilidadProd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta:";
            // 
            // dtpDesdeUtilidadProd
            // 
            this.dtpDesdeUtilidadProd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeUtilidadProd.Location = new System.Drawing.Point(54, 14);
            this.dtpDesdeUtilidadProd.Name = "dtpDesdeUtilidadProd";
            this.dtpDesdeUtilidadProd.Size = new System.Drawing.Size(108, 20);
            this.dtpDesdeUtilidadProd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Desde:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.charCantVtasProd);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cant. Vtas. x Prod.";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // charCantVtasProd
            // 
            this.charCantVtasProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charCantVtasProd.DataBindings = null;
            this.charCantVtasProd.Legend.Name = "Default Legend";
            this.charCantVtasProd.Location = new System.Drawing.Point(3, 53);
            this.charCantVtasProd.Name = "charCantVtasProd";
            series2.Name = "Series 1";
            series2.View = pieSeriesView2;
            this.charCantVtasProd.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.charCantVtasProd.Size = new System.Drawing.Size(765, 344);
            this.charCantVtasProd.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAyuda3);
            this.groupBox3.Controls.Add(this.txtCantVtasProd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnCantVtasProd);
            this.groupBox3.Controls.Add(this.dtpHastaCantVtasProd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtpDesdeCantVtasProd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(768, 47);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnAyuda3
            // 
            this.btnAyuda3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda3.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda3.Image")));
            this.btnAyuda3.Location = new System.Drawing.Point(657, 14);
            this.btnAyuda3.Name = "btnAyuda3";
            this.btnAyuda3.Size = new System.Drawing.Size(24, 23);
            this.btnAyuda3.TabIndex = 9;
            this.btnAyuda3.UseVisualStyleBackColor = true;
            this.btnAyuda3.Click += new System.EventHandler(this.btnAyuda3_Click);
            // 
            // txtCantVtasProd
            // 
            this.txtCantVtasProd.Enabled = false;
            this.txtCantVtasProd.Location = new System.Drawing.Point(418, 14);
            this.txtCantVtasProd.Name = "txtCantVtasProd";
            this.txtCantVtasProd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCantVtasProd.Properties.Appearance.Options.UseFont = true;
            this.txtCantVtasProd.Size = new System.Drawing.Size(100, 20);
            this.txtCantVtasProd.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total Cant. Vtas:";
            // 
            // btnCantVtasProd
            // 
            this.btnCantVtasProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCantVtasProd.Location = new System.Drawing.Point(687, 14);
            this.btnCantVtasProd.Name = "btnCantVtasProd";
            this.btnCantVtasProd.Size = new System.Drawing.Size(75, 23);
            this.btnCantVtasProd.TabIndex = 4;
            this.btnCantVtasProd.Text = "Generar";
            this.btnCantVtasProd.UseVisualStyleBackColor = true;
            this.btnCantVtasProd.Click += new System.EventHandler(this.btnCantVtasProd_Click);
            // 
            // dtpHastaCantVtasProd
            // 
            this.dtpHastaCantVtasProd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaCantVtasProd.Location = new System.Drawing.Point(212, 14);
            this.dtpHastaCantVtasProd.Name = "dtpHastaCantVtasProd";
            this.dtpHastaCantVtasProd.Size = new System.Drawing.Size(108, 20);
            this.dtpHastaCantVtasProd.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hasta:";
            // 
            // dtpDesdeCantVtasProd
            // 
            this.dtpDesdeCantVtasProd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeCantVtasProd.Location = new System.Drawing.Point(54, 14);
            this.dtpDesdeCantVtasProd.Name = "dtpDesdeCantVtasProd";
            this.dtpDesdeCantVtasProd.Size = new System.Drawing.Size(108, 20);
            this.dtpDesdeCantVtasProd.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Desde:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.charHistorialProd);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Historial Prod.";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // charHistorialProd
            // 
            this.charHistorialProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charHistorialProd.DataBindings = null;
            this.charHistorialProd.Legend.Name = "Default Legend";
            this.charHistorialProd.Location = new System.Drawing.Point(0, 72);
            this.charHistorialProd.Name = "charHistorialProd";
            this.charHistorialProd.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.charHistorialProd.Size = new System.Drawing.Size(767, 325);
            this.charHistorialProd.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAyuda4);
            this.groupBox4.Controls.Add(this.chkHistorialProdUtilidades);
            this.groupBox4.Controls.Add(this.chkHistorialProdVentas);
            this.groupBox4.Controls.Add(this.chkHistorialProdCantidad);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btnHistorialProd);
            this.groupBox4.Controls.Add(this.dtpHastaHistorialProd);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.dtpDesdeHistorialProd);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cboHistorialProd);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(768, 66);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btnAyuda4
            // 
            this.btnAyuda4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda4.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda4.Image")));
            this.btnAyuda4.Location = new System.Drawing.Point(657, 23);
            this.btnAyuda4.Name = "btnAyuda4";
            this.btnAyuda4.Size = new System.Drawing.Size(24, 23);
            this.btnAyuda4.TabIndex = 10;
            this.btnAyuda4.UseVisualStyleBackColor = true;
            this.btnAyuda4.Click += new System.EventHandler(this.btnAyuda4_Click);
            // 
            // chkHistorialProdUtilidades
            // 
            this.chkHistorialProdUtilidades.AutoSize = true;
            this.chkHistorialProdUtilidades.Location = new System.Drawing.Point(211, 41);
            this.chkHistorialProdUtilidades.Name = "chkHistorialProdUtilidades";
            this.chkHistorialProdUtilidades.Size = new System.Drawing.Size(99, 17);
            this.chkHistorialProdUtilidades.TabIndex = 9;
            this.chkHistorialProdUtilidades.Text = "Total Utilidades";
            this.chkHistorialProdUtilidades.UseVisualStyleBackColor = true;
            // 
            // chkHistorialProdVentas
            // 
            this.chkHistorialProdVentas.AutoSize = true;
            this.chkHistorialProdVentas.Location = new System.Drawing.Point(128, 41);
            this.chkHistorialProdVentas.Name = "chkHistorialProdVentas";
            this.chkHistorialProdVentas.Size = new System.Drawing.Size(77, 17);
            this.chkHistorialProdVentas.TabIndex = 8;
            this.chkHistorialProdVentas.Text = "Total Vtas.";
            this.chkHistorialProdVentas.UseVisualStyleBackColor = true;
            // 
            // chkHistorialProdCantidad
            // 
            this.chkHistorialProdCantidad.AutoSize = true;
            this.chkHistorialProdCantidad.Checked = true;
            this.chkHistorialProdCantidad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHistorialProdCantidad.Location = new System.Drawing.Point(54, 41);
            this.chkHistorialProdCantidad.Name = "chkHistorialProdCantidad";
            this.chkHistorialProdCantidad.Size = new System.Drawing.Size(68, 17);
            this.chkHistorialProdCantidad.TabIndex = 7;
            this.chkHistorialProdCantidad.Text = "Cantidad";
            this.chkHistorialProdCantidad.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Receta:";
            // 
            // btnHistorialProd
            // 
            this.btnHistorialProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHistorialProd.Location = new System.Drawing.Point(687, 23);
            this.btnHistorialProd.Name = "btnHistorialProd";
            this.btnHistorialProd.Size = new System.Drawing.Size(75, 23);
            this.btnHistorialProd.TabIndex = 4;
            this.btnHistorialProd.Text = "Generar";
            this.btnHistorialProd.UseVisualStyleBackColor = true;
            this.btnHistorialProd.Click += new System.EventHandler(this.btnHistorialProd_Click);
            // 
            // dtpHastaHistorialProd
            // 
            this.dtpHastaHistorialProd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaHistorialProd.Location = new System.Drawing.Point(212, 14);
            this.dtpHastaHistorialProd.Name = "dtpHastaHistorialProd";
            this.dtpHastaHistorialProd.Size = new System.Drawing.Size(108, 20);
            this.dtpHastaHistorialProd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hasta:";
            // 
            // dtpDesdeHistorialProd
            // 
            this.dtpDesdeHistorialProd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeHistorialProd.Location = new System.Drawing.Point(54, 14);
            this.dtpDesdeHistorialProd.Name = "dtpDesdeHistorialProd";
            this.dtpDesdeHistorialProd.Size = new System.Drawing.Size(108, 20);
            this.dtpDesdeHistorialProd.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Desde:";
            // 
            // cboHistorialProd
            // 
            this.cboHistorialProd.Location = new System.Drawing.Point(378, 14);
            this.cboHistorialProd.Name = "cboHistorialProd";
            this.cboHistorialProd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHistorialProd.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 47, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboHistorialProd.Properties.DataSource = this.bsRecetasCombo;
            this.cboHistorialProd.Properties.DisplayMember = "Nombre";
            this.cboHistorialProd.Properties.NullText = "";
            this.cboHistorialProd.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboHistorialProd.Properties.PopupSizeable = false;
            this.cboHistorialProd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboHistorialProd.Properties.ValueMember = "Id";
            this.cboHistorialProd.Size = new System.Drawing.Size(137, 20);
            this.cboHistorialProd.TabIndex = 6;
            // 
            // bsRecetasCombo
            // 
            this.bsRecetasCombo.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.Receta);
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab1);
            this.Name = "frmEstadisticas";
            this.Text = "frmEstadisticas";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charVentasMes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charUtilidadProd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalUtilidadesPord.Properties)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charCantVtasProd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantVtasProd.Properties)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charHistorialProd)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboHistorialProd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecetasCombo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerarUtilidadesMes;
        private System.Windows.Forms.DateTimePicker dtpHastaUtilidadesMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesdeUtilidadesMes;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraCharts.ChartControl charVentasMes;
        private DevExpress.XtraCharts.ChartControl charUtilidadProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUtilidadProd;
        private System.Windows.Forms.DateTimePicker dtpHastaUtilidadProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDesdeUtilidadProd;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtTotalUtilidadesPord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraCharts.ChartControl charCantVtasProd;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.TextEdit txtCantVtasProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCantVtasProd;
        private System.Windows.Forms.DateTimePicker dtpHastaCantVtasProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDesdeCantVtasProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHistorialProd;
        private System.Windows.Forms.DateTimePicker dtpHastaHistorialProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDesdeHistorialProd;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.LookUpEdit cboHistorialProd;
        private System.Windows.Forms.BindingSource bsRecetasCombo;
        private DevExpress.XtraCharts.ChartControl charHistorialProd;
        private System.Windows.Forms.CheckBox chkHistorialProdUtilidades;
        private System.Windows.Forms.CheckBox chkHistorialProdVentas;
        private System.Windows.Forms.CheckBox chkHistorialProdCantidad;
        private System.Windows.Forms.Button btnAyudaTab1;
        private System.Windows.Forms.Button btnAyuda2;
        private System.Windows.Forms.Button btnAyuda3;
        private System.Windows.Forms.Button btnAyuda4;
    }
}