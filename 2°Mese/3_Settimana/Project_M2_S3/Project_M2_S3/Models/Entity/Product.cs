using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_M2_S3.Models.Entity
{
    public class Product
    {
        /// <summary>
        /// Chiave.
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Denominazione.
        /// </summary>
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        /// <summary>
        /// Prezzo.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Foto.
        /// </summary>
        [Required]
        public required string Photo { get; set; }

        /// <summary>
        /// Tempo di consegna in minuti.
        /// </summary>
        [Range(0, 60)]
        public int DeliveryTimeInMinutes { get; set; }

        /// <summary>
        /// Righe di ordini nei quali il prodotto appare.
        /// </summary>
        public List<OrderItem> OrderedItems { get; set; } = new();

        /// <summary>
        /// Righe di relazione molti-a-molti con Ingredient.
        /// </summary>
        public List<IngredienteProd> IngredienteProds { get; set; } = new();
    }
}
