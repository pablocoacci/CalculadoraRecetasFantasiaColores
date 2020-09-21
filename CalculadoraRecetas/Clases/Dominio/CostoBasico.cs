using System;

namespace CalculadoraRecetas.Clases.Dominio
{
    public class CostoBasico
    {
        public int Id { get; set; }
        public bool IsCostoFijo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCosto { get; set; }
        public string Notas { get; set; }
        public decimal CostoMonto { get; set; }
    }
}
