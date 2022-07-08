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
    }
}
