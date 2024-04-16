namespace Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    public class DataContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        protected readonly IConfiguration Configuration;
        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=Mirrra;Username=postgres;Password=line");
    }

    public class Task
    {
        public int id { get; set; }
        public string text { get; set; }
    }
}
