using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Models
{
    public interface ICreatedUpdated
    {
        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Updated { get; set; }
    }
}
