using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;

namespace CyclingPowerEstimationUnitTests
{
    [TestClass]
    public class ForceTests
    {
        //Force construction tests:
        [TestMethod]
        public void ConstructPositiveForce()
        {
            Force force = new Force(10.0);
            double result = force.Newtons;
            Assert.AreEqual(10.0, result);
        }

        [TestMethod]
        public void ConstructNegativeForce()
        {
            Force force = new Force(-10.0);
            double result = force.Newtons;
            Assert.AreEqual(-10.0, result);
        }

        [TestMethod]
        public void ConstructNoForce()
        {
            Force force = new Force(0.0);
            double result = force.Newtons;
            Assert.AreEqual(0.0, result);
        }

        //Force operator tests:
        [TestMethod]
        public void ForceAddition()
        {
            Force force1 = new Force(10.0);
            Force force2 = new Force(20.0);
            Force result = new Force(force1.Newtons + force2.Newtons);
            Force actual = new Force(30.0);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void ForceSubtraction()
        {
            Force force1 = new Force(20.0);
            Force force2 = new Force(10.0);
            Force result = new Force(force1.Newtons - force2.Newtons);
            Force actual = new Force(10.0);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void ForceDivision()
        {
            Force force = new Force(10.0);
            double divisor = 2.0;
            Force result = new Force(force.Newtons / divisor);
            Force actual = new Force(5.0);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void PowerDivision()
        {
            Force force = new Force(10.0);
            Speed speed = new Speed(5.0);
            Power result = new Power(force.Newtons * speed.MetersPerSecond);
            Power actual = new Power(50.0);
            Assert.AreEqual(actual, result);
        }

        //Force readonly tests:
        [TestMethod]
        public void ForceZero()
        {
            Force force = Force.Zero;
            Force actual = new Force(0.0);
            Assert.AreEqual(actual, force);
        }

        [TestMethod]
        public void ForceUnknown()
        {
            Force force = Force.Unknown;
            Force actual = new Force(double.NaN);
            Assert.AreEqual(actual, force);
        }
    }
}
