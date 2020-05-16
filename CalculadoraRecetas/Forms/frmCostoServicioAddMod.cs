using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Helpers;
using System;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmCostoServicioAddMod : Form
    {
        private IMessageManager _messageManager;
        private IObjectDAL<CostoServicio> _costoServicioDAL;
        private IObjectDAL<Servicio> _serviciosDAL;
        private CostoServicio _costoServ;
        private bool closeOK = false;

        public frmCostoServicioAddMod(
            IMessageManager messageManager,
            IObjectDAL<CostoServicio> costoServicioDAL,
            IObjectDAL<Servicio> serviciosDAL)
        {
            InitializeComponent();

            _messageManager = messageManager;
            _costoServicioDAL = costoServicioDAL;
            _serviciosDAL = serviciosDAL;
        }

        public void ConfigFormCostoServicio(int id = 0)
        {
            if (id == 0)
                _costoServ = new CostoServicio() { FechaCreacion = DateTime.Now };
            else
                _costoServ = _costoServicioDAL.GetObjtById(id);
        }

        private void frmCostoServicioAddMod_Load(object sender, EventArgs e)
        {
            bsServiciosLista.DataSource = _serviciosDAL.GetAllObj();
            bsCostoServicio.DataSource = _costoServ;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var error = _costoServicioDAL.ValidSave(_costoServ);

            if (error != string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_costoServicioDAL.Save(_costoServ))
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

        private void frmCostoServicioAddMod_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeOK)
            {
                if (MessageBox.Show(_messageManager.PerderanCambios(), _messageManager.AtencionTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
