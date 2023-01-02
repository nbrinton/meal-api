using MEalAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Entities
{
    [Table("ingredients", Schema = "meal")]
    [Comment("Table representing stand-alone ingredients.")]
    public class Ingredient : BaseEntity, IIngredient
    {
        // Foreign Key Relations
        [Required]
        public Section Section { get; set; } = null!;
    }
}
