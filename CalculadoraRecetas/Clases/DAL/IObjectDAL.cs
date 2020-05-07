using CalculadoraRecetas.Clases.Mappings;
using System.Collections.Generic;

namespace CalculadoraRecetas.Clases.DAL
{
    public interface IObjectDAL<T>
    {
        string ValidSave(T domObj);
        string ValidDelete(T domObj);
        bool Save(T domObj);
        T GetObjtById(int id);
        IList<T> GetAllObj();
        bool Delete(int id);
        bool Delete(T domObj);
        void ResetContext();
        CalculadoraDataContext GetContext();
    }
}
