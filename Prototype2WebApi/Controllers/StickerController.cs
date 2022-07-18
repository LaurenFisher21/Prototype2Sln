using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Enums;
using Prototype2WebApi.Interfaces;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StickerController : ControllerBase
    {
        private readonly IPrototypeDbRepository _prototypeDbRepository;
        public StickerController(IPrototypeDbRepository prototypeDbRepository)
        {
            _prototypeDbRepository = prototypeDbRepository;
        }

        [HttpPost]
        public IActionResult CreateSchedule([FromBody] Sticker sticker)
        {
            try
            {
                if (sticker == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.StickerNotValid.ToString());
                }
                bool DoesStickerExist = _prototypeDbRepository.DoesStickerExistById(sticker.StickerId);
                if (DoesStickerExist)
                {
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.PostedStoryDuplicate.ToString());
                }
                _prototypeDbRepository.CreateNewSchedule(schedule);
            }
            catch (Exception)
            {
                return BadRequest(SystemErrorCodes.ScheduleCreationFailed.ToString());
            }
            return Ok(schedule);
        }
        [HttpGet]
        public IEnumerable<Schedule> Get()
        {
            return _prototypeDbRepository.GetAllSchedules();
        }

        // GET api/<ScheduleController>/5
        [HttpGet("byid")]
        public Schedule Get([FromQuery] int id)
        {
            return _prototypeDbRepository.GetScheduleById(id);
        }
    }
}
