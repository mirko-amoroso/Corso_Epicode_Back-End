using System.ComponentModel.DataAnnotations.Schema;

namespace Project_M2_S3.Models.Entity
{
    public class IngredienteProd
    {
        // Chiave esterna verso l'entità Ingredient
        public int IngredientsId { get; set; }
        [ForeignKey("IngredientsId")]
        public Ingredient Ingredient { get; set; } // Proprietà di navigazione

        // Chiave esterna verso l'entità Product

        public int ProductsId { get; set; }
        [ForeignKey("ProductsId")]
        public Product Product { get; set; } // Proprietà di navigazione
    }
}
