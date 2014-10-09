using Repository.Entities;
using System.Data.Entity;

namespace Repository.Concrete
{
    public class VaerkstedContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Task> Tasks { get; set; }
        //DbSet<Work> Works { get; set; }
    }
}
