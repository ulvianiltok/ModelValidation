using System.ComponentModel.DataAnnotations;

namespace MOdelValidation.Models
{
    public class Kullanici
    {
        [Required(ErrorMessage = "Ad alanı boş bırakılamaz")]
        [StringLength(50,ErrorMessage = "50 karakterden fazla girilmez")]
        public string Ad { get; set; }

        [Required(ErrorMessage ="Soyad alanı boş bırakılamaz")]
        [StringLength(50,ErrorMessage ="3 ile 50 karakter arası giriniz",MinimumLength = 3)]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Eposta adresi boş bırakılamaz.")]
        [EmailAddress(ErrorMessage = "Geçerli eposta adresi giriniz.")]
        public string Eposta { get; set; }

        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz.")]
        [Phone(ErrorMessage = "Geçerli telefon numarası giriniz.")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Harfve sayıdan oluşan 8 karakter giriniz.")]
        public string Sifre { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Compare("Sifre", ErrorMessage = "Şifreler aynı değil.")]
        public string SifreTekrar { get; set; }
    }
}
