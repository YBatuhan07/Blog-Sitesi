using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Blog.Entity.Entities;

namespace Blog.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                    Id = Guid.Parse("{E65396D8-D781-473C-B145-43DC13B9280B}"),
                    FileName = "images/testimage2",
                    FileType = "jpg",
                    CreatedBy = "Yazar",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
            },
             new Image
             {

                 Id = Guid.Parse("{CD3535C8-C295-43C8-BC6C-AFE3D0E2DFF6}"),
                 FileName = "images/testimage",
                 FileType = "jpg",
                 CreatedBy = "Yazar",
                 CreatedDate = DateTime.Now,
                 IsDeleted = false
             }
            );
        }
    }
}
