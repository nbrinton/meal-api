using MEalAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Entities
{
    [Table("meals", Schema = "meal")]
    [Comment("Table representing specific meals, primarily breakfast, lunch, and dinner.")]
    public class Meal : BaseEntity, IMeal
    {

    }
}
