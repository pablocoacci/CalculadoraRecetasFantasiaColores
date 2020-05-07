using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Helpers;
using System;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmRecetasABM : Form
    {
        private IObjectDAL<Receta> _recDAL;
        private frmRecetasAddMod _frmRecetaAddMod;
        private IMessageManager _messageManager;

        public frmRecetasABM(IObjectDAL<Receta> recDAL, frmRecetasAddMod frmRecetaAddMod, IMessageManager messageManager)
        {
            InitializeComponent();

            _recDAL = recDAL;
            _frmRecetaAddMod = frmRecetaAddMod;
            _messageManager = messageManager;
        }

        private void ReceteBinding()
        {
            _recDAL.ResetContext();
            bsRecetasList.DataSource = _recDAL.GetAllObj();
            bsRecetasList.ResetBindings(true);
        }

        private void ModificarReceta()
        {
            var receta = (Receta)bsRecetasList.Current;
            _frmRecetaAddMod.ConfigFormReceta(receta.Id);
            _frmRecetaAddMod.ShowDialog();
            ReceteBinding();
        }

        private void frmRecetasABM_Load(object sender, EventArgs e)
        {
            ReceteBinding();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarReceta();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _frmRecetaAddMod.ConfigFormReceta();
            _frmRecetaAddMod.ShowDialog();
            ReceteBinding();
        }

        private void grdRecetasLista_DoubleClick(object sender, EventArgs e)
        {
            ModificarReceta();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_messageManager.EliminarAdvertencia(), _messageManager.AtencionTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var rec = (Receta)bsRecetasList.Current;
            var error = _recDAL.ValidDelete(rec);

            if (error != string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_recDAL.Delete(rec))
                MessageBox.Show(_messageManager.EliminarOK(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(_messageManager.EliminarError(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            ReceteBinding();
        }
    }
}
