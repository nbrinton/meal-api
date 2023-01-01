using MEalAPI.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MEalAPI.Entities
{
    public abstract class BaseEntity : CreatedUpdatedEntity, IBase
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
