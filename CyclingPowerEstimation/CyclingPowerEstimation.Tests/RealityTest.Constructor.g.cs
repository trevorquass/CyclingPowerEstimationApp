using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation;
// <copyright file="RealityTest.Constructor.g.cs">Copyright ©  2015</copyright>
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
        public void Constructor19()
        {
            Reality reality;
            reality = this.Constructor();
            Assert.IsNotNull((object)reality);
            Assert.AreEqual<double>(0.0045, reality.CoefficientOfRollingResistance);
            Assert.AreEqual<double>(0.5, reality.DragCoefficient);
            Assert.AreEqual<double>(0.399483, reality.EffectiveFrontalArea);
            Assert.AreEqual<double>(15, reality.Temperature);
        }
    }
}
