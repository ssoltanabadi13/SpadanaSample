namespace Sample.Domain.Models.Categories
{
    public interface ICategoryRepository
    {
        void Save(Category category);
    }
}