using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Interfaces;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyGroupController : ControllerBase
    {
        private readonly IPrototypeDbRepository _prototypeDbRepository;
        public FamilyGroupController(IPrototypeDbRepository prototypeDbRepository)
        {
            _prototypeDbRepository = prototypeDbRepository;
        }
    }
}
