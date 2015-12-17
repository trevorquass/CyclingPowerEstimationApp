using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using CyclingPowerEstimation.Units;

namespace CyclingPowerEstimation.IO
{
    public class TcxDataSegmentReader : IDataSegmentReader
    {
        private const string NodesXpath = "//tcx:Trackpoint";
        private const string DatetimeXpath = "tcx:Time";
        private const string AltitudeXpath = "tcx:AltitudeMeters";
        private const string CadenceXpath = "tcx:Cadence";
        private const string DistanceXpath = "tcx:DistanceMeters";
        private const string HeartrateXpath = "tcx:HeartRateBpm/tcx:Value";
        private const string LatitudeXpath = "tcx:Position/tcx:LatitudeDegrees";
        private const string LongitudeXpath = "tcx:Position/tcx:LongitudeDegrees";
        private const string SpeedXpath = "tcx:Extensions/ext:TPX/ext:Speed";

        private readonly Stream stream;

        public TcxDataSegmentReader(Stream stream)
        {
            this.stream = stream;
        }
        public List<DataSegment> Read()
        {
            var dataSegments = new List<DataSegment>();

            var xmlDocument = new XmlDocument();
            xmlDocument.Load(this.stream);

            var xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
            xmlNamespaceManager.AddNamespace("tcx", "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2");
            xmlNamespaceManager.AddNamespace("ext", "http://www.garmin.com/xmlschemas/ActivityExtension/v2");

            var dataPoints = this.GetDataPoints(xmlDocument, xmlNamespaceManager);

            for (var speedLoop = 0; speedLoop < dataPoints.Count; speedLoop++)
            {
                if (dataPoints[speedLoop].Speed.IsUnknown)
                {
                    if (speedLoop == 0 || speedLoop == dataPoints.Count - 1)
                    {
                        dataPoints[speedLoop].Speed = Speed.Zero;
                    }
                    else
                    {
                        Distance distance = dataPoints[speedLoop].TotalDistance
                                            - dataPoints[speedLoop - 1].TotalDistance;
                        double time =
                            dataPoints[speedLoop].DateTime.Subtract(dataPoints[speedLoop - 1].DateTime).TotalSeconds;
                        var speed = distance.Meters / time;
                        dataPoints[speedLoop].Speed = new Speed(speed);

                        if (dataPoints[speedLoop].Speed.IsUnknown)
                        {
                            dataPoints[speedLoop].Speed = Speed.Zero;
                        }
                    }
                }
            }

            const int ChunkSize = 4;
            for (var loop = ChunkSize; loop < dataPoints.Count - ChunkSize; loop++)
            {
                dataSegments.Add(new DataSegment(dataPoints[loop - ChunkSize], dataPoints[loop + ChunkSize]));
            }
            return dataSegments;
        }
        public void Dispose()
        {

        }
        private List<DataPoint> GetDataPoints(XmlNode xmlNode, XmlNamespaceManager xmlNamespaceManager)
        {
            var dataPoints = new List<DataPoint>();
            var nodes = xmlNode.SelectNodes(NodesXpath, xmlNamespaceManager);

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    var dateTime = this.GetDateTimeNode(node, xmlNamespaceManager, DatetimeXpath);
                    var altitude = this.GetDistanceNode(node, xmlNamespaceManager, AltitudeXpath);
                    var cadence = this.GetFrequencyNode(node, xmlNamespaceManager, CadenceXpath);
                    var totalDistance = this.GetDistanceNode(node, xmlNamespaceManager, DistanceXpath);
                    var speed = this.GetSpeedNode(node, xmlNamespaceManager, SpeedXpath);
                    var heartrateInBpm = this.GetFrequencyNode(node, xmlNamespaceManager, HeartrateXpath);
                    var latitude = this.GetAngleNode(node, xmlNamespaceManager, LatitudeXpath);
                    var longitude = this.GetAngleNode(node, xmlNamespaceManager, LongitudeXpath);

                    var dataPoint = new DataPoint(dateTime, altitude, cadence, totalDistance, speed, heartrateInBpm, latitude, longitude);

                    dataPoints.Add(dataPoint);
                }
            }
            return dataPoints;
        }
        private Frequency GetFrequencyNode(XmlNode xmlNode, XmlNamespaceManager xmlNamespaceManager, string xpath)
        {
            var subNode = xmlNode.SelectSingleNode(xpath, xmlNamespaceManager);

            if (subNode == null)
            {
                return Frequency.Unknown;
            }
            return new Frequency(int.Parse(subNode.InnerText));
        }
        private Speed GetSpeedNode(XmlNode xmlNode, XmlNamespaceManager xmlNamespaceManager, string xpath)
        {
            var subNode = xmlNode.SelectSingleNode(xpath, xmlNamespaceManager);

            if (subNode == null)
            {
                return Speed.Unknown;
            }
            return new Speed(double.Parse(subNode.InnerText));
        }
        private Angle GetAngleNode(XmlNode xmlNode, XmlNamespaceManager xmlNamespaceManager, string xpath)
        {
            var subNode = xmlNode.SelectSingleNode(xpath, xmlNamespaceManager);

            if (subNode == null)
            {
                return Angle.Unknown;
            }
            return Angle.FromDegrees(double.Parse(subNode.InnerText));
        }
        private DateTimeOffset GetDateTimeNode(XmlNode xmlNode, XmlNamespaceManager xmlNamespaceManager, string xpath)
        {
            var subNode = xmlNode.SelectSingleNode(xpath, xmlNamespaceManager);

            if (subNode == null)
            {
                throw new ArgumentOutOfRangeException("xpath");
            }
            return DateTimeOffset.Parse(subNode.InnerText);
        }
        private Distance GetDistanceNode(XmlNode xmlNode, XmlNamespaceManager xmlNamespaceManager, string xpath)
        {
            var subNode = xmlNode.SelectSingleNode(xpath, xmlNamespaceManager);

            if (subNode == null)
            {
                return Distance.Unknown;
            }
            return new Distance(double.Parse(subNode.InnerText));
        }
    }
}
