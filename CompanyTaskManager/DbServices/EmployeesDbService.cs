using Microsoft.EntityFrameworkCore;
using PolcarZadanie.Data;
using PolcarZadanie.Dtos;
using PolcarZadanie.Models;

namespace PolcarZadanie.DbServices
{
    public interface IEmployeesDbService
    {
        Task<List<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(long id);
        Task<Employee> GetEmployeeByEmail(string email);
        Task RegisterEmployee(EmployeeDto employee);
        Task UpdateEmployeeDetails(long id, EmployeeDto newData);
    }

    public class EmployeesDbService : IEmployeesDbService
    {
        private ApplicationDbContext _context;

        public EmployeesDbService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(long id)
        {
            return await _context.Employees.FirstOrDefaultAsync(emp => emp.Id == id);
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await _context.Employees.Include(emp => emp.TaskList).FirstOrDefaultAsync(emp => emp.Email == email);
        }

        public Task RegisterEmployee(EmployeeDto employee)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeeDetails(long id, EmployeeDto newData)
        {
            throw new NotImplementedException();
        }
    }
}
