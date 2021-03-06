using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;
using CyclingPowerEstimation;
// <copyright file="DataSegmentTest.LatitudeGet.g.cs">Copyright ©  2015</copyright>
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
    public partial class DataSegmentTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(DataSegmentTest))]
        public void LatitudeGet274()
        {
            DataPoint dataPoint;
            DataSegment dataSegment;
            Angle angle;
            dataPoint = new DataPoint(default(DateTimeOffset), default(Distance), 
                                      default(Frequency), default(Distance), 
                                      default(Speed), default(Frequency), default(Angle), default(Angle));
            dataSegment = new DataSegment(dataPoint, dataPoint);
            angle = this.LatitudeGet(dataSegment);
            Assert.AreEqual<double>(0, angle.Radians);
            Assert.IsNotNull((object)dataSegment);
            Assert.IsNotNull(dataSegment.Start);
            Assert.AreEqual<double>(0, dataSegment.Start.Altitude.Meters);
            Assert.AreEqual<int>(0, dataSegment.Start.HeartRate.PerMinute);
            Assert.AreEqual<int>(0, dataSegment.Start.Cadence.PerMinute);
            Assert.AreEqual<double>(0, dataSegment.Start.Speed.MetersPerSecond);
            Assert.AreEqual<double>(0, dataSegment.Start.TotalDistance.Meters);
            Assert.AreEqual<double>(0, dataSegment.Start.Longitude.Radians);
            Assert.AreEqual<double>(0, dataSegment.Start.Latitude.Radians);
            Assert.IsNotNull(dataSegment.End);
            Assert.IsTrue(object.ReferenceEquals(dataSegment.End, dataSegment.Start));
            Assert.AreEqual<double>(0, dataSegment.RollingResistanceForce.Newtons);
            Assert.AreEqual<double>(0, dataSegment.AccelerationForce.Newtons);
            Assert.AreEqual<double>(0, dataSegment.HillForce.Newtons);
            Assert.AreEqual<double>(0, dataSegment.WindForce.Newtons);
        }
    }
}
