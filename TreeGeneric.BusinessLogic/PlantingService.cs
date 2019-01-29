using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Data;
using TreeGeneric.Model;

namespace TreeGeneric.BusinessLogic
{
    public class PlantingService : IPlantingService
    {
        private readonly IRepository<Planting> Repository;
        public PlantingService(IRepository<Planting> repository)
        {
            this.Repository = repository;
        }

        public void Delete(int id)
        {
            var plantingToDelete = Repository.Find(id);
            if (plantingToDelete != null)
            {
                Repository.Delete(plantingToDelete);
            }
        }

        public Planting Find(int id)
        {
            return Repository.Find(id);
        }

        public Planting Find(Expression<Func<Planting, bool>> where)
        {
            return Repository.Find(where);
        }

        public IEnumerable<Planting> GetAll(Expression<Func<Planting, bool>> where)
        {
            return Repository.GetAll(where);
        }

        public IEnumerable<Planting> GetAll()
        {
            return Repository.GetAll(r => true);
        }

        public void Insert(Planting planting)
        {
            Repository.Insert(planting);
        }

        public void Update(Planting planting)
        {
            Repository.Update(planting);
        }
    }
}
