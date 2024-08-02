using System.ComponentModel.DataAnnotations;

namespace Project_M2_S3.Models
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        [StringLength(80)]
        public required string Email { get; set; }
        [Required]
        [StringLength(20)]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
