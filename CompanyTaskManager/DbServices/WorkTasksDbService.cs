using Microsoft.EntityFrameworkCore;
using PolcarZadanie.Data;
using PolcarZadanie.Dtos;
using PolcarZadanie.Models;
using System.Threading.Tasks;

namespace PolcarZadanie.DbServices
{
    public interface IWorkTasksDbService
    {
        Task<List<WorkTask>> GetAllTasks();
        Task<List<WorkTask>> GetTasksByWorkerId(long workerId);
        Task<WorkTask> GetTaskById(long taskId);
        Task AddTask(WorkTaskDto task);
        Task UpdateTask(long taskId, WorkTaskDto newData);
        Task DeleteTask(long taskId);
    }

    public class WorkTasksDbService: IWorkTasksDbService
    {
        private ApplicationDbContext _context;

        public WorkTasksDbService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<WorkTask>> GetAllTasks()
        {
            return await _context.WorkTasks.Include(t => t.AssignedEmployee).ToListAsync();
        }

        public async Task<List<WorkTask>> GetTasksByWorkerId(long workerId)
        {
            return await _context.WorkTasks.Where(t => t.AssignedEmployee.Id == workerId).ToListAsync();
        }

        public async Task<WorkTask> GetTaskById(long taskId)
        {
            return await _context.WorkTasks.Include(t => t.AssignedEmployee).FirstOrDefaultAsync(t => t.Id == taskId);
        }

        public async Task AddTask(WorkTaskDto task)
        {
            var entity = new WorkTask(task.Header, task.Priority, task.Description);
            if (task.AssignedEmployee != null)
                entity.AssignedEmployee = _context.Employees.FirstOrDefault(e => e.Email == task.AssignedEmployee.Email);
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTask(long taskId, WorkTaskDto newData)
        {
            var task = await _context.WorkTasks.FirstOrDefaultAsync(task => task.Id == taskId);
            if (task == null)
                throw new Exception($"Work task with ID {taskId} was not found");
            _context.Update(task);
            if (newData.Header != "")
                task.Header = newData.Header;
            if (newData.Priority <= 0)
                task.Priority = newData.Priority;
            if (newData.Description != "")
                task.Description = newData.Description;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTask(long taskId)
        {
            var task = await _context.WorkTasks.FirstOrDefaultAsync(t => t.Id == taskId);
            if (task == null)
                throw new Exception($"Work task with ID {taskId} was not found");
            _context.WorkTasks.Remove(task);
            await _context.SaveChangesAsync();
        }

        public Task<WorkTask> GetTaskById(int taskId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTask(int taskId)
        {
            throw new NotImplementedException();
        }
    }
}
