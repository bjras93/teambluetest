using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Repository.Configurations
{
    public class WatchListWordConfiguration : IEntityTypeConfiguration<WatchListWord>
    {
        public void Configure(EntityTypeBuilder<WatchListWord> builder)
        {
            builder
                .HasIndex(w => w.Word)
                .IsUnique();
            builder
                .HasKey(w => w.Word);
        }
    }
}