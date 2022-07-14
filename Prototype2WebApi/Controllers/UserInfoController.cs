using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Enums;
using Prototype2WebApi.Interfaces;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Controllers
{
    /// <summary>
    /// Make GET, PUT, POST AND DELETE request from here.
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IPrototypeDbRepository _prototypeDbRepository;

        public UserInfoController(IPrototypeDbRepository prototypeDbRepository)
        {
            _prototypeDbRepository = prototypeDbRepository;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserInfoData userinfo)
        {
            try
            {
                if (userinfo == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.CustomerNotValid.ToString());
                }
                bool customerExists = _prototypeDbRepository.DoesUserExistByEmail(userinfo.EmailAddress);
                if (customerExists)
                {
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.CustomerDuplicate.ToString());
                }
                _prototypeDbRepository.CreateNewUser(userinfo);
            }
            catch (Exception)
            {
                return BadRequest(SystemErrorCodes.ScheduleCreationFailed.ToString());
            }
            return Ok(userinfo);
        }
    }
}
