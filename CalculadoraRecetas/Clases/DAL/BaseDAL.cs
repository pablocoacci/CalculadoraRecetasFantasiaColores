using CalculadoraRecetas.Clases.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
