using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using System;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmIngredienteAdd : Form
    {
        private IObjectDAL<MateriaPrima> _mpDAL;
        public int _materiaPrimaId = -1;
        public decimal _cantidad = -1;

        public frmIngredienteAdd(IObjectDAL<MateriaPrima> mpDAL)
        {
            InitializeComponent();

            _mpDAL = mpDAL;
        }

        private void frmIngredienteAdd_Load(object sender, EventArgs e)
        {
            bsMateriasPrimasLista.Clear();
            txtCantidad.EditValue = 0;
            bsMateriasPrimasLista.DataSource = _mpDAL.GetAllObj();
            bsMateriasPrimasLista.ResetBindings(true);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _materiaPrimaId = ((MateriaPrima)bsMateriasPrimasLista.Current).Id;
            _cantidad = Convert.ToDecimal(txtCantidad.EditValue);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
