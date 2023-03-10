using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Models.Configuration
{
    public class RatingEntityTypeConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MovieId).HasColumnType("int").IsRequired();
            builder.Property(x => x.Rate).HasColumnType("int").IsRequired();
        }
    }
}