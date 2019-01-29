using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
    public class Donation : BaseEntity
    {
        public Donation()
        {
            this.Plantings = new HashSet<Planting>();
        }
        [Display(Name = "Bağış Sahibi")]
        public string Owner { get; set; }
        [Display(Name = "Fidan")]
        public int TreeTypeId { get; set; }
        [Display(Name = "Fidan")]
        public virtual TreeType TreeType { get; set; }
        [Display(Name = "Bölge")]
        public int RegionId { get; set; }
        [Display(Name = "Bölge")]
        public virtual Region Region { get; set; }
        [Display(Name = "Adet")]
        public int Quantity { get; set; }
        [Display(Name = "Fidan Adı")]
        public string TreeName { get; set; }
        [Display(Name = "Fidan Açıklaması")]
        public string TreeDescription { get; set; }
        [Display(Name = "Fidan Fiyatı")]
        public decimal TreePrice { get; set; }
        [Display(Name = "Dikim Fiyatı")]
        public decimal PlantingPrice { get; set; }
        [Display(Name = "Komisyon")]
        public decimal Commision { get; set; }
        [Display(Name = "Birim Fiyat")]
        public decimal UnitPrice { get { return TreePrice + PlantingPrice + Commision; } }
        [Display(Name = "Toplam Fiyat")]
        public decimal TotalPrice { get { return UnitPrice * Quantity; } }
        [Display(Name = "Dikimler")]
        public virtual ICollection<Planting> Plantings { get; set; }
    }
}
