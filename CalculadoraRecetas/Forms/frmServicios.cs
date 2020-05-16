using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Helpers;
using System;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmServicios : Form
    {
        private IObjectDAL<Servicio> _serviciosDAL;
        private IMessageManager _messageManager;

        public frmServicios(
            IObjectDAL<Servicio> serviciosDAL,
            IMessageManager messageManager)
        {
            InitializeComponent();

            _serviciosDAL = serviciosDAL;
            _messageManager = messageManager;
        }

        private void ResetBinding()
        {
            txtNombreServicio.Text = "";
            _serviciosDAL.ResetContext();
            bsServicios.DataSource = _serviciosDAL.GetAllObj();
            bsServicios.ResetBindings(true);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoServicio = new Servicio() { Nombre = txtNombreServicio.Text };
            var error = _serviciosDAL.ValidSave(nuevoServicio);

            if(error != string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _serviciosDAL.Save(nuevoServicio);
            ResetBinding();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _serviciosDAL.GetContext().SaveChanges();
            this.Close();
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            ResetBinding();
        }
    }
}
