using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Sample.Infrastructure.EF
{
    public class SampleDbContextFactory : IDesignTimeDbContextFactory<SampleDbContext>
    {
        public SampleDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SampleDbContext>();
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SpadanaSample_DB;User ID=sa;Password=123");

            return new SampleDbContext(optionsBuilder.Options);
        }
    }
}