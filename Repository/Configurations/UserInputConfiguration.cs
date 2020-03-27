using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Repository.Configurations
{
    public class UserInputConfiguration : IEntityTypeConfiguration<UserInput>
    {
        public void Configure(EntityTypeBuilder<UserInput> builder)
        {
            builder
                .HasIndex(u => u.DistinctText)
                .IsUnique();
            builder
                .HasKey(u => u.DistinctText);
        }
    }
}
