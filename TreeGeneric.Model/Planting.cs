using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
    public class Planting : BaseEntity
    {
        public Planting()
        {
            this.Posts = new HashSet<Post>();
        }
        [Display(Name = "Bağış")]
        public int DonationId { get; set; }
        [Display(Name = "Bağış")]
        public virtual Donation Donation { get; set; }
        [Display(Name = "Dikici Kullanıcı")]
        public int UserId { get; set; }
        [Display(Name = "Dikici Kullanıcı")]
        public virtual User PlanterUser { get; set; }
        [Display(Name = "Dikim Tarihi")]
        public DateTime PlantingDate { get; set; }
        [Display(Name = "Enlem")]
        public string Lat { get; set; }
        [Display(Name = "Boylam")]
        public string Long { get; set; }
        [Display(Name = "Dikim Kodu")]
        public string PlantingCode { get; set; }
        [Display(Name = "Bölge")]
        public int RegionId { get; set; }
        [Display(Name = "Bölge")]
        public virtual Region Region { get; set; }
        [Display(Name = "Paylaşım")]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
