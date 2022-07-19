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
        public IActionResult CreateNewSticker([FromBody] Sticker  sticker)
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
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.StickerDuplicate.ToString());
                }
                _prototypeDbRepository.CreateNewSticker(sticker);
            }
            catch (Exception)
            {
                return BadRequest(SystemErrorCodes.StickerCreationFailed.ToString());
            }
            return Ok(sticker);
        }
        [HttpGet]
        public IEnumerable<Sticker> Get()
        {
            return _prototypeDbRepository.GetAllStickers();
        }

        // GET api/<ScheduleController>/5
        [HttpGet("byid")]
        public Sticker Get([FromQuery] int id)
        {
            return _prototypeDbRepository.GetStickerById(id);
        }
    }

       
}
