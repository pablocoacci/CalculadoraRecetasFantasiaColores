using System;

namespace CalculadoraRecetas.Clases.Dominio
{
    public class Orden
    {
        public Orden()
        {
            OrdenEliminada = false;
            NombreReceta = "";
            Formula = "";
        }

        public Orden(Receta rec, int cant)
        {
            OrdenEliminada = false;
            NombreReceta = rec.Nombre;
            Id_Receta = rec.Id;
            Cantidad = cant;
            Formula = GetFormula(rec);
            CostoMP = rec.CostoTotalIngredientes;
            CostoIndirecto = rec.CostoIndirecto;
            Ganancia = rec.Utilidad;
        }

        public int Id { get; set; }
        public int Id_Pedido { get; set; }
        public int Id_Receta { get; set; }
        public string NombreReceta { get; set; }
        public string Formula { get; set; }
        public int Cantidad { get; set; }
        public decimal CostoMP { get; set; }
        public decimal CostoIndirecto { get; set; }
        public decimal Ganancia { get; set; }
        public virtual Pedido Pedido { get; set; }

        public bool OrdenEliminada { get; set; }
        public decimal CostoTotalMP { get { return Math.Round(CostoMP * Cantidad, 2); } }
        public decimal CostoIndirectoTotal { get { return Math.Round(CostoIndirecto * Cantidad, 2); } }
        public decimal GananciaTotal { get { return Math.Round(Cantidad * Ganancia, 2); } }
        public decimal PrecioTotal { get { return Math.Round((CostoMP + CostoIndirecto + Ganancia) * Cantidad, 2); } }

        private string GetFormula(Receta rec)
        {
            string formula = "";

            foreach(var ing in rec.Ingredientes)
            {
                string terna = "(" + ing.MPAbreviatura + " - " + ing.Cantidad + " - " + ing.MPPrecio + ");";
                formula += terna;
            }

            return formula;
        }
    }
}
