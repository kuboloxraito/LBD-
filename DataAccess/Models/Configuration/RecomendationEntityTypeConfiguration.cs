using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Models.Configuration
{
    public class RecomendationEntityTypeConfiguration : IEntityTypeConfiguration<Recomendation>
    {
        public void Configure(EntityTypeBuilder<Recomendation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MovieId).HasColumnType("int").IsRequired();
        }
    }
}