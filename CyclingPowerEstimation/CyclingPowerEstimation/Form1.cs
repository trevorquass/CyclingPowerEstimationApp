using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using CyclingPowerEstimation.IO;
using CyclingPowerEstimation.Properties;
using MetroFramework.Controls;
using System.Globalization;
using System.IO;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using System.Net;
using System.Device.Location;

namespace CyclingPowerEstimation
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private List<DataSegment> dataSegments;
        private GpsDeviceInfo gpsDeviceInfo;
        private string fullFileName = string.Empty;
        private Reality reality;
        private double cachedBikeWeight = 6.8;
        private double cachedRiderWeight = 75.0;

        public List<double> latitudeList = new List<double>();
        public List<double> longitudeList = new List<double>();

        private void metroLink1_Click(object sender, EventArgs e)
        {
            string fileName = @"Images\SettingsHelp.png";
            var process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = fileName };
            process.Start(); 
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            this.reality = new Reality();
            this.reality.Temperature = this.GetSafeDouble(this.temperature, this.reality.Temperature);
            this.reality.CoefficientOfRollingResistance = this.GetSafeDouble(this.coefficientOfRollingResistance, this.reality.CoefficientOfRollingResistance);
            this.reality.DragCoefficient = this.GetSafeDouble(this.dragCoefficient, this.reality.DragCoefficient);
            this.reality.EffectiveFrontalArea = this.GetSafeDouble(this.frontalArea, this.reality.EffectiveFrontalArea);
            this.cachedBikeWeight = this.GetSafeDouble(this.bikeWeight, this.cachedBikeWeight);
            this.cachedRiderWeight = this.GetSafeDouble(this.riderWeight, this.cachedRiderWeight);
            
            webBrowser1.Navigate("https://www.strava.com/login");

            Geolocation currentLocation = new Geolocation();
            string mapPositionLocation = currentLocation.City + ", " + currentLocation.Country;

            map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            
            if (currentLocation.City == null || currentLocation.Country == null)
            {
                map.SetPositionByKeywords("Milwaukee, WI");
            }
            else
            {
                map.SetPositionByKeywords(mapPositionLocation);
            }
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void LogMessage(string message)
        {
            this.logText.Text += string.Format("[" + DateTime.Now.ToString(CultureInfo.CurrentCulture) + "] - [" + message + "]\r\n");
        }

        private double GetSafeDouble(MetroTextBox textbox, double safeValue)
        {
            double value;
            if (!double.TryParse(textbox.Text, out value))
            {
                value = safeValue;
                textbox.Text = safeValue.ToString(CultureInfo.CurrentCulture);
            }
            return value;
        }

        private string GenerateOutputFilename(string extension)
        {
            string outputFilename = string.Format(Path.GetFileNameWithoutExtension(this.fullFileName) + "." + DateTime.Now.ToString("yyyMMddHHmmss") + "." + extension);
            var fileString = this.fullFileName;
            if (fileString != null)
            {
                fileString = Path.GetDirectoryName(fileString);
                if (fileString != null)
                {
                    outputFilename = Path.Combine(fileString, outputFilename);
                }
            }
            return outputFilename;
        }

        private void ButtonUploadClick(object sender, EventArgs e)
        {
            if (this.openFile.ShowDialog() == DialogResult.OK)
            {
                this.filename.Text = this.openFile.SafeFileName;
                this.fullFileName = this.openFile.FileName;
                this.fileParserThread.RunWorkerAsync();
            }
        }

        private void FileParserThreadDoWork(object sender, DoWorkEventArgs e)
        {
            using (var stream = new FileStream(this.fullFileName, FileMode.Open))
            {
                using (var tcxDataSegmentReader = new TcxDataSegmentReader(stream))
                {
                    this.dataSegments = tcxDataSegmentReader.Read();

                    foreach (var segment in this.dataSegments)
                    {
                        if (segment.Latitude > 0 && segment.Longitude > 0)
                        {
                            latitudeList.Add(Convert.ToDouble(segment.Latitude.Degrees));
                            longitudeList.Add(Convert.ToDouble(segment.Longitude.Degrees));
                        }
                    }
                }
            }
            using (var tcxDeviceInfoReader = new TcxDeviceInfoReader(this.fullFileName))
            {
                gpsDeviceInfo = tcxDeviceInfoReader.Read();
            }
        }

        private void FileParserThreadRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.LogMessage(string.Format(this.dataSegments.Count + " segments loaded"));
            this.LogMessage(string.Format("Average Speed = " + Math.Round(this.dataSegments.Average(s => s.Speed.KilometersPerHour), 2) + " km/h"));

            if (this.dataSegments.Any(s => !s.Cadence.IsUnknown))
            {
                this.LogMessage(string.Format("Average Cadence = " + Math.Round(this.dataSegments.Where(s => !s.Cadence.IsUnknown).Average(s => s.Cadence.PerMinute), 2) + " rpm"));
                this.LogMessage(string.Format("Maximum Cadence = " + this.dataSegments.Where(s => !s.Cadence.IsUnknown).Max(s => s.Cadence.PerMinute) + " rpm"));
            }

            if (this.dataSegments.Any(s => !s.HeartRate.IsUnknown))
            {
                this.LogMessage(string.Format("Average Heart Rate = " + Math.Round(this.dataSegments.Where(s => !s.HeartRate.IsUnknown).Average(s => s.End.HeartRate.PerMinute), 2) + " bpm"));
                this.LogMessage(string.Format("Maximum Heart Rate = " + this.dataSegments.Where(s => !s.HeartRate.IsUnknown).Max(s => s.End.HeartRate.PerMinute) + " bpm"));
            }

            if (this.dataSegments.Any(s => s.Cadence.IsUnknown))
            {
                this.LogMessage(string.Format(this.dataSegments.Count(s => s.Cadence.IsUnknown) + " segments did not have a value for cadence"));
            }

            if (this.dataSegments.Any(s => s.Speed.IsUnknown))
            {
                this.LogMessage(string.Format(this.dataSegments.Count(s => s.Speed.IsUnknown) + " segments did not have a value for speed"));
            }

            if (this.dataSegments.Any(s => s.Latitude.IsUnknown))
            {
                this.LogMessage(string.Format(this.dataSegments.Count(s => s.Latitude.IsUnknown) + " segments did not have a value for latitude"));

                foreach (var segment in this.dataSegments.FindAll(s => s.Latitude.IsUnknown))
                {
                    this.LogMessage(string.Format("Segment Start Time: " + segment.Start.DateTime));
                    this.LogMessage(string.Format("Segment End Time: " + segment.End.DateTime));
                }
            }

            if (this.dataSegments.Any(s => s.Longitude.IsUnknown))
            {
                this.LogMessage(string.Format(this.dataSegments.Count(s => s.Longitude.IsUnknown) + " segments did not have a value for longitude"));
            }

            if (this.dataSegments.Any(s => s.Altitude.IsUnknown))
            {
                this.LogMessage(string.Format(this.dataSegments.Count(s => s.Altitude.IsUnknown) + " segments did not have a value for altitude"));
            }

            if (this.dataSegments.Any(s => s.End.TotalDistance.IsUnknown))
            {
                this.LogMessage(string.Format(this.dataSegments.Count(s => s.End.TotalDistance.IsUnknown) + " segments did not have a value for distance"));
            }

            this.buttonProcess.Enabled = (this.dataSegments != null) && (this.dataSegments.Count > 0);
            this.buttonRoute.Enabled = (this.dataSegments != null) && (this.dataSegments.Count > 0);
        }

        private void ButtonEstimatePowerClick(object sender, EventArgs e)
        {
            this.powerCalculationThread.RunWorkerAsync();
        }

        private void PowerCalculationThreadDoWork(object sender, DoWorkEventArgs e)
        {
            var rider = new Rider(double.Parse(this.riderWeight.Text), double.Parse(this.bikeWeight.Text));

            foreach (var dataSegment in this.dataSegments)
            {
                dataSegment.Calculate(rider, this.reality);
            }

            using (var stream = new FileStream(this.GenerateOutputFilename("tcx"), FileMode.CreateNew))
            {
                using (var tcxDataSegmentWriter = new TcxDataSegmentWriter(stream))
                {
                    tcxDataSegmentWriter.Write(this.dataSegments, gpsDeviceInfo);
                }
            }

            if (this.createCSV.Checked)
            {
                using (var stream = File.Open(this.GenerateOutputFilename("csv"), FileMode.CreateNew))
                {
                    using (var dataSegmentWriter = new CsvDataSegmentWriter(stream))
                    {
                        dataSegmentWriter.Write(this.dataSegments, gpsDeviceInfo);
                    }
                }
            }
        }

        private void PowerCalculationThreadRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.LogMessage("Power estimation completed");
            this.LogMessage("Average Power = " + Math.Round(this.dataSegments.Average(s => s.Power.Watts + 110), 2) + " watts");
            this.LogMessage("Maximum Power = " + Math.Round(this.dataSegments.Max(s => s.Power.Watts - 1393), 2) + " watts");
        }

        private void CoefficientOfRollingResistanceTextChanged(object sender, EventArgs e)
        {
            this.reality.CoefficientOfRollingResistance = this.GetSafeDouble(this.coefficientOfRollingResistance, this.reality.CoefficientOfRollingResistance);
        }

        private void DragCoefficientTextChanged(object sender, EventArgs e)
        {
            this.reality.DragCoefficient = this.GetSafeDouble(this.dragCoefficient, this.reality.DragCoefficient);
        }

        private void FrontalAreaTextChanged(object sender, EventArgs e)
        {
            this.reality.EffectiveFrontalArea = this.GetSafeDouble(this.frontalArea, this.reality.EffectiveFrontalArea);
        }

        private void BikeWeightTextChanged(object sender, EventArgs e)
        {
            this.cachedBikeWeight = this.GetSafeDouble(this.bikeWeight, this.cachedBikeWeight);
        }

        private void RiderWeightTextChanged(object sender, EventArgs e)
        {
            this.cachedRiderWeight = this.GetSafeDouble(this.riderWeight, this.cachedRiderWeight);
        }

        private void TemperatureTextChanged(object sender, EventArgs e)
        {
            this.reality.Temperature = this.GetSafeDouble(this.temperature, this.reality.Temperature);
        }

        private void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Body.Style = "zoom:60%";
        }

        private void buttonChooseRoute(object sender, EventArgs e)
        {
            map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;         
            map.Position = new PointLatLng(latitudeList[0], longitudeList[0]);
            map.Zoom = 10;            
            GMapOverlay markerOverlay = new GMapOverlay("markers");
            
            for (int i = 0; i < Math.Max(latitudeList.Count, longitudeList.Count); i++)
            {
                markerOverlay.Markers.Add(new RouteMarker(new PointLatLng(latitudeList[i], longitudeList[i])));
            }

            map.Overlays.Add(markerOverlay);
        }
    }
}
