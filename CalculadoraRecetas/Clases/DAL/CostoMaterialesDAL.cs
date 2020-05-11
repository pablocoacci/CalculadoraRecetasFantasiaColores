using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.StaticHelper;
using CalculadoraRecetas.Clases.StaticHelper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraRecetas.Clases.DAL
{
    public class CostoMaterialesDAL : BaseDAL, IObjectDAL<CostoMateriales>
    {
        public CostoMaterialesDAL() : base() { }

        public bool Delete(int id)
        {
            try
            {
                var costo = _dbContext.CostoMateriales.Where(a => a.Id == id).FirstOrDefault();

                if(costo!=null)
                {
                    var error = ValidDelete(costo);

                    if (error != string.Empty)
                        throw new Exception("Ocurrio un error durante el Delete: " + error);

                    _dbContext.CostoMateriales.Remove(costo);
                    _dbContext.SaveChanges();
                }

                return true;
            }
            catch(Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public bool Delete(CostoMateriales domObj)
        {
            return Delete(domObj.Id);
        }

        public IList<CostoMateriales> GetAllObj()
        {
            return _dbContext.CostoMateriales.ToList();
        }

        public CostoMateriales GetObjtById(int id)
        {
            return _dbContext.CostoMateriales.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool Save(CostoMateriales domObj)
        {
            try
            {
                var error = ValidSave(domObj);

                if (error != string.Empty)
                    throw new Exception("Ocurrio un error durante el Save: " + error);

                domObj.FechaCompra = domObj.FechaCompra.SacarHoras();

                if (domObj.Id == 0)
                    _dbContext.CostoMateriales.Add(domObj);

                _dbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public string ValidDelete(CostoMateriales domObj)
        {
            return "";
        }

        public string ValidSave(CostoMateriales domObj)
        {
            if (domObj.Notas.Length > 1500)
                return "Las notas no pueden superar los 1500 caracteres";

            if (domObj.Detalle.Length > 50)
                return "El detalle no puede superar los 50 caracteres";

            if (domObj.PrecioUnitario <= 0)
                return "El precio unitario no puede ser menor a 0";

            if (domObj.Cantidad <= 0)
                return "La cantidad no puede ser menor a 0";

            if (domObj.CostoTotal <= 0)
                return "El costo total no puede ser menor o igual a 0";

            return "";
        }
    }
}
