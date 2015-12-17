using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;

namespace CyclingPowerEstimationUnitTests
{
    [TestClass]
    public class DistanceTests
    {
        //Distance construction tests:
        [TestMethod]
        public void ConstructPositiveDistance()
        {
            Distance distance = new Distance(10.0);
            double result = distance.Meters;
            Assert.AreEqual(10.0, result);
        }
        [TestMethod]
        public void ConstructNoDistance()
        {
            Distance distance = new Distance(0.0);
            double result = distance.Meters;
            Assert.AreEqual(0.0, result);
        }

        //Distance conversion tests:
        [TestMethod]
        public void ConvertToKilometersZero()
        {
            Distance distance = new Distance(0.0);
            double result = distance.Kilometers;
            Assert.AreEqual(0.0, result);
        }

        [TestMethod]
        public void ConvertToKilometersPositive()
        {
            Distance distance = new Distance(10.0);
            double result = distance.Kilometers;
            Assert.AreEqual(0.01, result);
        }

        [TestMethod]
        public void ConvertToMilesZero()
        {
            Distance distance = new Distance(0.0);
            double result = distance.Miles;
            Assert.AreEqual(0.0, result);
        }

        [TestMethod]
        public void ConvertToMilesPositive()
        {
            Distance distance = new Distance(10.0);
            double result = distance.Miles;
            Assert.AreEqual(0.00621371, result, 0.000005);
        }

        //Distance operator tests:
        [TestMethod]
        public void DistanceAddition()
        {
            Distance distance1 = new Distance(10.0);
            Distance distance2 = new Distance(20.0);
            Distance result = new Distance(distance1.Meters + distance2.Meters);
            Distance actual = new Distance(30.0);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void DistanceSubtraction()
        {
            Distance distance1 = new Distance(20.0);
            Distance distance2 = new Distance(10.0);
            Distance result = new Distance(distance1.Meters - distance2.Meters);
            Distance actual = new Distance(10.0);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void DistanceDivision()
        {
            Distance distance = new Distance(10.0);
            double divisor = 2.0;
            Distance result = new Distance(distance.Meters / divisor);
            Distance actual = new Distance(5.0);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void SpeedDivision()
        {
            Distance distance = new Distance(60.0);
            TimeSpan timeSpan = new TimeSpan(0, 0, 1, 0, 0);
            Speed result = new Speed(distance.Meters / timeSpan.TotalSeconds);
            Speed actual = new Speed(1.0);
            Assert.AreEqual(actual, result);
        }

        //Distance readonly tests:
        [TestMethod]
        public void DistanceZero()
        {
            Distance distance = Distance.Zero;
            Distance actual = new Distance(0.0);
            Assert.AreEqual(actual, distance);
        }

        [TestMethod]
        public void DistanceUnknown()
        {
            Distance distance = Distance.Unknown;
            Distance actual = new Distance(double.NaN);
            Assert.AreEqual(actual, distance);
        }
    }
}
