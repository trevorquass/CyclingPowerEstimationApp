using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;
using CyclingPowerEstimation;
// <copyright file="DataSegmentTest.PowerGet.g.cs">Copyright ©  2015</copyright>
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
        public void PowerGet703()
        {
            DataPoint dataPoint;
            DataSegment dataSegment;
            Power power;
            Speed s0 = default(Speed);
            s0.MetersPerSecond = 1;
            dataPoint = new DataPoint(default(DateTimeOffset), default(Distance), 
                                      default(Frequency), default(Distance), 
                                      s0, default(Frequency), default(Angle), default(Angle));
            dataSegment = new DataSegment(dataPoint, dataPoint);
            power = this.PowerGet(dataSegment);
            Assert.AreEqual<double>(0, power.Watts);
            Assert.IsNotNull((object)dataSegment);
            Assert.IsNotNull(dataSegment.Start);
            Assert.AreEqual<double>(0, dataSegment.Start.Altitude.Meters);
            Assert.AreEqual<int>(0, dataSegment.Start.HeartRate.PerMinute);
            Assert.AreEqual<int>(0, dataSegment.Start.Cadence.PerMinute);
            Assert.AreEqual<double>(1, dataSegment.Start.Speed.MetersPerSecond);
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
