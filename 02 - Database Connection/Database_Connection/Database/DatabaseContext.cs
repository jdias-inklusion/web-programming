using Database_Connection.Models.University;
using Microsoft.EntityFrameworkCore;

namespace Database_Connection.Database;

public class DatabaseContext: DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public DbSet<Course> Course { get; set; }
    public DbSet<Student> Student { get; set; }
}