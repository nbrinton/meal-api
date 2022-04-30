using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Models
{
    [Table("ingredients", Schema = "MEal")]
    public class Ingredient : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        // Foreign Key Relations
        [Required]
        public Section Section { get; set; } = null!;
    }
}
