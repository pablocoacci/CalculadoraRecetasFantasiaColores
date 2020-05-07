using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.StaticHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraRecetas.Clases.DAL
{
    public class ProveedoresDAL : BaseDAL, IObjectDAL<Proveedor>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Proveedor domObj)
        {
            throw new NotImplementedException();
        }

        public IList<Proveedor> GetAllObj()
        {
            return _dbContext.Proveedores.ToList();
        }

        public Proveedor GetObjtById(int id)
        {
            return _dbContext.Proveedores.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool Save(Proveedor domObj)
        {
            try
            {
                string error = ValidSave(domObj);

                if (domObj.Id == 0)
                    _dbContext.Proveedores.Add(domObj);

                _dbContext.SaveChanges();
                return true;

            }
            catch(Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public string ValidDelete(Proveedor domObj)
        {
            throw new NotImplementedException();
        }

        public string ValidSave(Proveedor domObj)
        {
            if (domObj.Nombre.Length > 50)
                return "El nombre del proveedor no puede superar los 50 caracteres";

            return "";
        }
    }
}
