using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Helpers;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmCostoServiciosABM : Form
    {
        private frmCostoServicioAddMod _costosServicioAddMod;
        private frmServicios _serviciosAddMod;
        private IMessageManager _messageManager;
        private IObjectDAL<CostoServicio> _costoServicioDAL;

        public frmCostoServiciosABM(
            frmCostoServicioAddMod costosServicioAddMod,
            frmServicios serviciosAddMod,
            IMessageManager messageManager,
            IObjectDAL<CostoServicio> costoServiciosDAL)
        {
            InitializeComponent();

            _costosServicioAddMod = costosServicioAddMod;
            _serviciosAddMod = serviciosAddMod;
            _messageManager = messageManager;
            _costoServicioDAL = costoServiciosDAL;
        }

        private void MoficarCosto()
        {
            var costoServ = (CostoServicio)bsCostoServicios.Current;
            _costosServicioAddMod.ConfigFormCostoServicio(costoServ.Id);
            _costosServicioAddMod.ShowDialog();
            ResetBinding();
        }

        private void ResetBinding()
        {
            var dtDesde = new DateTime(dtpDesdeCosto.Value.Year, dtpDesdeCosto.Value.Month, dtpDesdeCosto.Value.Day);
            var dtHasta = new DateTime(dtpHastaCosto.Value.Year, dtpHastaCosto.Value.Month, dtpHastaCosto.Value.Day);
            _costoServicioDAL.ResetContext();

            if (dtHasta < dtDesde)
            {
                MessageBox.Show(_messageManager.ErrorDesdeMayorAHasta(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bsCostoServicios.DataSource = _costoServicioDAL.GetContext().CostoServicios.Where(a => dtDesde <= a.FechaCreacion && a.FechaCreacion <= dtHasta).ToList();
            bsCostoServicios.ResetBindings(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _costosServicioAddMod.ConfigFormCostoServicio();
            _costosServicioAddMod.ShowDialog();
            ResetBinding();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            _serviciosAddMod.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MoficarCosto();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            MoficarCosto();
        }
    }
}
