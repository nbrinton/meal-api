using MEalAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Entities
{
    [Comment("Table representing grocery store sections such as Dairy, Bulk, Produce, etc.")]
    [Table("sections", Schema = "meal")]
    public class ESection : EBaseEntity, ISection
    {
        
    }
}
