using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;
using Rhino.Mocks;


namespace CyclingPowerEstimationUnitTests
{
    [TestClass]
    public class SpeedTests
    {
        //Speed construction tests
        [TestMethod]
        public void ConstructPositiveSpeed()
        {
            Speed speed = new Speed(10.0);
            double result = speed.MetersPerSecond;
            Assert.AreEqual(10.0, result);
        }
        [TestMethod]
        public void ConstructNoSpeed()
        {
            Speed speed = new Speed(0.0);
            double result = speed.MetersPerSecond;
            Assert.AreEqual(0.0, result);
        }

        //Speed conversion tests:
        [TestMethod]
        public void ConvertToKPHZero()
        {
            Speed speed = new Speed(0.0);
            double result = speed.KilometersPerHour;
            Assert.AreEqual(0.0, result);
        }

        [TestMethod]
        public void ConvertToKPHPositive()
        {
            Speed speed = new Speed(10.0);
            double result = speed.KilometersPerHour;
            Assert.AreEqual(36.0, result);
        }

        //Speed operator tests:
        [TestMethod]
        public void SpeedAddition()
        {
            Speed speed1 = new Speed(10.0);
            Speed speed2 = new Speed(20.0);
            Speed result = new Speed(speed1.MetersPerSecond + speed2.MetersPerSecond);
            Speed actual = new Speed(30.0);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void SpeedSubtraction()
        {
            Speed speed1 = new Speed(20.0);
            Speed speed2 = new Speed(10.0);
            Speed result = new Speed(speed1.MetersPerSecond - speed2.MetersPerSecond);
            Speed actual = new Speed(10.0);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void SpeedDivison()
        {
            Speed speed = new Speed(40.0);
            double divisor = 2.0;
            Speed result = new Speed(speed.MetersPerSecond / divisor);
            Speed actual = new Speed(20.0);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void AccelerationDivision()
        {
            Speed speed = new Speed(60.0);
            TimeSpan timeSpan = new TimeSpan(0, 0, 1, 0, 0);
            Acceleration result = new Acceleration(speed.MetersPerSecond / timeSpan.TotalSeconds);
            Acceleration actual = new Acceleration(1.0);
            Assert.AreEqual(actual, result);
        }

        //Speed readonly tests:
        [TestMethod]
        public void SpeedZero()
        {
            Speed speed = Speed.Zero;
            Speed actual = new Speed(0.0);
            Assert.AreEqual(actual, speed);
        }

        [TestMethod]
        public void SpeedUnknown()
        {
            Speed speed = Speed.Unknown;
            Speed actual = new Speed(double.NaN);
            Assert.AreEqual(actual, speed);
        }
    }
}
