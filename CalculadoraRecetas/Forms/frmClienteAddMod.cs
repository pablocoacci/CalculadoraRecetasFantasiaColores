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
    public partial class frmClienteAddMod : Form
    {
        private IObjectDAL<Cliente> _clieDAL;
        private Cliente _clie;
        private IMessageManager _messageManager;
        private bool closeOK = false;

        public frmClienteAddMod(IObjectDAL<Cliente> clieDAL, IMessageManager messageManager)
        {
            InitializeComponent();

            _clieDAL = clieDAL;
            _messageManager = messageManager;
        }

        public void ConfigureFormCliente(int id = 0, bool enableEdit = true)
        {
            _clieDAL.ResetContext();

            if (id == 0)
                _clie = new Cliente();
            else
                _clie = _clieDAL.GetObjtById(id);

            if(!enableEdit)
            {
                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;
                txtMail.Enabled = false;
                txtTelefono.Enabled = false;
                txtCelular.Enabled = false;
                chkClienteDificil.Enabled = false;
                txtNotas.Enabled = false;
                btnAceptar.Enabled = false;
                closeOK = true;
            }
        }

        private void frmClienteAddMod_Load(object sender, EventArgs e)
        {
            bsCliente.DataSource = _clie;
            bsCliente.ResetBindings(true);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var error = _clieDAL.ValidSave(_clie);

            if (error != string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_clieDAL.Save(_clie))
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

        private void frmClienteAddMod_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeOK)
            {
                if (MessageBox.Show(_messageManager.PerderanCambios(), _messageManager.AtencionTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
