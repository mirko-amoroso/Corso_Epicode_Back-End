using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_M2_S3.Models.Entity
{
    public class Order
    {
        /// <summary>
        /// Chiave.
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Data dell'ordine.
        /// </summary>
        public DateTime PlacedAt { get; set; } = DateTime.Now;
        /// <summary>
        /// Utente che ha effettuato l'ordine.
        /// </summary>
        
        [ForeignKey("Order")]
        public int UserId { get; set; }
        public User User { get; set; }
        /// <summary>
        /// Indica se l'ordine è stato evaso.
        /// </summary>
        public bool Done { get; set; }
        /// <summary>
        /// Indirizzo di consegna.
        /// </summary>
        [Required]
        [StringLength(80)]
        public required string Address { get; set; }
        /// <summary>
        /// Annotazioni.
        /// </summary>
        [StringLength(255)]
        public string? Notes { get; set; }
        /// <summary>
        /// Prodotti ordinati.
        /// </summary>
        public List<OrderItem> Items { get; set; } = [];
    }
}
