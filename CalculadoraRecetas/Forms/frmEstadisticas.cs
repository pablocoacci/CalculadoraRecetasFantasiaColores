using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Helpers;
using CalculadoraRecetas.Clases.Mappings;
using DevExpress.XtraCharts;
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
    public partial class frmEstadisticas : Form
    {
        private CalculadoraDataContext _dbContext;
        private IMessageManager _messageManager;
        private IList<Receta> _recetas = new List<Receta>();

        public frmEstadisticas(IMessageManager messageManager)
        {
            InitializeComponent();

            _dbContext = new CalculadoraDataContext();
            _messageManager = messageManager;
        }

        private IList<Pedido> GetPedidosByDates(DateTime fechaDesde, DateTime fechaHasta)
        {
            if (fechaHasta <= fechaDesde)
            {
                MessageBox.Show(_messageManager.ErrorDesdeMayorAHasta(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if ((fechaHasta - fechaDesde).Days > 365)
            {
                MessageBox.Show(_messageManager.ErrorEstadisticaMaxDias(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            var pedidos = _dbContext.Pedidos.Where(a => a.Estado == Pedido.EstadoPedido.Entregado && fechaDesde <= a.FechaEntrega && a.FechaEntrega <= fechaHasta).ToList();

            if (!pedidos.Any())
            {
                MessageBox.Show(_messageManager.ErrorEstadisticaNoPedidos(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return pedidos;
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            _recetas = _dbContext.Recetas.OrderBy(a => a.Nombre).ToList();
            bsRecetasCombo.DataSource = _dbContext.Recetas.OrderBy(a => a.Nombre).ToList();
            bsRecetasCombo.ResetBindings(true);
        }

        private void btnGenerarUtilidadesMes_Click(object sender, EventArgs e)
        {
            DateTime dtDesde = dtpDesdeUtilidadesMes.Value;
            DateTime dtHasta = dtpHastaUtilidadesMes.Value;

            var pedidos = GetPedidosByDates(dtDesde, dtHasta);
            if (pedidos == null) return;

            var seriePointVtasTotales = (from p in pedidos
                                         group p.PrecioVentaSugerido by p.FechaEntrega.ToString("MMMM") into g
                                         select new SeriesPoint(g.Key, Math.Round(g.Sum(), 2))).ToArray();

            var seriePointUtilidades = (from p in pedidos
                                        group p.GananciaTotal by p.FechaEntrega.ToString("MMMM") into g
                                        select new SeriesPoint(g.Key, Math.Round(g.Sum(), 2))).ToArray();

            Series serieVtasTotales = new Series("Vtas. Totales", ViewType.Bar);
            serieVtasTotales.Points.AddRange(seriePointVtasTotales);

            Series serieUtilidades = new Series("Utilidades Totales", ViewType.Bar);
            serieUtilidades.Points.AddRange(seriePointUtilidades);

            charVentasMes.Series.Clear();
            charVentasMes.Series.Add(serieVtasTotales);
            charVentasMes.Series.Add(serieUtilidades);
        }

        private void btnUtilidadProd_Click(object sender, EventArgs e)
        {
            DateTime dtDesde = dtpDesdeUtilidadProd.Value;
            DateTime dtHasta = dtpHastaUtilidadProd.Value;

            var pedidos = GetPedidosByDates(dtDesde, dtHasta);
            if (pedidos == null) return;

            var totalUtilidades = Math.Round(pedidos.Sum(a => a.GananciaTotal), 2);
            var ordenes = new List<Orden>();

            foreach (var p in pedidos)
                ordenes.AddRange(p.OrdenesValidas);

            var seriePoint = (from or in ordenes
                              group or.GananciaTotal by or.NombreReceta into g
                              select new SeriesPoint(g.Key, Math.Round(g.Sum() * 100 / totalUtilidades, 2))).ToArray();

            Series serieUtilidadesProd = new Series("Utilidades Productos", ViewType.Pie);
            serieUtilidadesProd.Points.AddRange(seriePoint);
            serieUtilidadesProd.Label.TextPattern = "{A}: {VP:p0}";
            serieUtilidadesProd.ShowInLegend = true;

            charUtilidadProd.Series.Clear();
            charUtilidadProd.Series.Add(serieUtilidadesProd);

            ((PieSeriesLabel)serieUtilidadesProd.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Access the view-type-specific options of the series.
            PieSeriesView myView = (PieSeriesView)serieUtilidadesProd.View;

            // Show a title for the series.
            myView.Titles.Add(new SeriesTitle());
            myView.Titles[0].Text = serieUtilidadesProd.Name;
            txtTotalUtilidadesPord.EditValue = totalUtilidades;
        }

        private void btnCantVtasProd_Click(object sender, EventArgs e)
        {
            DateTime dtDesde = dtpDesdeCantVtasProd.Value;
            DateTime dtHasta = dtpHastaCantVtasProd.Value;

            var pedidos = GetPedidosByDates(dtDesde, dtHasta);
            if (pedidos == null) return;

            var ordenes = new List<Orden>();

            foreach (var p in pedidos)
                ordenes.AddRange(p.OrdenesValidas);

            var totalVtas = ordenes.Sum(a => a.Cantidad);
            txtCantVtasProd.EditValue = totalVtas;

            var seriePoint = (from or in ordenes
                              group or.Cantidad by or.NombreReceta into g
                              select new SeriesPoint(g.Key, Math.Round(Convert.ToDecimal(g.Sum() * 100 / totalVtas), 2))).ToArray();

            Series serieCantVtasProd = new Series("Cantidad de Vtas. Productos", ViewType.Pie);
            serieCantVtasProd.Points.AddRange(seriePoint);
            serieCantVtasProd.Label.TextPattern = "{A}: {VP:p0}";
            serieCantVtasProd.ShowInLegend = true;

            charCantVtasProd.Series.Clear();
            charCantVtasProd.Series.Add(serieCantVtasProd);

            ((PieSeriesLabel)serieCantVtasProd.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Access the view-type-specific options of the series.
            PieSeriesView myView = (PieSeriesView)serieCantVtasProd.View;

            // Show a title for the series.
            myView.Titles.Add(new SeriesTitle());
            myView.Titles[0].Text = serieCantVtasProd.Name;
        }

        private void btnHistorialProd_Click(object sender, EventArgs e)
        {
            DateTime dtDesde = dtpDesdeHistorialProd.Value;
            DateTime dtHasta = dtpHastaHistorialProd.Value;
            string nombreReceta = "";

            try
            {
                nombreReceta = cboHistorialProd.GetColumnValue("Nombre").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(_messageManager.ErrorEstadisticaHistorialPedidoNoPedidoSelect(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var receta = _recetas.Where(a => a.Nombre == nombreReceta).FirstOrDefault();

            var ordenCantidad = new List<SeriesPoint>();
            var ordenVentas = new List<SeriesPoint>();
            var ordenUtilidades = new List<SeriesPoint>();
            
            if (!chkHistorialProdCantidad.Checked && !chkHistorialProdVentas.Checked && !chkHistorialProdUtilidades.Checked)
            {
                MessageBox.Show(_messageManager.ErrorEstadisticaHistorialPedidoNoChek(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var pedidos = GetPedidosByDates(dtDesde, dtHasta);

            if (pedidos == null)
            {
                return;
            }

            var fecha = dtDesde;
            while (fecha.Month <= dtHasta.Month && fecha.Year <= dtHasta.Year)
            {
                var pedidosMes = pedidos.Where(a => a.FechaEntrega.Month == fecha.Month);

                foreach (var ped in pedidosMes)
                {
                    var ordenes = ped.OrdenesValidas.Where(a => a.Id_Receta == receta.Id);

                    if (ordenes.Any())
                    {
                        ordenCantidad.Add(new SeriesPoint(fecha.ToString("MMM"), ordenes.Sum(a => a.Cantidad)));
                        ordenVentas.Add(new SeriesPoint(fecha.ToString("MMM"), ordenes.Sum(a => a.PrecioTotal)));
                        ordenUtilidades.Add(new SeriesPoint(fecha.ToString("MMM"), ordenes.Sum(a => a.GananciaTotal)));
                    }
                    else
                    {
                        ordenCantidad.Add(new SeriesPoint(fecha.ToString("MMM"), 0));
                        ordenVentas.Add(new SeriesPoint(fecha.ToString("MMM"), 0));
                        ordenUtilidades.Add(new SeriesPoint(fecha.ToString("MMM"), 0));
                    }
                }

                fecha = fecha.AddMonths(1);
            }

            charHistorialProd.Series.Clear();

            if (chkHistorialProdCantidad.Checked)
            {
                Series serieCantVendidas = new Series("Cant. Vendida", ViewType.Bar);
                serieCantVendidas.Points.AddRange(ordenCantidad.ToArray());
                charHistorialProd.Series.Add(serieCantVendidas);
            }

            if (chkHistorialProdVentas.Checked)
            {
                Series serieVentasTotales = new Series("Vtas. Totales", ViewType.Bar);
                serieVentasTotales.Points.AddRange(ordenVentas.ToArray());
                charHistorialProd.Series.Add(serieVentasTotales);
            }

            if (chkHistorialProdUtilidades.Checked)
            {
                Series serieUtilidades = new Series("Utilidades", ViewType.Bar);
                serieUtilidades.Points.AddRange(ordenUtilidades.ToArray());
                charHistorialProd.Series.Add(serieUtilidades);
            }

        }

        private void btnAyudaTab1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_messageManager.AyudaVtasPorMes(), _messageManager.AyudaTitle(), MessageBoxButtons.OK, MessageBoxIcon.Question);
            return;
        }
        
        private void btnAyuda2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_messageManager.AyudaUtilidadesPorProducto(), _messageManager.AyudaTitle(), MessageBoxButtons.OK, MessageBoxIcon.Question);
            return;
        }

        private void btnAyuda3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_messageManager.AyudaCantVtasPorProducto(), _messageManager.AyudaTitle(), MessageBoxButtons.OK, MessageBoxIcon.Question);
            return;
        }

        private void btnAyuda4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_messageManager.AyudaHistorialProducto(), _messageManager.AyudaTitle(), MessageBoxButtons.OK, MessageBoxIcon.Question);
            return;
        }
    }
}
