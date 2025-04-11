using Microsoft.EntityFrameworkCore;

namespace LearnRazorPages;

public class AppDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

}