using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;

namespace CyclingPowerEstimationUnitTests
{
    [TestClass]
    public class AccelerationTests
    {
        //Acceleration construction tests:
        [TestMethod]
        public void ConstructPositiveAcceleration()
        {
            Acceleration acceleration = new Acceleration(10.0);
            double result = acceleration.MetersPerSecondPerSecond;
            Assert.AreEqual(10.0, result);
        }

        [TestMethod]
        public void ConstructNegativeAcceleration()
        {
            Acceleration acceleration = new Acceleration(-10.0);
            double result = acceleration.MetersPerSecondPerSecond;
            Assert.AreEqual(-10.0, result);
        }

        [TestMethod]
        public void ConstructNoAcceleration()
        {
            Acceleration acceleration = new Acceleration(0.0);
            double result = acceleration.MetersPerSecondPerSecond;
            Assert.AreEqual(0.0, result);
        }

        //Acceleration operator tests:
        [TestMethod]
        public void AccelerationAddition()
        {
            Acceleration acceleration1 = new Acceleration(10.0);
            Acceleration acceleration2 = new Acceleration(20.0);
            Acceleration result = new Acceleration(acceleration1.MetersPerSecondPerSecond + acceleration2.MetersPerSecondPerSecond);
            Acceleration actual = new Acceleration(30.0);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void AccelerationSubtraction()
        {
            Acceleration acceleration1 = new Acceleration(20.0);
            Acceleration acceleration2 = new Acceleration(10.0);
            Acceleration result = new Acceleration(acceleration1.MetersPerSecondPerSecond - acceleration2.MetersPerSecondPerSecond);
            Acceleration actual = new Acceleration(10.0);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void AccelerationDivision()
        {
            Acceleration acceleration = new Acceleration(10.0);
            double divisor = 2.0;
            Acceleration result = new Acceleration(acceleration.MetersPerSecondPerSecond / divisor);
            Acceleration actual = new Acceleration(5.0);
            Assert.AreEqual(actual, result);
        }

        //Acceleration readonly tests:
        [TestMethod]
        public void AccelerationZero()
        {
            Acceleration acceleration = Acceleration.Zero;
            Acceleration actual = new Acceleration(0.0);
            Assert.AreEqual(actual, acceleration);
        }

        [TestMethod]
        public void AccelerationUnknown()
        {
            Acceleration acceleration = Acceleration.Unknown;
            Acceleration actual = new Acceleration(double.NaN);
            Assert.AreEqual(actual, acceleration);
        }

        [TestMethod]
        public void AccelerationOfGravity()
        {
            Acceleration gravity = Acceleration.Gravity;
            Acceleration actual = new Acceleration(9.80665);
            Assert.AreEqual(actual, gravity);
        }
    }
}
