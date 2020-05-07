using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using System;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmOrdenAdd : Form
    {
        private IObjectDAL<Receta> _recDAL;
        public Receta _recetaSelected = null;
        public int _cant = -1;

        public frmOrdenAdd(IObjectDAL<Receta> recDAL)
        {
            InitializeComponent();

            _recDAL = recDAL;
        }

        private void frmOrdenAdd_Load(object sender, EventArgs e)
        {
            txtCantidad.EditValue = 0;
            bsRecetasList.DataSource = _recDAL.GetAllObj();
            bsRecetasList.ResetBindings(true);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _recetaSelected = (Receta)bsRecetasList.Current;
            _cant = Convert.ToInt32(txtCantidad.EditValue);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
