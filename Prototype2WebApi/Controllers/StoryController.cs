using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Enums;
using Prototype2WebApi.Interfaces;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {

        private readonly IPrototypeDbRepository _prototypeDbRepository;
        public StoryController(IPrototypeDbRepository prototypeDbRepository)
        {
            _prototypeDbRepository = prototypeDbRepository;
        }

        [HttpPost]
        public IActionResult CreateStory([FromBody] Story story)
        {
            try
            {
                if (story == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.StoryNotValid.ToString());
                }
                bool DoesStoryExist = _prototypeDbRepository.DoesStoryExistById(story.StoryId);
                if (DoesStoryExist)
                {
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.StoryDuplicate.ToString());
                }
                _prototypeDbRepository.CreateNewStory(story);
            }
            catch (Exception)
            {
                return BadRequest(SystemErrorCodes.StoryCreationFailed.ToString());
            }
            return Ok(story);
        }
        [HttpGet]
        public IEnumerable<Story> Get()
        {
            return _prototypeDbRepository.GetAllStories();
        }

        
        [HttpGet("byid")]
        public Story Get([FromQuery] int id)
        {
            return _prototypeDbRepository.GetStoryId(id);
        }

    }
}
