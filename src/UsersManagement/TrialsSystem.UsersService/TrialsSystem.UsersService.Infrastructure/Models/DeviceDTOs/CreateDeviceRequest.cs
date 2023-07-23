namespace TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

public record CreateDeviceRequest(string SerialNumber, string Model, string DeviceTypeId, string FirmwareVersion);
