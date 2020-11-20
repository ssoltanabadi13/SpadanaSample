using Sample.Domain.Models.SubCategories;

namespace Sample.Infrastructure.EF.Repositories
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly SampleDbContext _sampleDbContext;

        public SubCategoryRepository(SampleDbContext sampleDbContext)
        {
            _sampleDbContext = sampleDbContext;
        }

        public void Save(SubCategory subCategory)
        {
            _sampleDbContext.SubCategories.Add(subCategory);
        }
    }
}