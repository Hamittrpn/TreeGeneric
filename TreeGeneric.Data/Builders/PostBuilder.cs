using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.Data.Builders
{
    public class PostBuilder
    {
        /*
        1.Entity de PlantingId ? olmaz ise burada--> hasoptional ve withmanyoptionaldependent mı olucak?
         */
        public PostBuilder(EntityTypeConfiguration<Post> entity)
        {
            entity.Property(p => p.Name).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Photo).IsRequired().HasMaxLength(200);
            entity.HasRequired(h => h.Planting).WithMany(w => w.Posts).HasForeignKey(h => h.PlantingId);
        }
    }
}
