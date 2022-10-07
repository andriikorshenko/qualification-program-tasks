using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task_004.Models.Entities;

namespace Task_004.Models.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> typeBuilder)
        {
            typeBuilder
                .ToTable("Books");

            typeBuilder
                .HasKey(p => p.Id);

            typeBuilder
                .Property(p => p.Name)
                .IsRequired();

            typeBuilder
                .Property(p => p.PageQty)
                .IsRequired();

            typeBuilder
                .Property(p => p.Genre)
                .IsRequired();
        }
    }
}
