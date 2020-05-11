using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Helpers;
using System;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmCostoMaterialesAddMod : Form
    {
        private IMessageManager _messageManager;
        private IObjectDAL<CostoMateriales> _costoMatDAL;
        private IObjectDAL<Proveedor> _proveedorDAL;
        private IObjectDAL<MateriaPrima> _materiaPrimaDAL;
        private CostoMateriales _costoMap = null;
        private bool closeOK = false;

        public frmCostoMaterialesAddMod(
            IMessageManager messageManager,
            IObjectDAL<CostoMateriales> costoMatDAL,
            IObjectDAL<Proveedor> proveedorDAL,
            IObjectDAL<MateriaPrima> materiaPrimaDAL)
        {
            InitializeComponent();

            _messageManager = messageManager;
            _costoMatDAL = costoMatDAL;
            _proveedorDAL = proveedorDAL;
            _materiaPrimaDAL = materiaPrimaDAL;
        }

        public void ConfigFormCostoMateriales(int id = 0)
        {
            if (id == 0)
            {
                _costoMap = new CostoMateriales();
                _costoMap.FechaCompra = DateTime.Now;
            }
            else
                _costoMap = _costoMatDAL.GetObjtById(id);
        }

        private void ResetearBindings()
        {
            bsCostoMaterial.DataSource = _costoMap;
            bsCostoMaterial.ResetBindings(true);
        }

        private void frmCostoMaterialesAddMod_Load(object sender, EventArgs e)
        {
            bsMateriaPrimaLista.DataSource = _materiaPrimaDAL.GetAllObj();
            bsProveedoresLista.DataSource = _proveedorDAL.GetAllObj();

            bsMateriaPrimaLista.ResetBindings(true);
            bsProveedoresLista.ResetBindings(true);
            ResetearBindings();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_costoMap.Notas))
                _costoMap.Notas = "";

            var error = _costoMatDAL.ValidSave(_costoMap);

            if(error != string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_costoMatDAL.Save(_costoMap))
                MessageBox.Show(_messageManager.SaveOK(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(_messageManager.SaveError(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            closeOK = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCostoMaterialesAddMod_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeOK)
            {
                if (MessageBox.Show(_messageManager.PerderanCambios(), _messageManager.AtencionTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
