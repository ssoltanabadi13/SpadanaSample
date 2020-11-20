using System;
using System.Collections.Generic;

namespace Sample.Domain.Models.Tags
{
    public interface ITagRepository
    {
        void Save(Tag tag);
        Tag GetBy(Guid id);
        List<Tag> GetAllBy(Guid categoryId);
    }
}