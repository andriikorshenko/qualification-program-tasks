using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task_004.Models.Entities;

namespace Task_004.Models.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> typeBuilder)
        {
            typeBuilder
                .ToTable("Authors");

            typeBuilder
                .HasKey(p => p.Id);

            typeBuilder
                .Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            typeBuilder
                .Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(30);

            typeBuilder
                .Property(p => p.MiddleName)
                .HasMaxLength(30);
        }
    }
}
