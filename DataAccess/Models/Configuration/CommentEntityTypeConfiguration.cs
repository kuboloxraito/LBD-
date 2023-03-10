using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Models.Configuration
{
    public class CommentEntityTypeConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Author).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(x => x.MovieId).HasColumnType("int").IsRequired();
            builder.Property(x => x.Comments).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.CreatedDate).HasColumnType("datetime").IsRequired();
        }
    }
}