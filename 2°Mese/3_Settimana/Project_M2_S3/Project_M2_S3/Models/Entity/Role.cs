using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_M2_S3.Models.Entity
{
    public class Role
    {
        /// Chiave.
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// Nome del ruolo.
        
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }
        
        /// Utenti che appartengono al ruolo.
        public List<UserRole> UsersRoles { get; set; } = new List<UserRole>();
    }
}
