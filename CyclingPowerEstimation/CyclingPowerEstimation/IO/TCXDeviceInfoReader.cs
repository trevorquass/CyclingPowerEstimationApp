using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace CyclingPowerEstimation.IO
{
    public class TcxDeviceInfoReader : IDisposable
    {
        private const string NodesXpath = "//tcx:Creator";
        private const string NameXpath = "tcx:Name";
        private const string UnitIdXpath = "tcx:UnitId";
        private const string ProductIdXpath = "tcx:ProductID";
        private const string FirmwareVersionXPathVersionMajor = "tcx:Version/tcx:VersionMajor";
        private const string FirmwareVersionXPathVersionMinor = "tcx:Version/tcx:VersionMinor";
        private const string FirmwareVersionXPathBuildMajor = "tcx:Version/tcx:BuildMajor";
        private const string FirmwareVersionXPathBuildMinor = "tcx:Version/tcx:BuildMinor";

        private readonly FileStream stream;

        public TcxDeviceInfoReader(string filepath)
        {
            stream = new FileStream(filepath, FileMode.Open);
        }

        public void Dispose()
        {
            stream.Close();
        }
        public GpsDeviceInfo Read()
        {
            if (!stream.CanRead)
            {
                throw new ApplicationException("Unable to read from file stream");
            }

            var xmlDocument = new XmlDocument();
            xmlDocument.Load(stream);

            var xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
            xmlNamespaceManager.AddNamespace("tcx", "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2");
            xmlNamespaceManager.AddNamespace("ext", "http://www.garmin.com/xmlschemas/ActivityExtension/v2");

            var info = GetDeviceInfo(xmlDocument, xmlNamespaceManager);
            return info;
        }

        private static GpsDeviceInfo GetDeviceInfo(XmlNode xmlNode, XmlNamespaceManager xmlNamespaceManager)
        {
            var nodes = xmlNode.SelectNodes(NodesXpath, xmlNamespaceManager);

            if (nodes == null || nodes.Count != 1)
            {
                throw new ApplicationException("File appears to have been authored by more than one device.");
            }

            XmlNode node = nodes[0];
            var info = new GpsDeviceInfo
            {
                Name = SafeGetSubNodeInnerText(node, xmlNamespaceManager, NameXpath),
                UnitId = SafeGetSubNodeInnerText(node, xmlNamespaceManager, UnitIdXpath),
                ProductId = SafeGetSubNodeInnerText(node, xmlNamespaceManager, ProductIdXpath),
                FirmwareVersion = SafeGetVersionNode(node, xmlNamespaceManager)
            };
            return info;
        }

        private static string SafeGetSubNodeInnerText(XmlNode xmlNode, XmlNamespaceManager xmlNamespaceManager, string xPath)
        {
            var subNode = xmlNode.SelectSingleNode(xPath, xmlNamespaceManager);
            return subNode == null ? string.Empty : subNode.InnerText;
        }

        private static Version SafeGetVersionNode(XmlNode xmlNode, XmlNamespaceManager xmlNamespaceManager)
        {
            var major = xmlNode.SelectSingleNode(FirmwareVersionXPathVersionMajor, xmlNamespaceManager);
            int versionMajor = major == null ? 0 : int.Parse(major.InnerText);

            var minor = xmlNode.SelectSingleNode(FirmwareVersionXPathVersionMinor, xmlNamespaceManager);
            int versionMinor = minor == null ? 0 : int.Parse(minor.InnerText);

            var bMajor = xmlNode.SelectSingleNode(FirmwareVersionXPathBuildMajor, xmlNamespaceManager);
            int buildMajor = bMajor == null ? 0 : int.Parse(bMajor.InnerText);

            var bMinor = xmlNode.SelectSingleNode(FirmwareVersionXPathBuildMinor, xmlNamespaceManager);
            int buildMinor = bMinor == null ? 0 : int.Parse(bMinor.InnerText);

            return new Version(versionMajor, versionMinor, buildMajor, buildMinor);
        }
    }
}
