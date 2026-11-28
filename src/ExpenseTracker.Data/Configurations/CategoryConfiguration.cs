using ExpenseTracker.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Data.Configurations;

public class CategoryConfiguration: IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("categories");
        builder.HasKey(c => c.Id);
        
        builder.Property(c=> c.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(c=> c.UserId)
            .IsRequired()
            .HasMaxLength(450);
        
        // A user can't have two categories with the same name
        builder.HasIndex(c => new {c.UserId, c.Name})
            .IsUnique();
    }
}