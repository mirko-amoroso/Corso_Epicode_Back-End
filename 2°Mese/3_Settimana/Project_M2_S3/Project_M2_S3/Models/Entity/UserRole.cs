using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_M2_S3.Models.Entity
{
    public class UserRole
    {
        // Cambia questi tipi di dati a int per riflettere le chiavi primarie corrette
        public int UserId { get; set; }
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("UsersRoles")]
        public virtual Role Role { get; set; } = null!;

        [ForeignKey("UserId")]
        [InverseProperty("UsersRoles")]
        public virtual User User { get; set; } = null!;
    }

}
