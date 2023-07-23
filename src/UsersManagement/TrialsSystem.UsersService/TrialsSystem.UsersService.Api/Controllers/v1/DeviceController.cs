using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrialsSystem.UsersService.Api.Application.Commands.City;
using TrialsSystem.UsersService.Api.Application.Commands.Device;
using TrialsSystem.UsersService.Api.Application.Queries.City;
using TrialsSystem.UsersService.Api.Application.Queries.Device;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public DeviceController(
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
            var devices = await _mediator.Send(new GetDevicesQuery(skip, take));

            return Ok(devices);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var device = await _mediator.Send(new GetDeviceByIdQuery(id));

            return Ok(device);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(CreateDeviceRequest request)
        {
            var command = _mapper.Map<CreateDeviceCommand>(request);
            var created = await _mediator.Send(command);

            return Ok(created);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(UpdateDeviceRequest request)
        {
            var command = _mapper.Map<UpdateDeviceCommand>(request);
            var updated = await _mediator.Send(command);

            return Ok(updated);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var deletedId = await _mediator.Send(new DeleteDeviceCommand(id));

            return Ok(deletedId);
        }
    }
}
