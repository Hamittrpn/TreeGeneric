using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.Data.Builders
{
    public class PlantingBuilder
    {
        public PlantingBuilder(EntityTypeConfiguration<Planting> entity)
        {
            entity.Property(p => p.Lat).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Long).IsRequired().HasMaxLength(200);
            entity.Property(p => p.PlantingCode).IsRequired().HasMaxLength(200);
            entity.HasRequired(h => h.Donation).WithMany(w => w.Plantings).HasForeignKey(h => h.DonationId);
            entity.HasRequired(h => h.PlanterUser).WithMany(w => w.Plantings).HasForeignKey(h => h.UserId);
            entity.HasRequired(h => h.Region).WithMany(w => w.Plantings).HasForeignKey(h => h.RegionId).WillCascadeOnDelete(false);
        }
    }
}
