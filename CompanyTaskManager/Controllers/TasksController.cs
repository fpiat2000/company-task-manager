using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework.Constraints;
using PolcarZadanie.DbServices;
using PolcarZadanie.Dtos;
using PolcarZadanie.Models;

namespace PolcarZadanie.Controllers
{
    [Route("/api/tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ILogger<TasksController> _logger;
        private readonly IWorkTasksDbService _dbService;

        public TasksController(ILogger<TasksController> logger, IWorkTasksDbService service)
        {
            _logger = logger;
            _dbService = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkTask>>> GetAllTasks()
        {
            return Ok(await _dbService.GetAllTasks());
        }

        [HttpGet("worker={empId}")]
        public async Task<ActionResult<IEnumerable<WorkTask>>> GetWorkerTasks(long empId)
        {
            return Ok(await _dbService.GetTasksByWorkerId(empId));
        }

        [HttpGet("{taskId}")]
        public async Task<ActionResult<WorkTask>> GetTaskById(long taskId)
        {
            var task = await _dbService.GetTaskById(taskId);
            if (task == null)
                return NotFound();
            return Ok(task);
        }

        [HttpPost]
        public async Task<ActionResult<WorkTask>> AddTask([FromBody] WorkTaskDto task)
        {
            try
            {
                await _dbService.AddTask(task);
                return Created();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPut("{taskId}")]
        [HttpPatch("{taskId}")]
        public async Task<ActionResult> UpdateTask(long taskId, [FromBody] WorkTaskDto task)
        {
            try
            {
                await _dbService.UpdateTask(taskId, task);
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpDelete("{taskId}")]
        public async Task<ActionResult> DeleteTask(long taskId)
        {
            try
            {
                await _dbService.DeleteTask(taskId);
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
