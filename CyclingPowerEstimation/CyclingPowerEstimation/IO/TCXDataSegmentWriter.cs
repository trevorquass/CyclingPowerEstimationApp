using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CyclingPowerEstimation.IO
{
    public class TcxDataSegmentWriter : IDataSegmentWriter
    {
        private readonly Stream stream;
        //private double calculationConstant = 1205.45;

        public TcxDataSegmentWriter(Stream stream)
        {
            this.stream = stream;
        }

        public void Write(List<DataSegment> dataSegments, GpsDeviceInfo gpsDeviceInfo)
        {
            using (var streamWriter = new StreamWriter(this.stream))
            {
                streamWriter.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                streamWriter.WriteLine("<TrainingCenterDatabase xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2\">");
                streamWriter.WriteLine("    <Activities>");
                streamWriter.WriteLine("        <Activity Sport=\"Biking\">");
                streamWriter.WriteLine("            <Id>" + dataSegments.First().End.DateTime.ToString("s") + "Z</Id>");
                streamWriter.WriteLine("            <Lap StartTime=\"" + dataSegments.First().End.DateTime.ToString("s") + "Z\">");
                streamWriter.WriteLine("                <TotalTimeSeconds>" + (dataSegments.Last().End.DateTime - dataSegments.First().End.DateTime).TotalSeconds + "</TotalTimeSeconds>");
                streamWriter.WriteLine("                <DistanceMeters>" + dataSegments.Sum(s => s.Length) + "</DistanceMeters>");
                streamWriter.WriteLine("                <MaximumSpeed>" + dataSegments.Max(s => s.Speed.KilometersPerHour) + "</MaximumSpeed>");

                if (dataSegments.Any(s => !s.HeartRate.IsUnknown))
                {
                    streamWriter.WriteLine("                <AverageHeartRateBpm xsi:type=\"HeartRateInBeatsPerMinute_t\">");
                    streamWriter.WriteLine("                    <Value>" + dataSegments.Where(s => !s.HeartRate.IsUnknown).Average(s => s.HeartRate.PerMinute) + "</Value>");
                    streamWriter.WriteLine("                </AverageHeartRateBpm>");
                    streamWriter.WriteLine("                <MaximumHeartRateBpm xsi:type=\"HeartRateInBeatsPerMinute_t\">");
                    streamWriter.WriteLine("                    <Value>" + dataSegments.Where(s => !s.HeartRate.IsUnknown).Max(s => s.HeartRate.PerMinute) + "</Value>");
                    streamWriter.WriteLine("                </MaximumHeartRateBpm>");
                }

                streamWriter.WriteLine("                <Intensity>Active</Intensity>");

                if (dataSegments.Any(s => !s.Cadence.IsUnknown))
                {
                    streamWriter.WriteLine("                <Cadence>" + dataSegments.Where(s => !s.Cadence.IsUnknown).Average(s => s.Cadence.PerMinute) + "</Cadence>");
                }

                streamWriter.WriteLine("                <TriggerMethod>Manual</TriggerMethod>");
                streamWriter.WriteLine("                <Track>");

                foreach (var dataSegment in dataSegments)
                {
                    streamWriter.WriteLine("                    <Trackpoint>");
                    streamWriter.WriteLine("                        <Time>" + dataSegment.End.DateTime.ToString("s") + "Z</Time>");

                    if (!dataSegment.Latitude.IsUnknown || !dataSegment.Longitude.IsUnknown)
                    {
                        streamWriter.WriteLine("                        <Position>");

                        if (!dataSegment.Latitude.IsUnknown)
                        {
                            streamWriter.WriteLine("                            <LatitudeDegrees>" + dataSegment.End.Latitude.Degrees + "</LatitudeDegrees>");
                        }

                        if (!dataSegment.Longitude.IsUnknown)
                        {
                            streamWriter.WriteLine("                            <LongitudeDegrees>" + dataSegment.End.Longitude.Degrees + "</LongitudeDegrees>");
                        }

                        streamWriter.WriteLine("                        </Position>");
                    }

                    if (!dataSegment.Altitude.IsUnknown)
                    {
                        streamWriter.WriteLine("                        <AltitudeMeters>" + dataSegment.Altitude.Meters + "</AltitudeMeters>");
                    }

                    if (!dataSegment.End.TotalDistance.IsUnknown)
                    {
                        streamWriter.WriteLine("                        <DistanceMeters>" + dataSegment.End.TotalDistance.Meters + "</DistanceMeters>");
                    }

                    streamWriter.WriteLine("                        <Extensions>");
                    streamWriter.WriteLine("                            <TPX xmlns=\"http://www.garmin.com/xmlschemas/ActivityExtension/v2\">");
                    streamWriter.WriteLine("                                <Speed>" + dataSegment.Speed.MetersPerSecond + "</Speed>");

                    //if (dataSegment.Power.Watts > calculationConstant)
                    //{
                    //    streamWriter.WriteLine("                                <Watts>" + Math.Round(calculationConstant, 0) + "</Watts>");
                    //}
                    //else
                    //{
                    //    streamWriter.WriteLine("                                <Watts>" + Math.Round(dataSegment.Power.Watts, 0) + "</Watts>");
                    //}

                    streamWriter.WriteLine("                                <Watts>" + Math.Round(dataSegment.Power.Watts, 0) + "</Watts>");

                    streamWriter.WriteLine("                            </TPX>");
                    streamWriter.WriteLine("                        </Extensions>");

                    if (!dataSegment.HeartRate.IsUnknown)
                    {
                        streamWriter.WriteLine("                        <HeartRateBpm>");
                        streamWriter.WriteLine("                            <Value>" + dataSegment.HeartRate.PerMinute + "</Value>");
                        streamWriter.WriteLine("                        </HeartRateBpm>");
                    }

                    if (!dataSegment.Cadence.IsUnknown)
                    {
                        streamWriter.WriteLine("                        <Cadence>" + dataSegment.Cadence.PerMinute + "</Cadence>");
                    }

                    streamWriter.WriteLine("                    </Trackpoint>");
                }

                streamWriter.WriteLine("                </Track>");
                streamWriter.WriteLine("            </Lap>");
                streamWriter.WriteLine("            <Creator xsi:type=\"Device_t\">");
                streamWriter.WriteLine("                <Name>" + gpsDeviceInfo.Name + "</Name>");                
                streamWriter.WriteLine("                <UnitId>" + gpsDeviceInfo.UnitId + "</UnitId>");                
                streamWriter.WriteLine("                <ProductID>" + gpsDeviceInfo.ProductId + "</ProductID>");
                streamWriter.WriteLine("                <Version>");                
                streamWriter.WriteLine("                    <VersionMajor>" + gpsDeviceInfo.FirmwareVersion.Major + "</VersionMajor>");                
                streamWriter.WriteLine("                    <VersionMinor>" + gpsDeviceInfo.FirmwareVersion.Minor + "</VersionMinor>");                
                streamWriter.WriteLine("                    <BuildMajor>" + gpsDeviceInfo.FirmwareVersion.Build + "</BuildMajor>");                
                streamWriter.WriteLine("                    <BuildMinor>" + gpsDeviceInfo.FirmwareVersion.Revision + "</BuildMinor>");
                streamWriter.WriteLine("                </Version>");
                streamWriter.WriteLine("            </Creator>");
                streamWriter.WriteLine("        </Activity>");
                streamWriter.WriteLine("    </Activities>");
                streamWriter.WriteLine("</TrainingCenterDatabase>");
            }
        }
        public void Dispose()
        {
        }
    }
}
