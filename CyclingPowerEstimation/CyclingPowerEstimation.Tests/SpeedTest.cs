// <copyright file="SpeedTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation.Units;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Units.Tests
{
    [TestClass]
    [PexClass(typeof(Speed))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SpeedTest
    {

        [PexMethod]
        public Speed op_Subtraction(Speed speed1, Speed speed2)
        {
            Speed result = speed1 - speed2;
            return result;
            // TODO: add assertions to method SpeedTest.op_Subtraction(Speed, Speed)
        }

        [PexMethod]
        public double op_Implicit(Speed speed)
        {
            double result = (double)speed;
            return result;
            // TODO: add assertions to method SpeedTest.op_Implicit(Speed)
        }

        [PexMethod]
        public Acceleration op_Division01(Speed speed, TimeSpan timeSpan)
        {
            Acceleration result = speed / timeSpan;
            return result;
            // TODO: add assertions to method SpeedTest.op_Division01(Speed, TimeSpan)
        }

        [PexMethod]
        public Speed op_Division(Speed speed, double divisor)
        {
            Speed result = speed / divisor;
            return result;
            // TODO: add assertions to method SpeedTest.op_Division(Speed, Double)
        }

        [PexMethod]
        public Speed op_Addition(Speed speed1, Speed speed2)
        {
            Speed result = speed1 + speed2;
            return result;
            // TODO: add assertions to method SpeedTest.op_Addition(Speed, Speed)
        }

        [PexMethod]
        public void MetersPerSecondSet(Speed target, double value)
        {
            target.MetersPerSecond = value;
            // TODO: add assertions to method SpeedTest.MetersPerSecondSet(Speed, Double)
        }

        [PexMethod]
        public double MetersPerSecondGet(Speed target)
        {
            double result = target.MetersPerSecond;
            return result;
            // TODO: add assertions to method SpeedTest.MetersPerSecondGet(Speed)
        }

        [PexMethod]
        public double KilometersPerHourGet(Speed target)
        {
            double result = target.KilometersPerHour;
            return result;
            // TODO: add assertions to method SpeedTest.KilometersPerHourGet(Speed)
        }

        [PexMethod]
        public bool IsUnknownGet(Speed target)
        {
            bool result = target.IsUnknown;
            return result;
            // TODO: add assertions to method SpeedTest.IsUnknownGet(Speed)
        }

        [PexMethod]
        public Speed Constructor(double speedInMetersPerSecond)
        {
            Speed target = new Speed(speedInMetersPerSecond);
            return target;
            // TODO: add assertions to method SpeedTest.Constructor(Double)
        }
    }
}
