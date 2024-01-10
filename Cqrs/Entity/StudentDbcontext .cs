using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Cqrs.Entity
{
    public class EmployeeDbcontext :DbContext
    {
        private readonly IConfiguration _configuration;
        public EmployeeDbcontext(DbContextOptions<EmployeeDbcontext> options, IConfiguration configuration) :base (options)
        {
            _configuration = configuration;

        }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyConnection"));
        }
    }
}

