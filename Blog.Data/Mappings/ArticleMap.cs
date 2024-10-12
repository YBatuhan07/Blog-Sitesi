using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            //builder.Property(x => x.Title).HasMaxLength(300);
            //builder.Property(x => x.Title).IsRequired();

            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Makale 1",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                ViewCount = 6,
                CategoryId = Guid.Parse("{7FD207C4-647E-46E6-ABFE-3442275D12DB}"),
                ImageId = Guid.Parse("{E65396D8-D781-473C-B145-43DC13B9280B}"),
                CreatedBy = "Yazar",
                CreatedDate = DateTime.Now,
                IsDeleted= false,
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Makale 2",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                ViewCount = 6,
                CategoryId = Guid.Parse("{B2C4813F-3D93-4EA9-B354-54F33C15398D}"),
                ImageId = Guid.Parse("{CD3535C8-C295-43C8-BC6C-AFE3D0E2DFF6}"),
                CreatedBy = "Yazar-2",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            });

        }
    }
}
