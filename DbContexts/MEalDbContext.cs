﻿using MEalAPI.Models;
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

        //protected override void onModelCreating(ModelBuilder modelbuilder)
        //{

        //}

    }
}