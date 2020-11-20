using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Sample.Domain.Models.Tags;

namespace Sample.Infrastructure.EF.Repositories
{
    public class TagsRepository : ITagRepository
    {
        private readonly SampleDbContext _sampleDbContext;

        public TagsRepository(SampleDbContext sampleDbContext)
        {
            _sampleDbContext = sampleDbContext;
        }

        public void Save(Tag tag)
        {
            _sampleDbContext.Tags.Add(tag);
        }

        public Tag GetBy(Guid id)
        {
            return _sampleDbContext.Tags.Include(x => x.Category).Include(x => x.SubCategory).FirstOrDefault(x => x.Id == id);
        }

        public List<Tag> GetAllBy(Guid categoryId)
        {
            return _sampleDbContext.Tags.Include(x => x.Category).Include(x => x.SubCategory)
                .Where(x => x.CategoryId == categoryId).ToList();
        }
    }
}