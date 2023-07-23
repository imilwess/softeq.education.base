namespace TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

public record UpdateDeviceRequest(string Id, string SerialNumber, string Model, DeviceTypeDto Type, string FirmwareVersion);
