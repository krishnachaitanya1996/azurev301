using System.ComponentModel.DataAnnotations;

namespace MyStayMVC.Models
{
    public class Login
    {
        public int ID { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
    }
}
