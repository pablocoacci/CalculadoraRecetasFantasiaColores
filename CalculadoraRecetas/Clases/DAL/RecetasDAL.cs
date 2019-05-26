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
    public class RecetasDAL : BaseDAL, IObjectDAL<Receta>
    {
        public RecetasDAL() : base() { }

        public bool Delete(int id)
        {
            try
            {
                var receta = _dbContext.Recetas.Where(a => a.Id == id).FirstOrDefault();

                if (receta != null)
                {
                    string error = ValidDelete(receta);

                    if (error != string.Empty)
                        throw new Exception("Error durante el Delete: " + error);

                    _dbContext.Recetas.Remove(receta);
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

        public bool Delete(Receta rec)
        {
            return Delete(rec.Id);
        }

        public IList<Receta> GetAllObj()
        {
            return _dbContext.Recetas.ToList();
        }

        public Receta GetObjtById(int id)
        {
            return _dbContext.Recetas.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool Save(Receta rec)
        {
            try
            {
                string error = ValidSave(rec);

                if (error != string.Empty)
                    throw new Exception("Error durante el Save: " + error);

                if (rec.Id == 0)
                    _dbContext.Recetas.Add(rec);

                _dbContext.SaveChanges();

                var ingEliminar = rec.Ingredientes.Where(a => a.IngredienteEliminado).ToList();

                foreach (Ingrediente ing in ingEliminar)
                {
                    if (ing.Id != 0)
                    {
                        _dbContext.Ingredientes.Remove(ing);
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

        public string ValidDelete(Receta rec)
        {
            return String.Empty;
        }

        public string ValidSave(Receta rec)
        {
            if (rec == null)
                return "Error. La Receta es null";

            if (rec.Nombre == "" || rec.Nombre == string.Empty)
                return "El Nombre no puede ser vacio. Es un campo obligatorio";

            if (rec.Nombre.Length > 50)
                return "El Nombre no puede superar los 50 caracteres";

            if (rec.Id == 0 && _dbContext.Recetas.Where(a => a.Nombre == rec.Nombre).Any())
                return "Ya existe una Receta con ese mismo Nombre";

            if (rec.Descripcion.Length > 1500)
                return "La Descripcion no puede contener mas de 1500 caracteres";

            if (rec.CantidadComensales <= 0)
                return "La cantidad de comensales no puede ser menor o igual a 0";

            if (rec.CostoIndirectoPorce < 0)
                return "El porcentaje de costo indirecto no puede ser negativo";

            if (rec.UtilidadPorce < 0)
                return "El porcentaje de utilidad no puede ser negativo";

            if (rec.Id == 0 && !rec.Ingredientes.Any())
                return "No se puede guardar una Receta sin ingredientes";

            if (/*rec.Id == 0 &&*/ rec.Ingredientes.Where(a => a.Cantidad <= 0).Any())
                return "No se puede guardar la Receta. Alguno de los ingredientes tiene cantidad igual o menor a 0";

            return String.Empty;
        }
    }
}
