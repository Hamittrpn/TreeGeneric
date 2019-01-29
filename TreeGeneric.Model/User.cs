using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
    public class User : BaseEntity
    {
        [Display(Name = "Ad")]
        public string FirstName { get; set; }
        [Display(Name = "Soyad")]
        public string LastName { get; set; }
        [Display(Name = "E-posta")]
        public string Email { get; set; }
        [Display(Name = "Parola")]
        public string Password { get; set; }
        [Display(Name = "E-posta Doğrulandı Mı?")]
        public bool IsEmailConfirmed { get; set; }
        [Display(Name = "E-posta Doğrulama Kodu")]
        public string EmailConfirmationCode { get; set; }
        [Display(Name = "E-posta Doğrulama Tarihi")]
        public DateTime? EmailConfirmationDate { get; set; }
        [Display(Name = "Cinsiyet")]
        public Gender? Gender { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Kullanıcı Türü")]
        public UserType UserType { get; set; }
        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; }
        [Display(Name = "Dikim")]
        public virtual ICollection<Planting> Plantings { get; set; }
    }
}
