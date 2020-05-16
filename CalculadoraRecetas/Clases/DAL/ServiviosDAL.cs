using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.StaticHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraRecetas.Clases.DAL
{
    public class ServiviosDAL : BaseDAL, IObjectDAL<Servicio>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Servicio domObj)
        {
            throw new NotImplementedException();
        }

        public IList<Servicio> GetAllObj()
        {
            return _dbContext.Servicios.ToList();
        }

        public Servicio GetObjtById(int id)
        {
            return _dbContext.Servicios.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool Save(Servicio domObj)
        {
            try
            {
                string error = ValidSave(domObj);

                if (domObj.Id == 0)
                    _dbContext.Servicios.Add(domObj);

                _dbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public string ValidDelete(Servicio domObj)
        {
            throw new NotImplementedException();
        }

        public string ValidSave(Servicio domObj)
        {
            if (domObj.Nombre.Length > 50)
                return "El nombre no puede superar los 50 caracteres";

            return "";
        }
    }
}
