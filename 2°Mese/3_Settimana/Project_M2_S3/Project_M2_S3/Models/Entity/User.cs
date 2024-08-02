using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_M2_S3.Models.Entity
{
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        /// <summary>
        /// Chiave.
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Nome utente.
        /// </summary>
        [Required]
        [StringLength(20)]
        public required string Name { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        [Required]
        [StringLength(20)]
        public required string Password { get; set; }

        /// <summary>
        /// Ruoli utente.
        /// </summary>
        public List<UserRole> UsersRoles { get; set; } = new List<UserRole>();

        /// <summary>
        /// Tutti gli ordini di un utente.
        /// </summary>
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}

