using Microsoft.EntityFrameworkCore;

namespace ToDoListApp;

public class ToDoDbContext : DbContext
{
    public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
    {

    }

    public DbSet<ToDoTask> Tasks { get; set; }
}
