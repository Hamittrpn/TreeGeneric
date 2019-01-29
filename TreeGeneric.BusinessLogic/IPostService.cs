using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.BusinessLogic
{
    public interface IPostService
    {
        void Insert(Post post);
        void Update(Post post);
        void Delete(int id);
        Post Find(int id);
        Post FindByNme(string name);
        Post Find(Expression<Func<Post, bool>> where);
        IEnumerable<Post> GetAll(Expression<Func<Post, bool>> where);
        IEnumerable<Post> GetAll();
    }
}
