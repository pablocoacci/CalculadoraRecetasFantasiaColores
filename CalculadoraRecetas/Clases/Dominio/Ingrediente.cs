using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRecetas.Clases.Dominio
{
    public class Ingrediente
    {
        public Ingrediente()
        {
            IngredienteEliminado = false;
        }

        public int Id { get; set; }

        public int Id_MateriaPrima { get; set; }

        public int Id_Receta { get; set; }

        /// <summary>
        /// La cantidad se expresa en gramos o en unidad
        /// </summary>
        public decimal Cantidad { get; set; }

        public virtual MateriaPrima MateriaPrima { get; set; }

        public virtual Receta Receta { get; set; }

        public bool IngredienteEliminado { get; set; }

        public string MPNombre { get { return MateriaPrima.Nombre; } }

        public string MPAbreviatura { get { return MateriaPrima.Abreviatura; } }

        public string MPUnidad { get { return MateriaPrima.UnidadMedidaStr; } }

        public decimal MPPrecio { get { return MateriaPrima.Precio; } }

        public decimal CostoNetoMP { get { return CalcularCosto(); } }

        private decimal CalcularCosto()
        {
            decimal costo = 0;

            if (MateriaPrima == null) return 0;

            switch (MateriaPrima.UnidadMedida)
            {
                case TipoUnidad.Unidad:
                    costo = Math.Round(Cantidad * MateriaPrima.GetPrecioUnidad(), 2);
                    break;
                default:
                    costo = Math.Round(Cantidad * MateriaPrima.GetPrecioGramo(), 2);
                    break;
            }

            return costo;
        }
    }
}
