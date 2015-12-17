using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;

namespace CyclingPowerEstimationUnitTests
{
    [TestClass]
    public class AngleTests
    {
        //Angle construction tests:
        [TestMethod]
        public void ConstructPositive()
        {
            Angle angle = new Angle(10.0);
            double result = angle.Radians;
            Assert.AreEqual(10.0, result);
        }

        [TestMethod]
        public void ConstructNoAngle()
        {
            Angle angle = new Angle(0.0);
            double result = angle.Radians;
            Assert.AreEqual(0.0, result);
        }

        [TestMethod]
        public void ConstructZeroAngle()
        {
            Angle angle = Angle.Zero;
            Assert.AreEqual(0.0, angle);
        }

        //Angle conversion tests:
        [TestMethod]
        public void ConvertToDegreesPositive()
        {
            Angle angle = new Angle(6.28319);
            double result = angle.Degrees;
            Assert.AreEqual(360, result, 0.001);
        }

        [TestMethod]
        public void ConvertToDegreesNoAngle()
        {
            Angle angle = new Angle(0.0);
            double result = angle.Degrees;
            Assert.AreEqual(0.0, result);
        }

        [TestMethod]
        public void ConvertToRadiansPositive()
        {
            double angleInDegrees = 360.0;
            Angle result = Angle.FromDegrees(angleInDegrees);
            Assert.AreEqual(6.28319, result, 0.001);
        }

        [TestMethod]
        public void ConvertToRadiansNoAngle()
        {
            double angleInDegrees = 0.0;
            Angle result = Angle.FromDegrees(angleInDegrees);
            Assert.AreEqual(0.0, result);
        }

        //Angle readonly tests:
        [TestMethod]
        public void AngleZero()
        {
            Angle angle = Angle.Zero;
            Angle actual = new Angle(0.0);
            Assert.AreEqual(actual, angle);
        }

        [TestMethod]
        public void AngleUnknown()
        {
            Angle angle = Angle.Unknown;
            Angle actual = new Angle(double.NaN);
            Assert.AreEqual(actual, angle);
        }
    }
}
