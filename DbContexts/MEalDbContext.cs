using MEalAPI.Entities;
using MEalAPI.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace MEalAPI.DbContexts
{
    public class MealDbContext : IdentityDbContext<User>
    {
        public MealDbContext(DbContextOptions<MealDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; } = null!;

        public DbSet<RecipeIngredient> RecipeIngredients { get; set; } = null!;

        public DbSet<RecipeStep> RecipeSteps { get; set; } = null!;

        public DbSet<Ingredient> Ingredients { get; set; } = null!;

        public DbSet<Section> Sections { get; set; } = null!;

        public DbSet<Meal> Meals { get; set; } = null!;


        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is ICreatedUpdated && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            var now = DateTimeOffset.Now;

            foreach (var entry in entries)
            {
                var entity = (ICreatedUpdated)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    entity.Updated = now;
                    entity.Created = now;
                }
                
                if (entry.State == EntityState.Modified)
                {
                    entity.Updated = now;

                }
            }

            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            // Documentation reference:
            // https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key#single-navigation-property-1

            mb.Entity<Recipe>()
                .HasMany(r => r.RecipeIngredients)
                .WithOne();

            mb.Entity<Recipe>()
                .HasMany(r => r.RecipeSteps)
                .WithOne();

            mb.Entity<Recipe>()
                .HasOne(r => r.Meal)
                .WithMany();

            mb.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Ingredient)
                .WithMany();

            mb.Entity<Ingredient>()
                .HasOne(i => i.Section)
                .WithMany();
        }

    }
}
