using Microsoft.EntityFrameworkCore;
using KolomietsExpertTestMVC.Entities;

namespace KolomietsExpertTestMVC.Entities
{
    public class ExpertContext : DbContext
    {
        public ExpertContext(DbContextOptions<ExpertContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(200);
                entity.Property(e => e.Director).HasMaxLength(200);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(200);
            });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<KolomietsExpertTestMVC.Entities.Film> Films { get; set; } = default!;
        public DbSet<KolomietsExpertTestMVC.Entities.Category> Categories { get; set; } = default!;
        public DbSet<KolomietsExpertTestMVC.Entities.FilmCategory> FilmCategories { get; set; } = default!;

        public int CountCategoryLevel(int categoryId)
        {
            int counter = 0;
            int? currentId = categoryId;

            while (currentId.HasValue)
            {
                currentId = Categories.Find(currentId.Value)?.ParentCategoryId;
                if (!currentId.HasValue)
                {
                    break;
                }
                counter++;
            }

            return counter;
        }
    }
}
