using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Interfaces
{
    public interface IBase : ICreatedUpdated
    {
        public long Id { get; set; }

        public string Name { get; set; }
    }
}
