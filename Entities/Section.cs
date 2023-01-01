using MEalAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Entities
{
    [Table("sections", Schema = "meal")]
    [Comment("Table representing grocery store sections such as Dairy, Bulk, Produce, etc.")]
    public class Section : BaseEntity, ISection
    {
        
    }
}
