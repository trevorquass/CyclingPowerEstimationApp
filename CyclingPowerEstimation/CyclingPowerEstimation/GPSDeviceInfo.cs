using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingPowerEstimation
{
    public class GpsDeviceInfo
    {
        public string Name { get; set; }
        public string UnitId { get; set; }
        public string ProductId { get; set; }
        public Version FirmwareVersion { get; set; }
    }
}
