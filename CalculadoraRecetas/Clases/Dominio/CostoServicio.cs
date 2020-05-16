using System;

namespace CalculadoraRecetas.Clases.Dominio
{
    public class CostoServicio
    {
        public int Id { get; set; }
        public int Id_Servicio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal PrecioFactura { get; set; }
        public int? HorasLaborablesMensual { get; set; }
        public decimal? IncidenciaPorce { get; set; }
        public decimal CostoTotal { get; set; }
        public string Notas { get; set; }

        public virtual Servicio Servicio { get; set; }

        public string MesCreacion { get { return FechaCreacion.ToString("MMMM"); } }
        public decimal CostoSugeridoIncidencia { get { return Math.Round(PrecioFactura * (IncidenciaPorce ?? 0) / 100, 2); } }
        public decimal CostoSugeridoEspecifico { get { return CalcularCostoEspecifico(); } }
        public string NombreServicio { get { return Servicio == null ? "" : Servicio.Nombre; } }

        private decimal CalcularCostoEspecifico()
        {
            var diasMes = DateTime.DaysInMonth(FechaCreacion.Year, FechaCreacion.Month);
            var horasMes = diasMes * 24;
            return Math.Round((HorasLaborablesMensual ?? 0) * PrecioFactura / horasMes, 2);
        }
    }
}
