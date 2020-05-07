using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Helpers;
using System;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmClientesABM : Form
    {
        private IObjectDAL<Cliente> _clieDAL;
        private frmClienteAddMod _frmClienteAddMod;
        private IMessageManager _messageManager;

        public frmClientesABM(IObjectDAL<Cliente> clieDAL, IMessageManager messageManager, frmClienteAddMod frmClienteAddMod)
        {
            InitializeComponent();

            _clieDAL = clieDAL;
            _frmClienteAddMod = frmClienteAddMod;
            _messageManager = messageManager;
        }

        private void ResetBinding()
        {
            _clieDAL.ResetContext();
            bsClientesLista.DataSource = _clieDAL.GetAllObj();
            bsClientesLista.ResetBindings(true);
        }

        private void ModificarCliente()
        {
            var clie = (Cliente)bsClientesLista.Current;

            _frmClienteAddMod.ConfigureFormCliente(clie.Id);
            _frmClienteAddMod.ShowDialog();

            ResetBinding();
        }

        private void frmClientesABM_Load(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _frmClienteAddMod.ConfigureFormCliente();
            _frmClienteAddMod.ShowDialog();
            ResetBinding();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCliente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_messageManager.EliminarAdvertencia(), _messageManager.AtencionTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var clie = (Cliente)bsClientesLista.Current;
            var error = _clieDAL.ValidDelete(clie);

            if(error!=string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_clieDAL.Delete(clie))
                MessageBox.Show(_messageManager.EliminarOK(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(_messageManager.EliminarError(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            ResetBinding();
        }

        private void grdClientes_DoubleClick(object sender, EventArgs e)
        {
            ModificarCliente();
        }
    }
}
