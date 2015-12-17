using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;
// <copyright file="AngleTest.Constructor.g.cs">Copyright ©  2015</copyright>
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
    public partial class AngleTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(AngleTest))]
        public void Constructor201()
        {
            Angle angle;
            angle = this.Constructor(0);
            Assert.AreEqual<double>(0, angle.Radians);
        }
    }
}
