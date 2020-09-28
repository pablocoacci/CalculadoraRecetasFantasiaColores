using System;

namespace CalculadoraRecetas.Clases.Dominio
{
    public class CostoBasico
    {
        public int Id { get; set; }
        public int? IdCostoFijo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCosto { get; set; }
        public string Notas { get; set; }
        public decimal CostoMonto { get; set; }

        public virtual CostoFijo CostoFijo { get; set; }

        public bool IsCostoFijo { get { return IdCostoFijo != null; } }
    }
}
