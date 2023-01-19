using Microsoft.EntityFrameworkCore;

namespace LoggingDemo
{
    public class LoggingDbContext:DbContext
    {
        public LoggingDbContext(DbContextOptions<LoggingDbContext> options) : base(options)
        {

        }
        public DbSet<Person> MyProperty { get; set; }
    }
}
