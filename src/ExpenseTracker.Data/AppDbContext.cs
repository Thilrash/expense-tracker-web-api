using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    // DbSets for your entities go here, for example:
}