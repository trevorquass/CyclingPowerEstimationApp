using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CyclingPowerEstimation.IO
{
    public interface IDataSegmentWriter : IDisposable
    {
        void Write(List<DataSegment> dataSegments, GpsDeviceInfo gpsDeviceInfo);
    }
}
