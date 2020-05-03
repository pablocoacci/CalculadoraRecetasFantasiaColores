using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.Mappings;
using CalculadoraRecetas.Clases.StaticHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRecetas.Clases.DAL
{
    public class PedidosDAL : BaseDAL, IObjectDAL<Pedido>
    {
        private string msgOrdenError = "";

        public PedidosDAL() : base() { }

        public bool Delete(int id)
        {
            try
            {
                var ped = _dbContext.Pedidos.Where(a => a.Id == id).FirstOrDefault();

                if (ped != null)
                {
                    var error = ValidDelete(ped);

                    if (error != string.Empty)
                        throw new Exception("Ocurrio un error durante el Delete: " + error);

                    _dbContext.Pedidos.Remove(ped);
                    _dbContext.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public bool Delete(Pedido ped)
        {
            return Delete(ped.Id);
        }

        public IList<Pedido> GetAllObj()
        {
            return _dbContext.Pedidos.ToList();
        }

        public Pedido GetObjtById(int id)
        {
            return _dbContext.Pedidos.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool Save(Pedido ped)
        {
            try
            {
                var error = ValidSave(ped);

                if (error != string.Empty)
                    throw new Exception("Ocurrio un error durante el Save: " + error);

                if (ped.Id == 0)
                    _dbContext.Pedidos.Add(ped);

                _dbContext.SaveChanges();

                var eliminar = ped.OrdenesRealizadas.Where(a => a.OrdenEliminada).ToList();

                foreach (var o in eliminar)
                {
                    if (o.Id > 0)
                    {
                        _dbContext.Ordenes.Remove(o);
                        _dbContext.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public string ValidDelete(Pedido domObj)
        {
            return string.Empty;
        }

        public string ValidSave(Pedido ped)
        {
            //if (ped.FechaEntrega <= ped.FechaPedido)
            //    return "La Fecha de Entrega no puede ser menor a la Fecha de Pedido";

            if (ped.Cliente == null && ped.Id_Cliente == 0)
                return "El campo Cliente es obligatorio";

            if (!ped.OrdenesRealizadas.Any())
                return "El Pedido debe de contener al menos una Orden";

            if (ped.PrecioVentaReal <= 0)
                return "El precio de venta real debe ser mayor a 0";

            if (ped.Notas.Length > 1500)
                return "Las notas no pueden tener mas de 1500 caracteres";

            if (ped.OrdenesRealizadas.Where(ValidateSaveOrden).Any())
                return msgOrdenError;

            return string.Empty;
        }

        private bool ValidateSaveOrden(Orden or)
        {
            if (or.NombreReceta == "" || or.NombreReceta == string.Empty)
            {
                msgOrdenError = "La Orden no tiene Nombre de Receta";
                return true;
            }

            if (or.NombreReceta.Length > 50)
            {
                msgOrdenError = "El Nombre de la Receta no puede superar los 50 caracteres";
                return true;
            }

            if (or.Formula == "" || or.Formula == string.Empty)
            {
                msgOrdenError = "La Orden no tiene una Formula";
                return true;
            }

            if (or.Formula.Length > 1500)
            {
                msgOrdenError = "La Formula no puede superar los 1500 caracteres";
                return true;
            }

            if (or.CostoIndirecto < 0)
            {
                msgOrdenError = "El Costo Indirecto no puede ser menor a 0";
                return true;
            }

            if (or.CostoMP < 0)
            {
                msgOrdenError = "El costo de Materia Prima no puede ser menor a 0";
                return true;
            }

            if (or.Ganancia < 0)
            {
                msgOrdenError = "La Ganancia no puede ser menor a 0";
                return true;
            }

            return false;
        }
    }
}
