using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Helpers;
using System;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmMateriasPrimasABM : Form
    {
        private IObjectDAL<MateriaPrima> _mpDAL;
        private frmMateriasPrimasAddMod _frmMPAddMod;
        private IMessageManager _messageManager;

        public frmMateriasPrimasABM(IObjectDAL<MateriaPrima> mpDal, frmMateriasPrimasAddMod frmMPAddMod, IMessageManager messageManager)
        {
            InitializeComponent();

            _mpDAL = mpDal;
            _frmMPAddMod = frmMPAddMod;
            _messageManager = messageManager;
        }

        private void RefreshBindings()
        {
            _mpDAL.ResetContext();
            var mpList = _mpDAL.GetAllObj();
            bsMateriasPrimasList.DataSource = mpList;
            bsMateriasPrimasList.ResetBindings(true);
        }

        private void ModificarMP()
        {
            var mpSelected = (MateriaPrima)bsMateriasPrimasList.Current;
            _frmMPAddMod.ConfigFormMateriaPrima(mpSelected.Id);
            _frmMPAddMod.ShowDialog();
            RefreshBindings();
        }

        private void NuevaMP()
        {
            _frmMPAddMod.ConfigFormMateriaPrima();
            _frmMPAddMod.ShowDialog();
            RefreshBindings();
        }

        private void frmMateriasPrimasABM_Load(object sender, EventArgs e)
        {
            RefreshBindings();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarMP();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaMP();
        }

        private void grdMateriasPrimas_DoubleClick(object sender, EventArgs e)
        {
            ModificarMP();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_messageManager.EliminarAdvertencia(), _messageManager.AtencionTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var mp = (MateriaPrima)bsMateriasPrimasList.Current;
            var error = _mpDAL.ValidDelete(mp);

            if(error!=string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_mpDAL.Delete(mp))
                MessageBox.Show(_messageManager.EliminarOK(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(_messageManager.EliminarError(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            RefreshBindings();
        }
    }
}
