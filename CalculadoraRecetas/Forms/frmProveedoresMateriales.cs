using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Helpers;
using System;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmProveedoresMateriales : Form
    {
        private IObjectDAL<Proveedor> _proveedorDAL;
        private IMessageManager _messageManager;

        public frmProveedoresMateriales(IObjectDAL<Proveedor> proveedorDAL, IMessageManager messageManager)
        {
            InitializeComponent();

            _proveedorDAL = proveedorDAL;
            _messageManager = messageManager;
        }

        private void frmProveedoresMateriales_Load(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void ResetBinding()
        {
            txtNombreProveedor.Text = "";
            _proveedorDAL.ResetContext();
            bsProveedores.DataSource = _proveedorDAL.GetAllObj();
            bsProveedores.ResetBindings(true);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoProv = new Proveedor() { Nombre = txtNombreProveedor.Text };
            var error = _proveedorDAL.ValidSave(nuevoProv);

            if(error != string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (_proveedorDAL.Save(nuevoProv))
            //    MessageBox.Show(_messageManager.SaveOK(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show(_messageManager.SaveError(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            _proveedorDAL.Save(nuevoProv);

            ResetBinding();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _proveedorDAL.GetContext().SaveChanges();
            this.Close();
        }
    }
}
