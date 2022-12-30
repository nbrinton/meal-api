using MEalAPI.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Entities
{
    public abstract class ECreatedUpdatedEntity : ICreatedUpdated
    {
        [Column("created")]
        public DateTimeOffset Created { get; set; }

        [Column("updated")]
        public DateTimeOffset Updated { get; set; }
    }
}
