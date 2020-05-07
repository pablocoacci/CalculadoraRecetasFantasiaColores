using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.StaticHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraRecetas.Clases.DAL
{
    public class MateriasPrimasDAL : BaseDAL, IObjectDAL<MateriaPrima>
    {
        public MateriasPrimasDAL() : base() { }

        public bool Delete(int id)
        {
            try
            {
                var mp = _dbContext.MateriasPrimas.Where(a => a.Id == id).FirstOrDefault();

                if (mp != null)
                {
                    string error = ValidDelete(mp);

                    if (error != string.Empty)
                        throw new Exception("Error durante el Delete: " + error);

                    _dbContext.MateriasPrimas.Remove(mp);
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

        public bool Delete(MateriaPrima mp)
        {
            return Delete(mp.Id);
        }

        public IList<MateriaPrima> GetAllObj()
        {
            return _dbContext.MateriasPrimas.ToList();
        }

        public MateriaPrima GetObjtById(int id)
        {
            return _dbContext.MateriasPrimas.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool Save(MateriaPrima mp)
        {
            try
            {
                string error = ValidSave(mp);

                if (error != string.Empty)
                    throw new Exception("Error durante el Save: " + error);

                if (mp.Id == 0)
                    _dbContext.MateriasPrimas.Add(mp);

                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public string ValidSave(MateriaPrima mp)
        {
            if (mp == null)
                return "Error. Materia Prima es null";

            if (mp.Nombre == "" || mp.Nombre == String.Empty)
                return "El Nombre no puede ser vacio. Es un campo obligatorio";

            if (mp.Nombre.Length > 50)
                return "El Nombre no puede superar los 50 caracteres";

            if (mp.Id == 0 && _dbContext.MateriasPrimas.Where(a => a.Nombre == mp.Nombre).Any())
                return "Ya existe otra Materia Prima con el mismo Nombre";

            if (mp.Abreviatura == "" || mp.Abreviatura == string.Empty)
                return "La Abreviatura no puede ser vacio. Es un campo obligatorio";

            if (mp.Abreviatura.Length > 10)
                return "La Abreviatura no puede superar los 10 caracteres";

            if (mp.Id == 0 && _dbContext.MateriasPrimas.Where(a => a.Abreviatura == mp.Abreviatura).Any())
                return "Ya existe otra Materia Prima con la misma Abreviatura";

            if (mp.Precio <= 0)
                return "El precio no puede ser menor o igual a 0";

            return string.Empty;
        }

        public string ValidDelete(MateriaPrima mp)
        {
            if (_dbContext.Ingredientes.Where(a => a.Id_MateriaPrima == mp.Id).Any())
                return "No se puede eliminar la Materia Prima ya que existen Recetas que la utilizan. Elimine las recetas primero";

            return string.Empty;
        }
    }
}
