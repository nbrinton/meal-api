using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Models
{
    [NotMapped]
    public abstract class BaseEntity
    {
        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }
    }
}
