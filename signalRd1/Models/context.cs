using Microsoft.EntityFrameworkCore;
namespace signalRd1.Models
{
    public class context:DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public context(DbContextOptions options) : base(options){}
    }
}
