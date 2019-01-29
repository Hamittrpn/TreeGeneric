using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.Data.Builders
{
    public class RegionBuilder
    {
        public RegionBuilder(EntityTypeConfiguration<Region> entity)
        {
            entity.Property(p => p.Name).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Photo).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Lat).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Long).IsRequired().HasMaxLength(200);
        }
    }
}
