using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Helpers;
using System;
using System.Windows.Forms;
using System.Linq;

namespace CalculadoraRecetas.Forms
{
    public partial class frmCostoMaterialesABM : Form
    {
        private frmCostoMaterialesAddMod _costosMaterialesAddMod;
        private frmProveedoresMateriales _proveedoresAddMod;
        private IMessageManager _messageManager;
        private IObjectDAL<CostoMateriales> _costoMatDAL;

        public frmCostoMaterialesABM(
            frmCostoMaterialesAddMod costosMaterialesAddMod,
            frmProveedoresMateriales proveedoresAddMod,
            IMessageManager messageManager,
            IObjectDAL<CostoMateriales> costoMatDAL)
        {
            InitializeComponent();

            _costosMaterialesAddMod = costosMaterialesAddMod;
            _proveedoresAddMod = proveedoresAddMod;
            _messageManager = messageManager;
            _costoMatDAL = costoMatDAL;
        }

        private void ModificarCliente()
        {
            var costoMat = (CostoMateriales)bsCostoMateriales.Current;
            _costosMaterialesAddMod.ConfigFormCostoMateriales(costoMat.Id);
            _costosMaterialesAddMod.ShowDialog();
            ResetBinding();
        }

        private void ResetBinding()
        {
            var dtDesde = new DateTime(dtpDesdeCosto.Value.Year, dtpDesdeCosto.Value.Month, dtpDesdeCosto.Value.Day);
            var dtHasta = new DateTime(dtpHastaCosto.Value.Year, dtpHastaCosto.Value.Month, dtpHastaCosto.Value.Day);
            _costoMatDAL.ResetContext();

            if (dtHasta < dtDesde)
            {
                MessageBox.Show(_messageManager.ErrorDesdeMayorAHasta(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            bsCostoMateriales.DataSource = _costoMatDAL.GetContext().CostoMateriales.Where(a => dtDesde <= a.FechaCompra && a.FechaCompra <= dtHasta).ToList();

            bsCostoMateriales.ResetBindings(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _costosMaterialesAddMod.ConfigFormCostoMateriales();
            _costosMaterialesAddMod.ShowDialog();
            ResetBinding();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            _proveedoresAddMod.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCliente();
        }

        private void grdCostoMateriales_DoubleClick(object sender, EventArgs e)
        {
            ModificarCliente();
        }
    }
}
