using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraRecetas.Clases.Dominio
{
    public class Pedido
    {
        public enum EstadoPedido { Pendiente, Entregado, Abortado }

        public Pedido()
        {
            OrdenesRealizadas = new List<Orden>();
            Estado = EstadoPedido.Pendiente;
        }

        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Notas { get; set; }
        public decimal PrecioVentaReal { get; set; }
        public EstadoPedido Estado { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual IList<Orden> OrdenesRealizadas { get; set; }

        public string EstadoStr { get { return Estado.ToString("g"); } }
        public IList<Orden> OrdenesValidas { get { return OrdenesRealizadas.Where(a => !a.OrdenEliminada).ToList(); } }
        public string NombreCliente { get { return Cliente.Nombre; } }
        public string DireccionCliente { get { return Cliente.Direccion; } }
        public string TelefonoCliente { get { return Cliente.Telefono; } }
        public string CelularCliente { get { return Cliente.Celular; } }
        public string MailCliente { get { return Cliente.Mail; } }
        public decimal PercioMPTotal { get { return Math.Round(OrdenesValidas.Sum(a => a.CostoTotalMP), 2); } }
        public decimal CostoIndirectoTotal { get { return Math.Round(OrdenesValidas.Sum(a => a.CostoIndirectoTotal), 2); } }
        public decimal GananciaTotal { get { return Math.Round(PrecioVentaReal - PercioMPTotal - CostoIndirectoTotal, 2); } }
        public decimal PrecioVentaSugerido { get { return Math.Round(OrdenesValidas.Sum(a => a.PrecioTotal), 2); } }
    }
}
