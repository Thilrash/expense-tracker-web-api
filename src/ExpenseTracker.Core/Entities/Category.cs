namespace ExpenseTracker.Core.Entities;

public class Category
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public required string Name { get; set; }
    public required string UserId { get; set; }
    
    public List<Expense> Expenses { get; set; } = [];
}