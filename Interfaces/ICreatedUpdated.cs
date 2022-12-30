using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Interfaces
{
    public interface ICreatedUpdated
    {
        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Updated { get; set; }
    }
}
