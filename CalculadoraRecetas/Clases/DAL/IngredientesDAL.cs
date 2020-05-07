using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.StaticHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraRecetas.Clases.DAL
{
    public class IngredientesDAL : BaseDAL, IObjectDAL<Ingrediente>
    {
        public IngredientesDAL() : base() { }

        public bool Delete(int id)
        {
            try
            {
                var ing = _dbContext.Ingredientes.Where(a => a.Id == id).FirstOrDefault();

                if (ing != null)
                {
                    var error = ValidDelete(ing);
                    if (error != string.Empty)
                        throw new Exception("Error durante el Delete: " + error);

                    _dbContext.Ingredientes.Remove(ing);
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

        public bool Delete(Ingrediente ing)
        {
            return Delete(ing.Id);
        }

        public IList<Ingrediente> GetAllObj()
        {
            return _dbContext.Ingredientes.ToList();
        }

        public Ingrediente GetObjtById(int id)
        {
            return _dbContext.Ingredientes.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool Save(Ingrediente ing)
        {
            try
            {
                string error = ValidSave(ing);

                if (error != string.Empty)
                    throw new Exception("Error durante el Save: " + error);

                if (ing.Id == 0)
                    _dbContext.Ingredientes.Add(ing);

                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public string ValidDelete(Ingrediente ing)
        {
            return string.Empty;
        }

        public string ValidSave(Ingrediente ing)
        {
            if (ing.Cantidad <= 0)
                return "La Cantidad debe de ser mayot a 0";

            return string.Empty;
        }
    }
}
