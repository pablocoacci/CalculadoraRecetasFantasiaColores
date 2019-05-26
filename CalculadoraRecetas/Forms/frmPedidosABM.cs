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
    public partial class frmPedidosABM : Form
    {
        private IObjectDAL<Pedido> _pedDAL;
        private frmPedidosAddMod _frmPedAddMod;
        private IMessageManager _messageManager;

        public frmPedidosABM(IObjectDAL<Pedido> pedDAL, frmPedidosAddMod frmPedAddMod, IMessageManager messageManager)
        {
            InitializeComponent();

            _pedDAL = pedDAL;
            _frmPedAddMod = frmPedAddMod;
            _messageManager = messageManager;
        }
        
        private void ResetBinding()
        {
            DateTime dtDesde = dtpDesdePedido.Value;
            DateTime dtHasta = dtpHastaPedido.Value;
            _pedDAL.ResetContext();
            
            if(dtHasta<dtDesde)
            {
                MessageBox.Show(_messageManager.ErrorDesdeMayorAHasta(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (cboTipoFecha.SelectedItem.ToString() == "Fecha Pedido")
                bsPedidosLista.DataSource = _pedDAL.GetContext().Pedidos.Where(a => dtDesde <= a.FechaPedido && a.FechaPedido <= dtHasta).ToList();
            else if(cboTipoFecha.SelectedItem.ToString() == "Fecha Entrega")
                bsPedidosLista.DataSource = _pedDAL.GetContext().Pedidos.Where(a => dtDesde <= a.FechaEntrega && a.FechaEntrega <= dtHasta).ToList();
            else
                bsPedidosLista.DataSource = _pedDAL.GetAllObj();

            bsPedidosLista.ResetBindings(true);
        }

        private void ModificarPedido()
        {
            var ped = (Pedido)bsPedidosLista.Current;
            _frmPedAddMod.ConfigFormPedidos(ped.Id);
            _frmPedAddMod.ShowDialog();
            ResetBinding();
        }

        private void frmPedidosABM_Load(object sender, EventArgs e)
        {
            //ResetBinding();
            dtpDesdePedido.Value = DateTime.Now;
            dtpHastaPedido.Value = DateTime.Now.AddMonths(1);
            cboTipoFecha.SelectedIndex = 2;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _frmPedAddMod.ConfigFormPedidos();
            _frmPedAddMod.ShowDialog();
            ResetBinding();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarPedido();
        }

        private void grdPedidos_Click(object sender, EventArgs e)
        {
            ModificarPedido();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_messageManager.EliminarAdvertencia(), _messageManager.AtencionTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var ped = (Pedido)bsPedidosLista.Current;
            var error = _pedDAL.ValidDelete(ped);

            if (error != string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_pedDAL.Delete(ped))
                MessageBox.Show(_messageManager.EliminarOK(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(_messageManager.EliminarError(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            ResetBinding();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void cboTipoFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            var flag = !(cboTipoFecha.SelectedItem.ToString() == "Ninguna");
            dtpDesdePedido.Enabled = flag;
            dtpHastaPedido.Enabled = flag;
        }
    }
}
