using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;
using CyclingPowerEstimation;
// <copyright file="DataPointTest.AscentToPoint.g.cs">Copyright ©  2015</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace CyclingPowerEstimation.Tests
{
    public partial class DataPointTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(DataPointTest))]
        public void AscentToPoint996()
        {
            DataPoint dataPoint;
            Distance distance;
            dataPoint = new DataPoint(default(DateTimeOffset), default(Distance), 
                                      default(Frequency), default(Distance), 
                                      default(Speed), default(Frequency), default(Angle), default(Angle));
            distance = this.AscentToPoint(dataPoint, dataPoint);
            Assert.AreEqual<double>(0, distance.Meters);
            Assert.IsNotNull((object)dataPoint);
            Assert.AreEqual<double>(0, dataPoint.Altitude.Meters);
            Assert.AreEqual<int>(0, dataPoint.HeartRate.PerMinute);
            Assert.AreEqual<int>(0, dataPoint.Cadence.PerMinute);
            Assert.AreEqual<double>(0, dataPoint.Speed.MetersPerSecond);
            Assert.AreEqual<double>(0, dataPoint.TotalDistance.Meters);
            Assert.AreEqual<double>(0, dataPoint.Longitude.Radians);
            Assert.AreEqual<double>(0, dataPoint.Latitude.Radians);
        }
    }
}
