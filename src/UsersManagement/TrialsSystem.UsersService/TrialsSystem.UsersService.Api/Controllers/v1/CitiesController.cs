using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrialsSystem.UsersService.Api.Application.Commands.City;
using TrialsSystem.UsersService.Api.Application.Queries.City;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CitiesController(
            IMediator mediator,
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(
            int? skip,
            int? take)
        {
            var cities = await _mediator.Send(new GetCitiesQuery(skip, take));

            return Ok(cities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var city = await _mediator.Send(new GetCityByIdQuery(id));

            return Ok(city);
        }
        
        [HttpPost]
        public async Task<IActionResult> PostAsync(CreateCityRequest request)
        {
            var command = _mapper.Map<CreateCityCommand>(request);
            var createdCity = await _mediator.Send(command);

            return Ok(createdCity);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(UpdateCityRequest request)
        {
            var command = _mapper.Map<UpdateCityCommand>(request);
            var updatedCity = await _mediator.Send(command);

            return Ok(updatedCity);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var deletedCityId = await _mediator.Send(new DeleteCityCommand(id));

            return Ok(deletedCityId);
        }
    }
}
