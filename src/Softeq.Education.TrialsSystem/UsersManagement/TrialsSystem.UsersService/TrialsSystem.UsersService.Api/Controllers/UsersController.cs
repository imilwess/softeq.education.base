using Microsoft.AspNetCore.Mvc;
using TrialsSystem.UsersService.Infrastructure.Models;

namespace TrialsSystem.UsersService.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok();
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetAsync(string Id)
        {
            return Ok();
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostAsync(AddUserRequest request)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync()
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync()
        {
            return Ok();
        }
    }
}
