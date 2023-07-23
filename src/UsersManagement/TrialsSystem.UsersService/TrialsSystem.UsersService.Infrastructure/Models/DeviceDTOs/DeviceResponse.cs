namespace TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

public record DeviceResponse(string Id, string SerialNumber, string Model, DeviceTypeDto Type, string FirmwareVersion);
