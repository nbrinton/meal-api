using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Models
{
    [Comment("Table tracking ingredients as used in a specific recipe, including the quantity, units of measurement, and if the ingredient is a 'staple' (should be excluded from generated grocery list")]
    [Table("recipe_ingredients", Schema = "MEal")]
    public class RecipeIngredient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Units { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }

        public bool IsStaple { get; set; }

        // Foreign Key Relations
        [Required]
        public Ingredient Ingredient { get; set; } = null!;

        [Required]
        public Recipe Recipe { get; set; } = null!;
    }
}
