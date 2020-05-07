using CalculadoraRecetas.Clases.DAL;
using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Helpers;
using DevExpress.XtraCharts;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CalculadoraRecetas.Forms
{
    public partial class frmRecetasAddMod : Form
    {
        private IObjectDAL<Receta> _recDAL;
        private frmIngredienteAdd _frmIngredienteAdd;
        private IMessageManager _messageManager;
        private Receta _rec;
        private bool closeOK = false;

        public frmRecetasAddMod(IObjectDAL<Receta> recDAL, frmIngredienteAdd frmIngredienteAdd, IMessageManager messageManager)
        {
            InitializeComponent();

            _recDAL = recDAL;
            _frmIngredienteAdd = frmIngredienteAdd;
            _messageManager = messageManager;
        }

        public void ConfigFormReceta(int id = 0)
        {
            _recDAL.ResetContext();

            if (id == 0)
                _rec = new Receta();
            else
                _rec = _recDAL.GetObjtById(id);

        }

        private void ResetBinding()
        {
            bsReceta.DataSource = _rec;
            bsIngredientesLista.DataSource = _rec.IngredientesValidos;
            bsReceta.ResetBindings(true);
            bsIngredientesLista.ResetBindings(true);
            ResetChart();
        }

        private void frmRecetasAddMod_Load(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _frmIngredienteAdd.ShowDialog();

            if (_frmIngredienteAdd._cantidad <= 0  || _frmIngredienteAdd._materiaPrimaId == -1)
            {
                MessageBox.Show(_messageManager.ErrorNuevoIngrediente(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ing = new Ingrediente()
            {
                Cantidad = _frmIngredienteAdd._cantidad,
                MateriaPrima = _recDAL.GetContext().MateriasPrimas.Where(a => a.Id == _frmIngredienteAdd._materiaPrimaId).FirstOrDefault()
            };

            _rec.Ingredientes.Add(ing);
            ResetBinding();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var ing = (Ingrediente)bsIngredientesLista.Current;
            ing.IngredienteEliminado = true;
            ResetBinding();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var error = _recDAL.ValidSave(_rec);

            if (error != string.Empty)
            {
                MessageBox.Show(error, _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_recDAL.Save(_rec))
                MessageBox.Show(_messageManager.SaveOK(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(_messageManager.SaveError(), _messageManager.AtencionTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            closeOK = true;
            this.Close();
        }

        private void frmRecetasAddMod_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeOK)
            {
                if (MessageBox.Show(_messageManager.PerderanCambios(), _messageManager.AtencionTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetChart()
        {
            chartCompPrecio.Series.Clear();

            // Create a pie series.
            Series series1 = new Series("Incidencia de Costos (Ingrediente Vs Costo)", ViewType.Pie);

            // Populate the series with points.
            series1.Points.AddRange(_rec.GetChartPoints());
            
            // Format the the series labels.
            series1.Label.TextPattern = "{A}: {VP:p0}";
            series1.ShowInLegend = false;

            // Add the series to the chart.
            chartCompPrecio.Series.Add(series1);

            // Adjust the position of series labels. 
            //((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;

            // Detect overlapping of series labels.
            ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Access the view-type-specific options of the series.
            PieSeriesView myView = (PieSeriesView)series1.View;

            // Show a title for the series.
            myView.Titles.Add(new SeriesTitle());
            myView.Titles[0].Text = series1.Name;
        }

        private void TestChart()
        {
            chartCompPrecio.Series.Clear();

            // Create a pie series.
            Series series1 = new Series("A Pie Series", ViewType.Pie);

            // Populate the series with points.
            series1.Points.Add(new SeriesPoint("Russia", 17.0752));
            series1.Points.Add(new SeriesPoint("Canada", 9.98467));
            series1.Points.Add(new SeriesPoint("USA", 9.63142));
            series1.Points.Add(new SeriesPoint("China", 9.59696));
            series1.Points.Add(new SeriesPoint("Brazil", 8.511965));
            series1.Points.Add(new SeriesPoint("Australia", 7.68685));
            series1.Points.Add(new SeriesPoint("India", 3.28759));
            series1.Points.Add(new SeriesPoint("Others", 81.2));

            // Add the series to the chart.
            chartCompPrecio.Series.Add(series1);

            //// Format the the series labels.
            //FORMA 1
            //series1.Label.TextPattern = "{VP:p0}";
            //series1.LegendTextPattern= "{A}: {VP:p0}";

            //FORMA 2
            series1.Label.TextPattern = "{A}: {VP:p0}";
            series1.ShowInLegend = false;

            //// Adjust the position of series labels. 
            //((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;

            //// Detect overlapping of series labels.
            //((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            //// Access the view-type-specific options of the series.
            //PieSeriesView myView = (PieSeriesView)series1.View;

            //// Show a title for the series.
            //myView.Titles.Add(new SeriesTitle());
            //myView.Titles[0].Text = series1.Name;
        }

        private void btnAyudaReceta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_messageManager.AyudaIncidenciaIngredientes(), _messageManager.AyudaTitle(), MessageBoxButtons.OK, MessageBoxIcon.Question);
            return;
        }
    }
}
