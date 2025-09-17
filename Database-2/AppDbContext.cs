using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Replace 'root' and password with your XAMPP MySQL credentials
        var connectionString = "server=localhost;database=studentdb;user=root;password=;";
        options.UseMySQL(connectionString); // Changed from UseMySql to UseMySQL
    }
}