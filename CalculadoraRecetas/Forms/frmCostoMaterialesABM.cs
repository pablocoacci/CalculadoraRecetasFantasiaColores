using System;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmCostoMaterialesABM : Form
    {
        private frmCostoMaterialesAddMod _costosMaterialesAddMod;
        private frmProveedoresMateriales _proveedoresAddMod;
        public frmCostoMaterialesABM(
            frmCostoMaterialesAddMod costosMaterialesAddMod,
            frmProveedoresMateriales proveedoresAddMod)
        {
            InitializeComponent();

            _costosMaterialesAddMod = costosMaterialesAddMod;
            _proveedoresAddMod = proveedoresAddMod;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _costosMaterialesAddMod.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            _proveedoresAddMod.ShowDialog();
        }
    }
}
