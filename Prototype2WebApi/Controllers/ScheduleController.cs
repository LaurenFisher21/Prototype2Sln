using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private static List<Schedule> schedule = new List<Schedule>
            {
                new Schedule
                {
                    ScheduleId = 1,
                    TaskName = "Do Migrations and Databases",
                    Description = "Don't forget to do HomePage for Parents and Children",
                    Completed = false
                },

                new Schedule
                {
                    ScheduleId = 2,
                    TaskName = "Brush your teeth",
                    Description = "PLS DON'T!!!",
                    Completed = false
                }
            };

        [HttpGet]
        public async Task<ActionResult<List<Schedule>>> Get()
        {
            return Ok(schedule);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Schedule>> Get(int id)
        {
            var task = schedule.Find(h => h.ScheduleId == id);
            if (task == null)
                return BadRequest("Task not found.");
            return Ok(task);
        }

        [HttpPost]
        public async Task<ActionResult<List<Schedule>>> AddTask(Schedule task)
        {
            schedule.Add(task);
            return Ok(schedule);
        }

        [HttpPut]
        public async Task<ActionResult<List<Schedule>>> UpdateTask(Schedule request)
        {
            var task = schedule.Find(h => h.ScheduleId == request.ScheduleId);
            if (task == null)
                return BadRequest("Task not found.");
            
            task.ScheduleId = request.ScheduleId;
            task.TaskName = request.TaskName;
            task.Description = request.Description;
            task.Completed = request.Completed;

            return Ok(schedule);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Schedule>>> Delete(int id)
        {
            var task = schedule.Find(h => h.ScheduleId == id);
            if (task == null)
                return BadRequest("Task not found.");

            schedule.Remove(task);
            return Ok(schedule);
        }
    }
}
