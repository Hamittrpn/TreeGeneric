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
    public class PostService : IPostService
    {
        private readonly IRepository<Post> Repository;
        public PostService(IRepository<Post> repository)
        {
            this.Repository = repository;
        }
        public void Delete(int id)
        {
            var postToDelete = Repository.Find(id);
            if (postToDelete != null)
            {
                Repository.Delete(postToDelete);
            }
        }

        public Post Find(int id)
        {
            return Repository.Find(id);
        }

        public Post Find(Expression<Func<Post, bool>> where)
        {
            return Repository.Find(where);
        }

        public Post FindByNme(string name)
        {
            return Repository.Find(r => r.Name.Contains(name));
        }

        public IEnumerable<Post> GetAll(Expression<Func<Post, bool>> where)
        {
            return Repository.GetAll(where);
        }

        public IEnumerable<Post> GetAll()
        {
            return Repository.GetAll(r => true);
        }

        public void Insert(Post post)
        {
            Repository.Insert(post);
        }

        public void Update(Post post)
        {
            Repository.Update(post);
        }
    }
}
