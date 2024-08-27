using PolcarZadanie.Models;

namespace PolcarZadanie.Data
{
    public class DataSeeder: IDisposable
    {
        private readonly ApplicationDbContext context;

        public DataSeeder(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task Seed()
        {
            if (context.Employees.Any())
                return;
            Employee[] employees = [
                new Employee { FirstName = "John", LastName = "Doe", Email = "jdoe@company.com", JobTitle = "Junior Tester" },
                new Employee { FirstName = "Bob", LastName = "Doe", Email = "bdoe@company.com", JobTitle = "Junior Tester" },
                new Employee { FirstName = "Adam", LastName = "Doe", Email = "adoe@company.com", JobTitle = "Tester" }
                ];
            var manager = new Manager
            {
                FirstName = "Mr.",
                LastName = "Rich",
                Email = "boss@company.com",
                JobTitle = "Test Manager",
                Team = [.. employees]
            };
            foreach (var emp in employees)
            {
                emp.Manager = manager;
            }

            await context.AddRangeAsync(employees);
            await context.AddAsync(manager);
            await context.SaveChangesAsync();
            Dispose();
        }
    }
}
