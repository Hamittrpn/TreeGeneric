using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.BusinessLogic
{
    public interface IPlantingService
    {
        void Insert(Planting planting);
        void Update(Planting planting);
        void Delete(int id);
        Planting Find(int id);
        IEnumerable<Planting> GetAll();
        Planting Find(Expression<Func<Planting, bool>> where);
        IEnumerable<Planting> GetAll(Expression<Func<Planting, bool>> where);
    }
}
