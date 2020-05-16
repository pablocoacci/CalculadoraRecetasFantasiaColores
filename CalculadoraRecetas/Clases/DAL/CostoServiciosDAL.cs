using CalculadoraRecetas.Clases.Dominio;
using CalculadoraRecetas.Clases.StaticHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraRecetas.Clases.DAL
{
    public class CostoServiciosDAL : BaseDAL, IObjectDAL<CostoServicio>
    {
        public bool Delete(int id)
        {
            try
            {
                var costoServ = _dbContext.CostoServicios.Where(a => a.Id == id).FirstOrDefault();

                if (costoServ != null)
                {
                    string error = ValidDelete(costoServ);

                    if (error != string.Empty)
                        throw new Exception("Error durante el Delete: " + error);

                    _dbContext.CostoServicios.Remove(costoServ);
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

        public bool Delete(CostoServicio domObj)
        {
            return Delete(domObj.Id);
        }

        public IList<CostoServicio> GetAllObj()
        {
            return _dbContext.CostoServicios.ToList();
        }

        public CostoServicio GetObjtById(int id)
        {
            return _dbContext.CostoServicios.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool Save(CostoServicio domObj)
        {
            try
            {
                if (string.IsNullOrEmpty(domObj.Notas))
                    domObj.Notas = "";

                string error = ValidSave(domObj);

                if (domObj.Id == 0)
                    _dbContext.CostoServicios.Add(domObj);

                _dbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }
        }

        public string ValidDelete(CostoServicio domObj)
        {
            return "";
        }

        public string ValidSave(CostoServicio domObj)
        {
            if (domObj.PrecioFactura <= 0)
                return "El precio de la factura debe ser mayor a 0";

            if (domObj.HorasLaborablesMensual != null)
            {
                if (domObj.HorasLaborablesMensual <= 0)
                    return "Las horas laborales mensuales deben ser mayor a 0";
            }

            if (domObj.IncidenciaPorce != null)
            {
                if (domObj.IncidenciaPorce <= 0)
                    return "El porcentaje de incidencia debe de ser mayor a 0";
            }

            if (domObj.CostoTotal <= 0)
                return "El costo total debe de ser mayor a 0";

            if (domObj.Notas.Length > 1000)
                return "Las notas no pueden superar los 1000 caracteres";

            return "";
        }
    }
}
