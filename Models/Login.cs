using System.ComponentModel.DataAnnotations;
namespace SoundBag.Models
{
    public class Login
    {
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email:")]
        public string LoginEmail {get;set;}
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string LoginPassword {get;set;}
    }
}