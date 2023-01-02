using MEalAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Entities
{
    [Table("recipes", Schema = "meal")]
    [Comment("Table containing user recipes.")]
    public class Recipe : BaseEntity, IRecipe
    {
        public int? PrepTime { get; set; }

        public int? CookTime { get; set; }

        // Foreign Key Relations
        [Required]
        public Meal Meal { get; set; } = null!;

        public List<RecipeIngredient>? RecipeIngredients { get; set; }

        public List<RecipeStep>? RecipeSteps { get; set; }
    }
}
