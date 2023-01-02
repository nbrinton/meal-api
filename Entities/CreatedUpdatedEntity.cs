using MEalAPI.Interfaces;

namespace MEalAPI.Entities
{
    public abstract class CreatedUpdatedEntity : ICreatedUpdated
    {
        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Updated { get; set; }
    }
}
