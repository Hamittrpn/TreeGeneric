using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.Data.Builders
{
    public class UserBuilder
    {
        public UserBuilder(EntityTypeConfiguration<User> entity)
        {
            entity.Property(p => p.FirstName).IsRequired().HasMaxLength(200);
            entity.Property(p => p.LastName).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Email).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Password).IsRequired().HasMaxLength(200);
            entity.Property(p => p.EmailConfirmationCode).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Phone).IsRequired().HasMaxLength(200);
        }
    }
}
