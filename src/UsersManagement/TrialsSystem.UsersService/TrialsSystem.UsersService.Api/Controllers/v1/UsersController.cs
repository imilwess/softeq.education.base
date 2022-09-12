using Microsoft.AspNetCore.Mvc;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;
using MediatR;
using TrialsSystem.UsersService.Api.Application.Queries;
using TrialsSystem.UsersService.Api.Filters;

namespace TrialsSystem.UsersService.Api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ServiceFilter(typeof(UserExceptionFilter))]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(int skip = 0,
                                                  int? take = null,
                                                  string? email = null)
        {
            var response = await _mediator.Send(new UsersQuery(take, skip, email));
            return Ok(response);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetAsync(string Id)
        {
            return Ok();
        }


        [HttpPost]
        [ProducesResponseType(typeof(AddUserResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostAsync(AddUserRequest request)
        {
            return Ok();
        }

        [HttpPut("{id:guid}")]
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
