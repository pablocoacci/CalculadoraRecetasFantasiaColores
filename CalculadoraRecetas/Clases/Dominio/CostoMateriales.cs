using System;

namespace CalculadoraRecetas.Clases.Dominio
{
    public class CostoMateriales
    {
        public int Id { get; set; }
        public int Id_MateriaPrima { get; set; }
        public int Id_Proveedor { get; set; }
        public DateTime FechaCompra { get; set; }
        public string Notas { get; set; }
        public string Detalle { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal CostoTotal { get; set; }

        public virtual MateriaPrima MateriaPrima { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
