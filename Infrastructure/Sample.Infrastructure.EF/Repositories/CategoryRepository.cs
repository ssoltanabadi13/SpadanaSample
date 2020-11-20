using Sample.Domain.Models.Categories;

namespace Sample.Infrastructure.EF.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly SampleDbContext _sampleDbContext;

        public CategoryRepository(SampleDbContext sampleDbContext)
        {
            _sampleDbContext = sampleDbContext;
        }
        public void Save(Category category)
        {
            _sampleDbContext.Categories.Add(category);
        }
    }
}