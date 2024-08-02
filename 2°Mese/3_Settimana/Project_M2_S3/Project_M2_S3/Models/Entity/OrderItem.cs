using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_M2_S3.Models.Entity
{
    public class OrderItem
    {
        /// <summary>
        /// Chiave.
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Prodotto ordinato.
        /// </summary>

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        /// <summary>
        /// Ordine al quale appartiene la riga.
        /// </summary>
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public  Order Order { get; set; }
        /// <summary>
        /// Quantità ordinata.
        /// </summary>
        public int Quantity { get; set; }
    }
}
