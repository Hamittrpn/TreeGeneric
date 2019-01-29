using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.Data.Builders
{
    public class DonationBuilder
    {
        public DonationBuilder(EntityTypeConfiguration<Donation> entity)
        {
            entity.Property(p => p.Owner).IsRequired().HasMaxLength(200);
            entity.Property(p => p.TreeName).IsRequired().HasMaxLength(200);
            entity.HasRequired(p => p.TreeType).WithMany(w => w.Donations).HasForeignKey(p => p.TreeTypeId);
            entity.HasRequired(p => p.Region).WithMany(w => w.Donations).HasForeignKey(p => p.RegionId);
        }
    }
}
