using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Models
{
    [Table("recipes", Schema = "MEal")]
    public class Recipe : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public int? PrepTime { get; set; }

        public int? CookTime { get; set; }

        // Foreign Key Relations
        [Required]
        public Meal Meal { get; set; } = null!;

        public List<RecipeIngredient>? RecipeIngredients { get; set; }

        public List<RecipeStep>? RecipeSteps { get; set; }
    }
}
