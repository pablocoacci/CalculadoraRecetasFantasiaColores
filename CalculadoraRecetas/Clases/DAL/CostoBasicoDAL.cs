using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.StaticHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraRecetas.Clases.DAL
{
    public class CostoBasicoDAL : BaseDAL, IObjectDAL<CostoBasico>
    {
        public bool Delete(int id)
        {
            try
            {
                var costoServ = _dbContext.CostosBasicos.Where(a => a.Id == id).FirstOrDefault();

                if (costoServ != null)
                {
                    string error = ValidDelete(costoServ);

                    if (error != string.Empty)
                        throw new Exception("Error durante el Delete: " + error);

                    _dbContext.CostosBasicos.Remove(costoServ);
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

        public bool Delete(CostoBasico domObj)
        {
            return Delete(domObj.Id);
        }

        public IList<CostoBasico> GetAllObj()
        {
            return _dbContext.CostosBasicos.ToList();
        }

        public CostoBasico GetObjtById(int id)
        {
            return _dbContext.CostosBasicos.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool Save(CostoBasico domObj)
        {
            try
            {
                if (string.IsNullOrEmpty(domObj.Notas))
                    domObj.Notas = "";

                string error = ValidSave(domObj);

                if (domObj.Id == 0)
                    _dbContext.CostosBasicos.Add(domObj);

                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public string ValidDelete(CostoBasico domObj)
        {
            return "";
        }

        public string ValidSave(CostoBasico domObj)
        {
            if (string.IsNullOrEmpty(domObj.Nombre))
                return "El nombre del costo no puede ser vacio";
            if (domObj.Nombre.Length > 50)
                return "El nombre no puede superar los 50 caracteres";
            if (domObj.Notas.Length > 1500)
                return "Las notas no pueden tener mas de 1500 caracteres";
            if (domObj.CostoMonto < 0)
                return "El monto del costo no puede ser negativo";

            return "";
        }
    }
}
