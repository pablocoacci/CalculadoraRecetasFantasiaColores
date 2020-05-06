using System;
using System.Collections.Generic;

namespace CalculadoraRecetas.Clases.Dominio
{
    public enum TipoUnidad { Unidad, UnGramo, CienGramo, UnKiloGramo }

    public class MateriaPrima
    {
        public MateriaPrima()
        {
            Nombre = "";
            Abreviatura = "";
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public TipoUnidad UnidadMedida { get; set; }
        public decimal Precio { get; set; }

        public string UnidadMedidaStr
        {
            get { return UnidadMedida.ToString("g"); }
            set
            {
                TipoUnidad tu;
                Enum.TryParse(value, out tu);
                UnidadMedida = tu;
            }
        }

        /// <summary>
        /// Obtiene el precio de una sola unidad de materia prima
        /// </summary>
        /// <returns></returns>
        public decimal GetPrecioUnidad()
        {
            if (UnidadMedida == TipoUnidad.Unidad)
                return Precio;
            else
                throw new System.InvalidOperationException("Solo se puede obtener el precio por unidad si la unidad de medida es Unidad");
        }

        /// <summary>
        /// Obtiene el precio de un unico gramo de materia prima
        /// </summary>
        /// <returns></returns>
        public decimal GetPrecioGramo()
        {
            decimal precioUnitario = 0;

            switch(UnidadMedida)
            {
                case TipoUnidad.Unidad:
                    throw new System.InvalidOperationException("No se puede obtener el precio por unidad si el tipo de unidad es por gramo o por kilo");
                case TipoUnidad.UnGramo:
                    precioUnitario = Precio;
                    break;
                case TipoUnidad.CienGramo:
                    precioUnitario = Math.Round(Precio / 100, 2);
                    break;
                case TipoUnidad.UnKiloGramo:
                    precioUnitario = Math.Round(Precio / 1000, 2);
                    break;

            }

            return precioUnitario;
        }

        /// <summary>
        /// Obtiene el precio de un kilo de materia prima
        /// </summary>
        /// <returns></returns>
        public decimal GetPrecioKilo()
        {
            decimal precioUnitario = 0;

            switch(UnidadMedida)
            {
                case TipoUnidad.Unidad:
                    throw new System.InvalidOperationException("No se puede obtener el precio por unidad si el tipo de unidad es por gramo o por kilo");
                case TipoUnidad.UnGramo:
                    precioUnitario = Math.Round(Precio * 1000, 2);
                    break;
                case TipoUnidad.CienGramo:
                    precioUnitario = Math.Round(Precio * 1000 / 100, 2);
                    break;
                case TipoUnidad.UnKiloGramo:
                    precioUnitario = Precio;
                    break;
            }

            return precioUnitario;
        }
        
        public List<string> GetTiposUnidadesList()
        {
            return new List<string>() { TipoUnidad.Unidad.ToString("g"), TipoUnidad.UnGramo.ToString("g"), TipoUnidad.CienGramo.ToString("g"), TipoUnidad.UnKiloGramo.ToString("g") };
        }
    }
}
