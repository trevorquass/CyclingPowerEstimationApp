using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation;
// <copyright file="RealityTest.AirDensity.g.cs">Copyright ©  2015</copyright>
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
    public partial class RealityTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(RealityTest))]
        public void AirDensity958()
        {
            Reality reality;
            double d;
            reality = new Reality();
            reality.CoefficientOfRollingResistance = 0;
            reality.DragCoefficient = 0;
            reality.EffectiveFrontalArea = 0;
            reality.Temperature = 0;
            d = this.AirDensity(reality, 0);
            Assert.AreEqual<double>(1.2922465262714646, d);
            Assert.IsNotNull((object)reality);
            Assert.AreEqual<double>(0, reality.CoefficientOfRollingResistance);
            Assert.AreEqual<double>(0, reality.DragCoefficient);
            Assert.AreEqual<double>(0, reality.EffectiveFrontalArea);
            Assert.AreEqual<double>(0, reality.Temperature);
        }
    }
}
