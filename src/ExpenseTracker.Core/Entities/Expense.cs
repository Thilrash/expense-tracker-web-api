namespace ExpenseTracker.Core.Entities;

public class Expense
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public decimal Amount { get; set; }
    public DateOnly Date { get; set; }
    public string? Description { get; set; }
    
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }
    
    public required string UserId { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}