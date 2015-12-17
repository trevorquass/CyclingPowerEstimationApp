using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;
using CyclingPowerEstimation;
// <copyright file="DataSegmentTest.ElapsedTimeGet.g.cs">Copyright ©  2015</copyright>
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
        public void ElapsedTimeGet974()
        {
            DataPoint dataPoint;
            DataSegment dataSegment;
            TimeSpan ts;
            dataPoint = new DataPoint(default(DateTimeOffset), default(Distance), 
                                      default(Frequency), default(Distance), 
                                      default(Speed), default(Frequency), default(Angle), default(Angle));
            dataSegment = new DataSegment(dataPoint, dataPoint);
            ts = this.ElapsedTimeGet(dataSegment);
            Assert.AreEqual<int>(0, ts.Days);
            Assert.AreEqual<int>(0, ts.Hours);
            Assert.AreEqual<int>(0, ts.Milliseconds);
            Assert.AreEqual<int>(0, ts.Minutes);
            Assert.AreEqual<int>(0, ts.Seconds);
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
