using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;
// <copyright file="DistanceTest.op_Subtraction.g.cs">Copyright ©  2015</copyright>
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
    public partial class DistanceTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(DistanceTest))]
        public void op_Subtraction161()
        {
            Distance distance;
            distance = this.op_Subtraction(default(Distance), default(Distance));
            Assert.AreEqual<double>(0, distance.Meters);
        }
    }
}
