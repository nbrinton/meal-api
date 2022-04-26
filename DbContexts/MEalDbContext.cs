using MEalAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace MEalAPI.DbContexts
{
    public class MEalDbContext : DbContext
    {
        public MEalDbContext(DbContextOptions<MEalDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; } = null!;

        public DbSet<RecipeIngredient> RecipeIngredients { get; set; } = null!;

        public DbSet<RecipeStep> RecipeSteps { get; set; } = null!;

        public DbSet<Ingredient> Ingredients { get; set; } = null!;

        public DbSet<Section> Sections { get; set; } = null!;


        //public override int SaveChanges()
        //{
        //    var entries = ChangeTracker
        //        .Entries()
        //        .Where(e => e.Entity is BaseEntity && (
        //                e.State == EntityState.Added
        //                || e.State == EntityState.Modified));

        //    foreach (var entityEntry in entries)
        //    {
        //        ((BaseEntity)entityEntry.Entity).Updated = DateTime.Now;

        //        if (entityEntry.State == EntityState.Added)
        //        {
        //            ((BaseEntity)entityEntry.Entity).Created = DateTime.Now;
        //        }
        //    }

        //    return base.SaveChanges();
        //}

        //protected override void onModelCreating(ModelBuilder modelbuilder)
        //{
           
        //}

    }
}
