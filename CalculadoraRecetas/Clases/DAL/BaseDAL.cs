using CalculadoraRecetas.Clases.Mappings;

namespace CalculadoraRecetas.Clases.DAL
{
    public abstract class BaseDAL
    {
        protected CalculadoraDataContext _dbContext;

        public BaseDAL()
        {
            ResetContext();
        }

        public void ResetContext()
        {
            _dbContext = new CalculadoraDataContext();
        }

        public CalculadoraDataContext GetContext()
        {
            return _dbContext;
        }
    }
}
