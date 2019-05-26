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
    public partial class frmMateriasPrimasAddMod : Form
    {
        private IObjectDAL<MateriaPrima> _mpDAL;
        private IMessageManager _messageManager;
        private MateriaPrima mp = null;
        private bool closeOK = false;

        public frmMateriasPrimasAddMod(IObjectDAL<MateriaPrima> mpDAL, IMessageManager messageManager)
        {
            InitializeComponent();

            _mpDAL = mpDAL;
            _messageManager = messageManager;
        }

        public void ConfigFormMateriaPrima(int id = 0)
        {
            _mpDAL.ResetContext();

            if (id == 0)
                mp = new MateriaPrima();
            else
                mp = _mpDAL.GetObjtById(id);
        }

        private void ResetBinding()
        {
            closeOK = false;
            bsMateriaPrima.DataSource = mp;
            bsMateriaPrima.ResetBindings(true);
        }

        private void frmMateriasPrimasAddMod_Load(object sender, EventArgs e)
        {
            cboUnidadMedida.DataSource = mp.GetTiposUnidadesList();
            ResetBinding();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var error = _mpDAL.ValidSave(mp);

            if (error != string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_mpDAL.Save(mp))
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

        private void frmMateriasPrimasAddMod_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeOK)
            {
                if (MessageBox.Show(_messageManager.PerderanCambios(), _messageManager.AtencionTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
