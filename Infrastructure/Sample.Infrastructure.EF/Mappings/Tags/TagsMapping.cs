using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Domain.Models.Tags;

namespace Sample.Infrastructure.EF.Mappings.Tags
{
    public class TagsMapping : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tags").HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Name);
            builder.Property(x => x.CreateOn);
            builder.Property(x => x.LastModified);

            builder.Property(x => x.CategoryId).IsRequired(false);
            builder.HasOne(x => x.Category).WithMany(x => x.CategoryTagAssigns).HasForeignKey(x => x.CategoryId);
            
            builder.Property(x => x.SubCategoryId).IsRequired(false);
            builder.HasOne(x => x.SubCategory).WithMany(x => x.SubCategoryTagAssigns).HasForeignKey(x => x.SubCategoryId);
        }
    }
}