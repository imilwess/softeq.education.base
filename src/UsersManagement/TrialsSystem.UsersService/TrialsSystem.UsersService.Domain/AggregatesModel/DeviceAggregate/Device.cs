using TrialsSystem.UsersService.Domain.AggregatesModel.Base;

namespace TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate
{
    public class Device : Entity
    {
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public DeviceType Type { get; set; }
        public string FirmwareVersion { get; set; }
    }
}
