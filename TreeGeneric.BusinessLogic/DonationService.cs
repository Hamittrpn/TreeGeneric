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
    public class DonationService : IDonationService
    {
        private readonly IRepository<Donation> Repository;
        public DonationService(IRepository<Donation> repository)
        {
            this.Repository = repository;
        }
        public void Delete(int id)
        {
            var donationToDelete = Repository.Find(id);
            if (donationToDelete != null)
            {
                Repository.Delete(donationToDelete);
            }
        }

        public Donation Find(int id)
        {
            return Repository.Find(id);
        }

        public Donation Find(Expression<Func<Donation, bool>> where)
        {
            return Repository.Find(where);
        }

        public IEnumerable<Donation> GetAll(Expression<Func<Donation, bool>> where)
        {
            return Repository.GetAll(where);
        }

        public IEnumerable<Donation> GetAll()
        {
            return Repository.GetAll(r => true);
        }

        public void Insert(Donation donation)
        {
            Repository.Insert(donation);
        }

        public void Update(Donation donation)
        {
            Repository.Update(donation);
        }
    }
}
