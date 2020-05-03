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
    public partial class frmPedidosAddMod : Form
    {
        private IObjectDAL<Pedido> _pedDAL;
        private IObjectDAL<Cliente> _clieDAL;
        private IMessageManager _messageManager;
        private frmOrdenAdd _frmOrdenAdd;
        private frmClienteAddMod _frmClieAddMod;
        private bool closeOK = false;
        private Pedido _ped;

        public frmPedidosAddMod(IObjectDAL<Pedido> pedDAL, IObjectDAL<Cliente> clieDAL, frmOrdenAdd frmOrdenAdd, frmClienteAddMod frmClieAddMod, IMessageManager messageManager)
        {
            InitializeComponent();

            _pedDAL = pedDAL;
            _clieDAL = clieDAL;
            _frmOrdenAdd = frmOrdenAdd;
            _frmClieAddMod = frmClieAddMod;
            _messageManager = messageManager;
        }

        public void ConfigFormPedidos(int id = 0)
        {
            if (id == 0)
            {
                _ped = new Pedido();
                _ped.FechaPedido = DateTime.Now;
                dtpFechaEntrega.Value = DateTime.Now;
            }
            else
            {
                _ped = _pedDAL.GetObjtById(id);
                dtpFechaEntrega.Value = _ped.FechaEntrega;
            }

            if (_ped.Id != 0 && _ped.Estado != Pedido.EstadoPedido.Pendiente)
            {
                txtNotas.Enabled = false;
                txtPrecioVenta.Enabled = false;
                dtpFechaEntrega.Enabled = false;
                cboClientes.Enabled = false;
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                btnAceptar.Enabled = false;
                btnEntragarPedido.Enabled = false;
                btnAbortarPedido.Enabled = false;
                closeOK = true;
            }
            else
            {
                txtNotas.Enabled = true;
                txtPrecioVenta.Enabled = true;
                dtpFechaEntrega.Enabled = true;
                cboClientes.Enabled = true;
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                btnAceptar.Enabled = true;
                btnEntragarPedido.Enabled = true;
                btnAbortarPedido.Enabled = true;
                closeOK = false;
            }
        }

        private void ResetearBindings()
        {
            bsPedido.DataSource = _ped;
            bsOrdenesLista.DataSource = _ped.OrdenesValidas;
            bsPedido.ResetBindings(true);
            bsOrdenesLista.ResetBindings(true);
            SetColorEstado();
        }

        private void SetColorEstado()
        {
            if (_ped.Estado == Pedido.EstadoPedido.Abortado)
                txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); //color bordo
            else if (_ped.Estado == Pedido.EstadoPedido.Entregado)
                txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))); //color verde
            else
                txtEstado.ForeColor = System.Drawing.Color.Black;
        }

        private void frmPedidosAddMod_Load(object sender, EventArgs e)
        {
            bsClientesLista.DataSource = _clieDAL.GetAllObj();
            bsClientesLista.ResetBindings(true);
            ResetearBindings();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _ped.FechaEntrega = dtpFechaEntrega.Value;
            var error = _pedDAL.ValidSave(_ped);

            if (error != string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_pedDAL.Save(_ped))
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

        private void frmPedidosAddMod_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeOK)
            {
                if (MessageBox.Show(_messageManager.PerderanCambios(), _messageManager.AtencionTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _frmOrdenAdd.ShowDialog();

            if (_frmOrdenAdd._recetaSelected == null || _frmOrdenAdd._cant < 0)
            {
                MessageBox.Show(_messageManager.ErrorNuevaOrden(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var nuevaOrden = new Orden(_frmOrdenAdd._recetaSelected, _frmOrdenAdd._cant);
            _ped.OrdenesRealizadas.Add(nuevaOrden);
            ResetearBindings();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var ordenSelect = (Orden)bsOrdenesLista.Current;
            ordenSelect.OrdenEliminada = true;
            ResetearBindings();
        }

        private void btnVerCliente_Click(object sender, EventArgs e)
        {
            int id_Cliente = (int)cboClientes.EditValue;
            _frmClieAddMod.ConfigureFormCliente(id_Cliente, false);
            _frmClieAddMod.ShowDialog();
        }

        private void btnEntragar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_messageManager.CambiarEstadoPedidoEntregado(), _messageManager.AtencionTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            _ped.Estado = Pedido.EstadoPedido.Entregado;
            ResetearBindings();
        }

        private void btnAbortarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_messageManager.CambiarEstadoPedidoAbortado(), _messageManager.AtencionTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            _ped.Estado = Pedido.EstadoPedido.Abortado;
            ResetearBindings();
        }
    }
}
