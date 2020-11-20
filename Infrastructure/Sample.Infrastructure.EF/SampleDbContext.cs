using Microsoft.EntityFrameworkCore;
using Sample.Domain.Models.Categories;
using Sample.Domain.Models.SubCategories;
using Sample.Domain.Models.Tags;
using Sample.Infrastructure.EF.Mappings.Tags;

namespace Sample.Infrastructure.EF
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options)
            : base(options)
        {
        }

        public SampleDbContext()
        {

        }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TagsMapping).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
