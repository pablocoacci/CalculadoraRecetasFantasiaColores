using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmCostosFijos : Form
    {
        private IObjectDAL<CostoFijo> _costosFijosDAL;
        private IMessageManager _messageManager;

        public frmCostosFijos(
            IObjectDAL<CostoFijo> costosFijosDAL, 
            IMessageManager messageManager)
        {
            InitializeComponent();

            _costosFijosDAL = costosFijosDAL;
            _messageManager = messageManager;
        }

        private void ResetBinding()
        {
            txtNombreCostoFijo.Text = "";
            _costosFijosDAL.ResetContext();
            bsCostosFijos.DataSource = _costosFijosDAL.GetAllObj();
            bsCostosFijos.ResetBindings(true);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoCostoFijo = new CostoFijo() { Nombre = txtNombreCostoFijo.Text };
            var error = _costosFijosDAL.ValidSave(nuevoCostoFijo);

            if(error != string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _costosFijosDAL.Save(nuevoCostoFijo);
            ResetBinding();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _costosFijosDAL.GetContext().SaveChanges();
            this.Close();
        }

        private void frmCostosFijos_Load(object sender, EventArgs e)
        {
            ResetBinding();
        }
    }
}
