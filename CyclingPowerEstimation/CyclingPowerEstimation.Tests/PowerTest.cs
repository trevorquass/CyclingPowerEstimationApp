// <copyright file="PowerTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation.Units;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Units.Tests
{
    [TestClass]
    [PexClass(typeof(Power))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PowerTest
    {

        [PexMethod]
        public Power op_Subtraction(Power power1, Power power2)
        {
            Power result = power1 - power2;
            return result;
            // TODO: add assertions to method PowerTest.op_Subtraction(Power, Power)
        }

        [PexMethod]
        public double op_Implicit(Power power)
        {
            double result = (double)power;
            return result;
            // TODO: add assertions to method PowerTest.op_Implicit(Power)
        }

        [PexMethod]
        public Power op_Division(Power power, double divisor)
        {
            Power result = power / divisor;
            return result;
            // TODO: add assertions to method PowerTest.op_Division(Power, Double)
        }

        [PexMethod]
        public Power op_Addition(Power power1, Power power2)
        {
            Power result = power1 + power2;
            return result;
            // TODO: add assertions to method PowerTest.op_Addition(Power, Power)
        }

        [PexMethod]
        public void WattsSet(Power target, double value)
        {
            target.Watts = value;
            // TODO: add assertions to method PowerTest.WattsSet(Power, Double)
        }

        [PexMethod]
        public double WattsGet(Power target)
        {
            double result = target.Watts;
            return result;
            // TODO: add assertions to method PowerTest.WattsGet(Power)
        }

        [PexMethod]
        public Power Constructor(double powerInWatts)
        {
            Power target = new Power(powerInWatts);
            return target;
            // TODO: add assertions to method PowerTest.Constructor(Double)
        }
    }
}
