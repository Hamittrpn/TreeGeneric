using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
    public class Region : BaseEntity
    {
        public Region()
        {
            this.Donations = new HashSet<Donation>();
            this.Plantings = new HashSet<Planting>();
            this.TreeTypes = new HashSet<TreeType>();
        }
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Fotoğraf")]
        public string Photo { get; set; }
        [Display(Name = "Enlem")]
        public string Lat { get; set; }
        [Display(Name = "Boylam")]
        public string Long { get; set; }
        [Display(Name = "Kapasite")]
        public int Capacity { get; set; }
        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; }
        [Display(Name = "Bağışlar")]
        public virtual ICollection<Donation> Donations { get; set; }
        [Display(Name = "Dikimelr")]
        public virtual ICollection<Planting> Plantings { get; set; }
        [Display(Name = "Ağaç Türleri")]
        public virtual ICollection<TreeType> TreeTypes { get; set; }
    }
}
