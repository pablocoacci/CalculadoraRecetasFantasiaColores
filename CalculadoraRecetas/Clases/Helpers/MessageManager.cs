using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRecetas.Clases.Helpers
{
    public interface IMessageManager
    {
        string AtencionTitle();
        string AyudaTitle();
        string PerderanCambios();
        string SaveOK();
        string SaveError();

        string EliminarAdvertencia();
        string EliminarOK();
        string EliminarError();
        string ErrorNuevoIngrediente();
        string ErrorNuevaOrden();
        string CambiarEstadoPedidoEntregado();
        string CambiarEstadoPedidoAbortado();

        string ErrorDesdeMayorAHasta();
        string ErrorEstadisticaMaxDias();
        string ErrorEstadisticaNoPedidos();
        string ErrorEstadisticaHistorialPedidoNoPedidoSelect();
        string ErrorEstadisticaHistorialPedidoNoChek();

        string AyudaIncidenciaIngredientes();
        string AyudaVtasPorMes();
        string AyudaUtilidadesPorProducto();
        string AyudaCantVtasPorProducto();
        string AyudaHistorialProducto();
    }

    public class MessageManager : IMessageManager
    {
        public MessageManager() { }

        public string AtencionTitle()
        {
            return "Atencion...";
        }

        public string AyudaTitle()
        {
            return "Ayuda...";
        }

        public string PerderanCambios()
        {
            return "Se perderan los cambios que se hayan realizado. Desea continuar?";
        }

        public string SaveOK()
        {
            return "Los cambios se han guardado exitosamente";
        }

        public string SaveError()
        {
            return "No se han podido guardar los cambios. Ha ocurrido un error";
        }

        public string EliminarAdvertencia()
        {
            return "Se eliminara el elemento seleccinoado. Desea continuar?";
        }

        public string EliminarOK()
        {
            return "El elemento se ha eliminado exitosamente";
        }

        public string EliminarError()
        {
            return "No se ha prodido eliminar el elemento. Ha ocurrido un error";
        }

        public string ErrorNuevoIngrediente()
        {
            return "No se selecciono ningun ingrediente o se definio una cantidad invalida";
        }

        public string ErrorNuevaOrden()
        {
            return "No se selecciono ninguna receta o se definio una cantidad invalida";
        }

        public string CambiarEstadoPedidoEntregado()
        {
            return "Se marcara el/los pedidos como entregados. ¿Desea continuar?";
        }

        public string CambiarEstadoPedidoAbortado()
        {
            return "Se marcara el/los pedidos como abortados y no seran tenidos en cuenta en las estadisticas. ¿Desea Continuar?";
        }

        public string ErrorDesdeMayorAHasta()
        {
            return "La fecha Desde tiene que ser menor que la fecha Hasta";
        }

        public string ErrorEstadisticaMaxDias()
        {
            return "La maxima cantidad de dias del intervalo no puede superar los 365";
        }
        
        public string ErrorEstadisticaNoPedidos()
        {
            return "No hay pedidos entre las fechas seleccionadas";
        }

        public string ErrorEstadisticaHistorialPedidoNoPedidoSelect()
        {
            return "Se debe de seleccionar un pedido valido";
        }

        public string ErrorEstadisticaHistorialPedidoNoChek()
        {
            return "Se debe de seleccionar al menos una opcion de los checkbox";
        }

        public string AyudaIncidenciaIngredientes()
        {
            return "Este grafico se muestra la incidencia de cada ingrediente en el costo total de produccion de la receta, por ejemplo si en el grafico dijera 14% Harina eso querria decir que del costo total del producto 14% corresponde a la Harina.";
        }

        public string AyudaVtasPorMes()
        {
            return "En color azul se muestra el monto total de las ventas por cada mez sumarizando todos los productos. En bordo se muestran cuales fueron las utilidades (Precio de venta - costo de produccion) totales por mes sumarizando de todas las ventas.";
        }

        public string AyudaUtilidadesPorProducto()
        {
            return "En este grafico se muestra como se componen las utilidades en el intervalo dados, es decir por ejemplo, que 15% de las utilidades provienen del producto 'Torta', el 35% del producto 'Cookies' y el 50% 'Pastelitos'.";
        }

        public string AyudaCantVtasPorProducto()
        {
            return "En este grafico se muestra del total de productos vendidos que porcentaje corresponde a cual producto, por ejemplo, si en ese intervalo de tiempo se hubieran vendido 10 produtos en total y el 40% de dichos productos fueron 'Tortas', entonces se habrian vendido 10 * 40 / 100 = 4 Tortas en total.";
        }

        public string AyudaHistorialProducto()
        {
            return "Dado un periodo de tiempo y una receta (producto) en este grafico se muestran: la cantidad total vendida de dicho producto, el monto total de las ventas de dicho producto y/o las utilidades totales de dicho producto.";
        }
    }
}
