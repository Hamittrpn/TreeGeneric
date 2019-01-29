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
    public class RegionService : IRegionService
    {
        private readonly IRepository<Region> Repository;
        public RegionService(IRepository<Region> repository)
        {
            this.Repository = repository;
        }
        public void Delete(int? id)
        {
            var regionToDelete = Repository.Find(id);
            if (regionToDelete != null)
            {
                Repository.Delete(regionToDelete);
            }
        }

        public Region Find(int? id)
        {
            return Repository.Find(id);
        }

        public Region Find(string name)
        {
            return Repository.Find(r => r.Name.Contains(name));
        }

        public Region Find(Expression<Func<Region, bool>> where)
        {
            return Repository.Find(where);
        }

        public IEnumerable<Region> GetAll(Expression<Func<Region, bool>> where)
        {
            return Repository.GetAll(where);
        }

        public IEnumerable<Region> GetAll()
        {
            return Repository.GetAll(r => true);
        }

        public void Insert(Region region)
        {
            Repository.Insert(region);
        }

        public void Update(Region region)
        {
            Repository.Update(region);
        }
    }
}
