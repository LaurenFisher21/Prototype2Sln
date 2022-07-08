using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private static List<UserInfoData> schedule = new List<UserInfoData>
            {
                new UserInfoData
                {
                    UserId = 1,
                    FirstName = "Ash",
                    LastName = "Ketchum",
                    EmailAddress = "aketchum@pokemon.net",
                    CellNumber = "0123456789",
                    Password = "PokemonMaster247"
                },

                new UserInfoData
                {
                    UserId = 2,
                    FirstName = "Gary",
                    LastName = "Oak",
                    EmailAddress = "goak@pokemon.net",
                    CellNumber = "9876543210",
                    Password = "AshSucks321"
                }
            };

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(schedule);
        }
    }
}
