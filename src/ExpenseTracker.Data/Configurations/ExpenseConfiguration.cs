using ExpenseTracker.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Data.Configurations;

public class ExpenseConfiguration: IEntityTypeConfiguration<Expense>
{
    public void Configure(EntityTypeBuilder<Expense> builder)
    {
        // The database itself rejects zero or negative amounts
        builder.ToTable("expenses", t => 
            t.HasCheckConstraint("ck_expenses_amount_positive", "\"Amount\" > 0"));
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Amount)
            .IsRequired()
            .HasPrecision(12, 2);
        builder.Property(e => e.Description)
            .HasMaxLength(500);
        builder.Property(e => e.UserId)
            .IsRequired()
            .HasMaxLength(450);
        
        builder.HasOne(e => e.Category)
            .WithMany(c => c.Expenses)
            .HasForeignKey(e => e.CategoryId)
            .OnDelete(DeleteBehavior.Restrict); // can't delete a category that has expenses
        
        // Most queries filter by user and date range
        builder.HasIndex(e => new { e.UserId, e.Date });
    }
}