using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PolcarZadanie.Models;

namespace PolcarZadanie.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<WorkTask> WorkTasks { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<WorkTask>((task) =>
            {
                task.Property(t => t.Id).ValueGeneratedOnAdd();
                task.HasIndex(t => t.Id).IsUnique();
                task.HasKey(t => t.Id);
                task.HasOne(t => t.AssignedEmployee).WithMany(e => e.TaskList);
            });
            builder.Entity<Employee>((employee) =>
            {
                employee.Property(e => e.Id).ValueGeneratedOnAdd();
                employee.HasIndex(e => e.Id).IsUnique();
                employee.HasIndex(e => e.Email).IsUnique();
                employee.HasKey(e => e.Id);
                employee.HasOne(e => e.Manager).WithMany(m => m.Team).OnDelete(DeleteBehavior.SetNull);
                employee.HasMany(e => e.TaskList).WithOne(t => t.AssignedEmployee);
            });
            builder.Entity<Manager>((manager) =>
            {
                manager.ToTable(nameof(Managers));
                manager.Property(m => m.Id).ValueGeneratedOnAdd();
                manager.HasMany(m => m.Team).WithOne(e => e.Manager).OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
