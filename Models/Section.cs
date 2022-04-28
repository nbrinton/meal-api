using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Models
{
    [Comment("Table representing grocery store sections such as Dairy, Bulk, Produce, etc.")]
    [Table("sections", Schema = "MEal")]
    public class Section : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        // Foreign Key Relations
        public List<Ingredient>? Ingredients { get; set; }
    }
}
