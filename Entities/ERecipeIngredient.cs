using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Entities
{
    [Comment("Table tracking ingredients as used in a specific recipe, including the quantity, units of measurement, and if the ingredient is a 'staple' (should be excluded from generated grocery list")]
    [Table("recipe_ingredients", Schema = "meal")]
    public class ERecipeIngredient : ECreatedUpdatedEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("units")]
        public string Units { get; set; } = null!;

        [Required]
        [Column("quantity")]
        public double Quantity { get; set; }

        [Column("is_staple")]
        public bool IsStaple { get; set; }

        // Foreign Key Relations
        [Required]
        public EIngredient Ingredient { get; set; } = null!;
    }
}
