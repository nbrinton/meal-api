using MEalAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Entities
{
    [Table("recipe_steps", Schema = "meal")]
    [Comment("Table representing steps within a recipe's directions.")]
    public class RecipeStep : CreatedUpdatedEntity, IRecipeStep
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public int Order { get; set; }

        [Required]
        public string Content { get; set; } = null!;
    }
}
