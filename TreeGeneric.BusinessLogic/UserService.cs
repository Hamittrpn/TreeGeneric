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
    public class UserService : IUserService
    {
        private readonly IRepository<User> Repository;
        public UserService(IRepository<User> repository)
        {
            this.Repository = repository;
        }
        public void Delete(int id)
        {
            var userToDelete = Repository.Find(id);
            if (userToDelete != null)
            {
                Repository.Delete(userToDelete);
            }
        }

        public User Find(int id)
        {
            return Repository.Find(id);
        }

        public User Find(Expression<Func<User, bool>> where)
        {
            return Repository.Find(where);
        }

        public User Find(string lastName)
        {
            return Repository.Find(f => f.LastName.Contains(lastName));
        }

        public IEnumerable<User> GetAll(Expression<Func<User, bool>> where)
        {
            return Repository.GetAll(where);
        }

        public IEnumerable<User> GetAll()
        {
            return Repository.GetAll(r => true);
        }

        public void Insert(User user)
        {
            Repository.Insert(user);
        }

        public void Update(User user)
        {
            Repository.Update(user);
        }
    }
}
