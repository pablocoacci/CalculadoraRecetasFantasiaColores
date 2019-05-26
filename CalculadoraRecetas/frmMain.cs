using CalculadoraRecetas.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraRecetas
{
    public partial class frmMain : Form
    {
        private frmMateriasPrimasABM _frmMpABM;
        private frmRecetasABM _frmRecetaABM;
        private frmClientesABM _frmClienteABM;
        private frmPedidosABM _frmPedidos;
        private frmEstadisticas _frmEstadistica;

        public frmMain(frmMateriasPrimasABM frmMpABM, frmRecetasABM frmRecetaABM, frmClientesABM frmClienteABM, frmPedidosABM frmPedidos, frmEstadisticas frmEstadistica)
        {
            InitializeComponent();

            _frmMpABM = frmMpABM;
            _frmRecetaABM = frmRecetaABM;
            _frmClienteABM = frmClienteABM;
            _frmPedidos = frmPedidos;
            _frmEstadistica = frmEstadistica;
        }

        private void AddFormInPanel(Form fh, string modulo)
        {
            this.Text = "Calculadora Receta - " + modulo;
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }

        private void btnMateriasPrimas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddFormInPanel(_frmMpABM, "Materias Primas");
        }

        private void btnRecetas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddFormInPanel(_frmRecetaABM, "Recetas");
        }

        private void btnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddFormInPanel(_frmClienteABM, "Clientes");
        }

        private void btnPedidos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddFormInPanel(_frmPedidos, "Pedidos");
        }

        private void btnEstadisticas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddFormInPanel(_frmEstadistica, "Estadistica");
        }
    }
}
