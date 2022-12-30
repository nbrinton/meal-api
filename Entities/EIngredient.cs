using MEalAPI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Entities
{
    [Table("ingredients", Schema = "meal")]
    public class EIngredient : EBaseEntity, IIngredient
    {
        // Foreign Key Relations
        [Required]
        public ESection Section { get; set; } = null!;
    }
}
