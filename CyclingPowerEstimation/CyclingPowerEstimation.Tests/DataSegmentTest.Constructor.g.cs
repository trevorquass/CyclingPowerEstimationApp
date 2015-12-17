using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation;
// <copyright file="DataSegmentTest.Constructor.g.cs">Copyright ©  2015</copyright>
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
        public void Constructor907()
        {
            DataSegment dataSegment;
            dataSegment = this.Constructor((DataPoint)null, (DataPoint)null);
            Assert.IsNotNull((object)dataSegment);
            Assert.IsNull(dataSegment.Start);
            Assert.IsNull(dataSegment.End);
            Assert.AreEqual<double>(0, dataSegment.RollingResistanceForce.Newtons);
            Assert.AreEqual<double>(0, dataSegment.AccelerationForce.Newtons);
            Assert.AreEqual<double>(0, dataSegment.HillForce.Newtons);
            Assert.AreEqual<double>(0, dataSegment.WindForce.Newtons);
        }
    }
}
