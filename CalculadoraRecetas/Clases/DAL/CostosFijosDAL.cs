using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.StaticHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraRecetas.Clases.DAL
{
    public class CostosFijosDAL : BaseDAL, IObjectDAL<CostoFijo>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(CostoFijo domObj)
        {
            throw new NotImplementedException();
        }

        public IList<CostoFijo> GetAllObj()
        {
            return _dbContext.CostoFijos.ToList();
        }

        public CostoFijo GetObjtById(int id)
        {
            return _dbContext.CostoFijos.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool Save(CostoFijo domObj)
        {
            try
            {
                string error = ValidSave(domObj);

                if (domObj.Id == 0)
                    _dbContext.CostoFijos.Add(domObj);

                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public string ValidDelete(CostoFijo domObj)
        {
            throw new NotImplementedException();
        }

        public string ValidSave(CostoFijo domObj)
        {
            if (string.IsNullOrEmpty(domObj.Nombre))
                return "El nombre del servicio no puede ser vacio";
            if (domObj.Nombre.Length > 50)
                return "El nombre no puede superar los 50 caracteres";

            return "";
        }
    }
}
