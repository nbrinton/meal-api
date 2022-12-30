using MEalAPI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Entities
{
    [Table("recipes", Schema = "meal")]
    public class ERecipe : EBaseEntity, IRecipe
    {
        [Column("prep_time")]
        public int? PrepTime { get; set; }

        [Column("cook_time")]
        public int? CookTime { get; set; }

        // Foreign Key Relations
        [Required]
        public EMeal Meal { get; set; } = null!;

        public List<ERecipeIngredient>? RecipeIngredients { get; set; }

        public List<ERecipeStep>? RecipeSteps { get; set; }
    }
}
