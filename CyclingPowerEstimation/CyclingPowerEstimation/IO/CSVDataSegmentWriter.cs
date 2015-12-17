using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CyclingPowerEstimation.IO
{
    public class CsvDataSegmentWriter : IDataSegmentWriter
    {
        private readonly Stream stream;

        public CsvDataSegmentWriter(Stream stream)
        {
            this.stream = stream;
        }
        public void Write(List<DataSegment> dataSegments, GpsDeviceInfo gpsDeviceInfo)
        {
            using (var streamWriter = new StreamWriter(this.stream))
            {
                streamWriter.WriteLine("Latitude,Longitude");

                foreach (var segment in dataSegments)
                {
                    streamWriter.WriteLine(string.Join(
                        ",",
                        segment.Latitude.Degrees,
                        segment.Longitude.Degrees));
                }
            }
        }
        public void Dispose()
        {

        }
    }
}
