using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation;

namespace CyclingPowerEstimationUnitTests
{
    [TestClass]
    public class RealityTests
    {
        //Air density at sea level and temperature of zero, 15, 50, -15:
        [TestMethod]
        public void AirDensityAtSeaLevelZeroDegrees()
        {
            Reality reality = new Reality();
            reality.Temperature = 0.0;
            double density = reality.AirDensity(0.0);
            Assert.AreEqual(1.288, density, 0.05);
        }

        [TestMethod]
        public void AirDensityAtSeaLevel15Degrees()
        {
            Reality reality = new Reality();
            reality.Temperature = 15.0;
            double density = reality.AirDensity(0.0);
            Assert.AreEqual(1.221, density, 0.05);
        }

        [TestMethod]
        public void AirDensityAtSeaLevel50Degrees()
        {
            Reality reality = new Reality();
            reality.Temperature = 50.0;
            double density = reality.AirDensity(0.0);
            Assert.AreEqual(1.089, density, 0.05);
        }

        [TestMethod]
        public void AirDensityAtSeaLevelTemperatureBelowZero()
        {
            Reality reality = new Reality();
            reality.Temperature = -15.0;
            double density = reality.AirDensity(0.0);
            Assert.AreEqual(1.363, density, 0.05);
        }

        //Air density at 200meters and temperature of zero, 15, 50, -15:
        [TestMethod]
        public void AirDensityAt200MetersZeroDegrees()
        {
            Reality reality = new Reality();
            reality.Temperature = 0.0;
            double density = reality.AirDensity(200.0);
            Assert.AreEqual(1.258, density, 0.05);
        }

        [TestMethod]
        public void AirDensityAt200Meters15Degrees()
        {
            Reality reality = new Reality();
            reality.Temperature = 15.0;
            double density = reality.AirDensity(200.0);
            Assert.AreEqual(1.193, density, 0.05);
        }

        [TestMethod]
        public void AirDensityAt200Meters50Degrees()
        {
            Reality reality = new Reality();
            reality.Temperature = 50.0;
            double density = reality.AirDensity(200.0);
            Assert.AreEqual(1.064, density, 0.05);
        }

        [TestMethod]
        public void AirDensityAt200MetersTemperatureBelowZero()
        {
            Reality reality = new Reality();
            reality.Temperature = -15.0;
            double density = reality.AirDensity(200.0);
            Assert.AreEqual(1.331, density, 0.05);
        }

        //Air density at -200meters and temperature of zero, 15, 50, -15:
        [TestMethod]
        public void AirDensityAtNegative200MetersZeroDegrees()
        {
            Reality reality = new Reality();
            reality.Temperature = 0.0;
            double density = reality.AirDensity(-200.0);
            Assert.AreEqual(1.319, density, 0.05);
        }

        [TestMethod]
        public void AirDensityAtNegative200Meters15Degrees()
        {
            Reality reality = new Reality();
            reality.Temperature = 15.0;
            double density = reality.AirDensity(-200.0);
            Assert.AreEqual(1.25, density, 0.05);
        }

        [TestMethod]
        public void AirDensityAtNegative200Meters50Degrees()
        {
            Reality reality = new Reality();
            reality.Temperature = 50.0;
            double density = reality.AirDensity(-200.0);
            Assert.AreEqual(1.115, density, 0.05);
        }

        [TestMethod]
        public void AirDensityAtNegative200MetersNegative15Degrees()
        {
            Reality reality = new Reality();
            reality.Temperature = -15.0;
            double density = reality.AirDensity(-200.0);
            Assert.AreEqual(1.396, density, 0.05);
        }

        //Pressure at sea level, positive, and negative altitude:
        [TestMethod]
        public void PressureAtSeaLevel()
        {
            Reality reality = new Reality();
            double pressure = reality.PressureAtAltitude(0.0);
            Assert.AreEqual(101325, pressure, 0.05);
        }

        [TestMethod]
        public void PressureAtPositiveAltitude()
        {
            Reality reality = new Reality();
            double pressure = reality.PressureAtAltitude(200.0);
            Assert.AreEqual(101324.95, pressure, 0.05);
        }

        [TestMethod]
        public void PressureAtNegativeAltitude()
        {
            Reality reality = new Reality();
            double pressure = reality.PressureAtAltitude(-200.0);
            Assert.AreEqual(101325.04, pressure, 0.05);
        }
    }
}
