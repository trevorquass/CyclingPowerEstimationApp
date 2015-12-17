using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;

namespace CyclingPowerEstimationUnitTests
{
    [TestClass]
    public class PowerTests
    {
        //Power construction tests:
        [TestMethod]
        public void ConstructPositivePower()
        {
            Power power = new Power(100.0);
            double result = power.Watts;
            Assert.AreEqual(100.0, result);
        }

        [TestMethod]
        public void ConstructNoPower()
        {
            Power power = new Power(0.0);
            double result = power.Watts;
            Assert.AreEqual(0.0, result);
        }

        //Power operator tests:
        [TestMethod]
        public void PowerAddition()
        {
            Power power1 = new Power(50.0);
            Power power2 = new Power(100.0);
            Power result = new Power(power1.Watts + power2.Watts);
            Power actual = new Power(150.0);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void PowerSubtraction()
        {
            Power power1 = new Power(150.0);
            Power power2 = new Power(50.0);
            Power result = new Power(power1.Watts - power2.Watts);
            Power actual = new Power(100.0);
            Assert.AreEqual(actual, result);
        }
        
        [TestMethod]
        public void PowerDivision()
        {
            Power power = new Power(100.0);
            double divisor = 2.0;
            Power result = new Power(power.Watts / divisor);
            Power actual = new Power(50.0);
            Assert.AreEqual(actual, result);
        }

        //Power readonly tests:
        [TestMethod]
        public void PowerZero()
        {
            Power power = Power.Zero;
            Power actual = new Power(0.0);
            Assert.AreEqual(actual, power);
        }

        [TestMethod]
        public void PowerUnknown()
        {
            Power power = Power.Unknown;
            Power actual = new Power(double.NaN);
            Assert.AreEqual(actual, power);
        }
    }
}
