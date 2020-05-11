using System;

namespace CalculadoraRecetas.Clases.StaticHelper.Extensions
{
    public static class DateTimeExtension
    {
        /// <summary>
        /// Dada una fecha con horas y minutos y segundos los deja en 00:00:00
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static DateTime SacarHoras(this DateTime fecha)
            => new DateTime(fecha.Year, fecha.Month, fecha.Day);
    }
}
