using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Models
{
    [Comment("Table representing steps within a recipe's directions.")]
    [Table("recipe_steps", Schema = "MEal")]
    public class RecipeStep : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Order { get; set; }

        [Required]
        public string Content { get; set; } = null!;
    }
}
