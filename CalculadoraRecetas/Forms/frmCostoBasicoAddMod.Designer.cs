namespace CalculadoraRecetas.Forms
{
    partial class frmCostoBasicoAddMod
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCostosFijos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFechaCosto = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCostoTotal = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotas = new DevExpress.XtraEditors.MemoEdit();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkCostoFijo = new System.Windows.Forms.CheckBox();
            this.bsCostoBasico = new System.Windows.Forms.BindingSource(this.components);
            this.bsCostosFijosLista = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cboCostosFijos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostoBasico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostosFijosLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // cboCostosFijos
            // 
            this.cboCostosFijos.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoBasico, "IdCostoFijo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboCostosFijos.EditValue = "";
            this.cboCostosFijos.Location = new System.Drawing.Point(105, 87);
            this.cboCostosFijos.Name = "cboCostosFijos";
            this.cboCostosFijos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCostosFijos.Properties.DataSource = this.bsCostosFijosLista;
            this.cboCostosFijos.Properties.DisplayMember = "Nombre";
            this.cboCostosFijos.Properties.PopupView = this.gridLookUpEdit1View;
            this.cboCostosFijos.Properties.ValueMember = "Id";
            this.cboCostosFijos.Size = new System.Drawing.Size(200, 20);
            this.cboCostosFijos.TabIndex = 2;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoBasico, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNombre.Location = new System.Drawing.Point(105, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Costo Fijo:";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoBasico, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(105, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 20);
            this.txtId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha del Costo:";
            // 
            // dtFechaCosto
            // 
            this.dtFechaCosto.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCostoBasico, "FechaCosto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtFechaCosto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCosto.Location = new System.Drawing.Point(105, 38);
            this.dtFechaCosto.Name = "dtFechaCosto";
            this.dtFechaCosto.Size = new System.Drawing.Size(200, 20);
            this.dtFechaCosto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Costo Total:";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCostoBasico, "CostoFijo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtCostoTotal.Location = new System.Drawing.Point(105, 139);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Properties.Mask.EditMask = "n2";
            this.txtCostoTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCostoTotal.Size = new System.Drawing.Size(200, 20);
            this.txtCostoTotal.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Notas:";
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(311, 31);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(222, 128);
            this.txtNotas.TabIndex = 12;
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(461, 165);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 13;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(380, 165);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // chkCostoFijo
            // 
            this.chkCostoFijo.AutoSize = true;
            this.chkCostoFijo.Location = new System.Drawing.Point(105, 64);
            this.chkCostoFijo.Name = "chkCostoFijo";
            this.chkCostoFijo.Size = new System.Drawing.Size(87, 17);
            this.chkCostoFijo.TabIndex = 1;
            this.chkCostoFijo.Text = "Es Costo Fijo";
            this.chkCostoFijo.UseVisualStyleBackColor = true;
            // 
            // bsCostoBasico
            // 
            this.bsCostoBasico.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.CostoBasico);
            // 
            // bsCostosFijosLista
            // 
            this.bsCostosFijosLista.DataSource = typeof(CalculadoraRecetas.Clases.Dominio.CostoFijo);
            // 
            // frmCostoBasicoAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 196);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCostoTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFechaCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCostosFijos);
            this.Controls.Add(this.chkCostoFijo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(564, 235);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(564, 235);
            this.Name = "frmCostoBasicoAddMod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Costo Basico";
            ((System.ComponentModel.ISupportInitialize)(this.cboCostosFijos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostoBasico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostosFijosLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit cboCostosFijos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFechaCosto;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtCostoTotal;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.MemoEdit txtNotas;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.BindingSource bsCostoBasico;
        private System.Windows.Forms.BindingSource bsCostosFijosLista;
        private System.Windows.Forms.CheckBox chkCostoFijo;
    }
}