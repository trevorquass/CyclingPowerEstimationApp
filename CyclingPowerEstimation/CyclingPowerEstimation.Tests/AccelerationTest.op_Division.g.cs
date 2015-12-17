using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;
// <copyright file="AccelerationTest.op_Division.g.cs">Copyright ©  2015</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace CyclingPowerEstimation.Units.Tests
{
    public partial class AccelerationTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(AccelerationTest))]
        public void op_Division508()
        {
            Acceleration acceleration;
            acceleration = this.op_Division(default(Acceleration), 0);
            Assert.AreEqual<double>(double.NaN, acceleration.MetersPerSecondPerSecond);
        }
    }
}
