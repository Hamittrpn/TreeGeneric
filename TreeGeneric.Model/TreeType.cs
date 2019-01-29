using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
    public class TreeType : BaseEntity
    {
        public TreeType()
        {
            this.Donations = new HashSet<Donation>();
            this.Regions = new HashSet<Region>();
        }
        [Display(Name = "Fidan Adı")]
        public string Name { get; set; }
        [Display(Name = "Fidan Açıklaması")]
        public string Description { get; set; }
        [Display(Name = "Resim")]
        public string Photo { get; set; }
        [Display(Name = "Fidan Fiyatı")]
        public decimal TreePrice { get; set; }
        [Display(Name = "Dikim Fiyatı")]
        public decimal PlantingPrice { get; set; }
        [Display(Name = "Komisyon")]
        public decimal Commision { get; set; }
        [Display(Name = "Birim Fiyatı")]
        public decimal UnitPrice { get { return TreePrice + PlantingPrice + Commision; } }
        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; }
        [Display(Name = "Stokta Kalan Adet")]
        public int AvailabilityCount { get; set; }
        [Display(Name = "Bağışlar")]
        public virtual ICollection<Donation> Donations { get; set; }
        [Display(Name = "Bölgeler")]
        public virtual ICollection<Region> Regions { get; set; }
    }
}
