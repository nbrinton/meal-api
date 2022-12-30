using MEalAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Entities
{
    [Comment("Table representing specific meals, primarily breakfast, lunch, and dinner.")]
    [Table("meals", Schema = "meal")]
    public class EMeal : EBaseEntity, IMeal
    {

    }
}
