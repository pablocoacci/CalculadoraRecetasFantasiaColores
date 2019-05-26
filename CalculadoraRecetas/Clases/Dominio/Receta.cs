using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRecetas.Clases.Dominio
{
    public class Receta
    {
        public Receta()
        {
            Ingredientes = new List<Ingrediente>();
        }

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int CantidadComensales { get; set; }

        public decimal UtilidadPorce { get; set; }

        public decimal CostoIndirectoPorce { get; set; }

        public virtual IList<Ingrediente> Ingredientes { get; set; }

        public IList<Ingrediente> IngredientesValidos
        {
            get { return Ingredientes.Where(a => !a.IngredienteEliminado).ToList(); }
        }

        public decimal CostoTotalIngredientes { get { return Math.Round(IngredientesValidos.Sum(a => a.CostoNetoMP), 2); } }

        public decimal CostoIndirecto { get { return Math.Round(CostoTotalIngredientes * CostoIndirectoPorce / 100, 2); } }

        public decimal Utilidad { get { return Math.Round((CostoTotalIngredientes + CostoIndirecto) * UtilidadPorce / 100, 2); } }

        public decimal PrecioFinal { get { return Math.Round(CostoTotalIngredientes + CostoIndirecto + Utilidad, 2); } }

        public SeriesPoint[] GetChartPoints()
        {
            var points = new SeriesPoint[IngredientesValidos.Count];
            var total = CostoTotalIngredientes;
            int pos = 0;

            foreach (var ing in IngredientesValidos)
            {
                decimal incidencia = Math.Round(ing.CostoNetoMP * 100 / total, 2);
                points[pos] = new SeriesPoint(ing.MPAbreviatura, incidencia);
                pos++;
            }

            return points;
        }
    }
}
