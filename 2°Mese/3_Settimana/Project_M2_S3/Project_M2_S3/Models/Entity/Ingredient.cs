using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_M2_S3.Models.Entity
{
    [Index(nameof(Name), IsUnique = true)]
    public class Ingredient
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
        /// Righe di relazione molti-a-molti con Product.
        /// </summary>
        public List<IngredienteProd> IngredienteProds { get; set; } = new();
    }
}
