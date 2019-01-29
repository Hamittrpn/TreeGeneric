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
    public class TreeTypeService : ITreeTypeService
    {
        private readonly IRepository<TreeType> Repository;
        public TreeTypeService(IRepository<TreeType> repository)
        {
            this.Repository = repository;
        }
        public void Delete(int id)
        {
            var treeTypeToDelete = Repository.Find(id);
            if (treeTypeToDelete != null)
            {
                Repository.Delete(treeTypeToDelete);
            }
        }

        public TreeType Find(int id)
        {
            return Repository.Find(id);
        }

        public TreeType Find(Expression<Func<TreeType, bool>> where)
        {
            return Repository.Find(where);
        }

        public IEnumerable<TreeType> GetAll(Expression<Func<TreeType, bool>> where)
        {
            return Repository.GetAll(where);
        }

        public IEnumerable<TreeType> GetAll()
        {
            return Repository.GetAll(r => true);
        }

        public void Insert(TreeType treeType)
        {
            Repository.Insert(treeType);
        }

        public void Update(TreeType treeType)
        {
            Repository.Update(treeType);
        }
    }
}
