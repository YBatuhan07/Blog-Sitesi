using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("{7FD207C4-647E-46E6-ABFE-3442275D12DB}"),
                Name = "Makale 1-1",
                CreatedBy = "Yazar 1-1",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Category
            {
                    Id = Guid.Parse("{B2C4813F-3D93-4EA9-B354-54F33C15398D}"),
                    Name = "Makale 2-1",
                    CreatedBy = "Yazar 2-1",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
            });
            
        }
    }
}
