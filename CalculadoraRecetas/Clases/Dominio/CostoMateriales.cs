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

        public string MesCompra { get { return FechaCompra.ToString("MMMM"); } }
        public decimal CostoTotalSugerido { get { return Math.Round(Cantidad * PrecioUnitario, 2); } }
        public string NombreMateriaPrima { get { return MateriaPrima.Nombre; } }
        public string NombreProveedor { get { return Proveedor.Nombre; } }
    }
}
