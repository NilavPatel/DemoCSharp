using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class UserViewModel
    {
        [Required]
        [MaxLength(10)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(10)]
        [MinLength(3)]
        [RegularExpression("[a-zA-Z0-9]{3,10}", ErrorMessage = "Invalid password format")]
        public string Password { get; set; }
    }
}