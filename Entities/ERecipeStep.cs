using MEalAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Entities
{
    [Comment("Table representing steps within a recipe's directions.")]
    [Table("recipe_steps", Schema = "meal")]
    public class ERecipeStep : ECreatedUpdatedEntity, IRecipeStep
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("order")]
        public int Order { get; set; }

        [Required]
        [Column("content")]
        public string Content { get; set; } = null!;
    }
}
