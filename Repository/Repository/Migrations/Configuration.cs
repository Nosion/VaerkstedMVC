namespace Repository.Migrations
{
    using Repository.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Repository.Concrete.VaerkstedContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Repository.Concrete.VaerkstedContext context)
        {


            // Oprettelse af Employees
            context.Employees.AddOrUpdate(
                e => e.Name,
                new Employee { Name = "Bent1", Surname = "Surname1", Mail = "Svend1@mail.dk", Login = "Svend1", Password = "121" },
                new Employee { Name = "Bent2", Surname = "Surname2", Mail = "Svend2@mail.dk", Login = "Svend2", Password = "122" },
                new Employee { Name = "Bent3", Surname = "Surname3", Mail = "Svend3@mail.dk", Login = "Svend3", Password = "123" },
                new Employee { Name = "Bent4", Surname = "Surname4", Mail = "Svend4@mail.dk", Login = "Svend4", Password = "124" },
                new Employee { Name = "Bent5", Surname = "Surname5", Mail = "Svend5@mail.dk", Login = "Svend5", Password = "125" },
                new Employee { Name = "Bent6", Surname = "Surname6", Mail = "Svend6@mail.dk", Login = "Svend6", Password = "126" }
            );

            // Oprettelse af Customers
            context.Customers.AddOrUpdate(
                e => e.Name,
                new Customer { Id = 1, Name = "Svend1", Company = "Firm1", Phone = "11-22-33-44" },
                new Customer { Id = 2, Name = "Svend2", Company = "Firm2", Phone = "11-22-33-44" }
                );

            context.Cars.AddOrUpdate(
            e => e.PlateNumber,
                new Car { Id = 1, CustomerId = 2,  PlateNumber = "999991", ChassisNumber = "8888881", Model = "1000", Manufacturer = "Lada", Year = 1975 },
                new Car { PlateNumber = "999992", ChassisNumber = "8888882", Model = "1100", Manufacturer = "Lada", Year = 1975 },
                new Car { PlateNumber = "999993", ChassisNumber = "8888883", Model = "F100", Manufacturer = "Ford", Year = 1964 },
                new Car { PlateNumber = "999994", ChassisNumber = "8888884", Model = "1300", Manufacturer = "Lada", Year = 1975 },
                new Car { PlateNumber = "999995", ChassisNumber = "8888885", Model = "1400", Manufacturer = "Lada", Year = 1975 },
                new Car { PlateNumber = "999996", ChassisNumber = "8888886", Model = "1500", Manufacturer = "Lada", Year = 1975 }
            );

            context.Tasks.AddOrUpdate(
            e => e.CreatedStamp,
                new Task { CreatedStamp = DateTime.Now, CreatedBy = "Bent5", DoneStamp = DateTime.Now.AddDays(2), Description = "Slør i rettet", Comments = "Bilen er total smadret..." },
                new Task { CreatedStamp = DateTime.Now, CreatedBy = "Bent5", DoneStamp = DateTime.Now.AddDays(2), Description = "Slør i rettet", Comments = "Bilen er total smadret..." },
                new Task { CreatedStamp = DateTime.Now, CreatedBy = "Bent5", DoneStamp = DateTime.Now.AddDays(2), Description = "Slør i rettet", Comments = "Bilen er total smadret..." },
                new Task { CreatedStamp = DateTime.Now, CreatedBy = "Bent5", DoneStamp = DateTime.Now.AddDays(2), Description = "Slør i rettet", Comments = "Bilen er total smadret..." },
                new Task { CreatedStamp = DateTime.Now, CreatedBy = "Bent5", DoneStamp = DateTime.Now.AddDays(2), Description = "Slør i rettet", Comments = "Bilen er total smadret..." },
                new Task { CreatedStamp = DateTime.Now, CreatedBy = "Bent5", DoneStamp = DateTime.Now.AddDays(2), Description = "Slør i rettet", Comments = "Bilen er total smadret..." }
            );

            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
