// <copyright file="AccelerationTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation.Units;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Units.Tests
{
    [TestClass]
    [PexClass(typeof(Acceleration))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AccelerationTest
    {

        [PexMethod]
        public Acceleration op_Subtraction(Acceleration acceleration1, Acceleration acceleration2)
        {
            Acceleration result = acceleration1 - acceleration2;
            return result;
            // TODO: add assertions to method AccelerationTest.op_Subtraction(Acceleration, Acceleration)
        }

        [PexMethod]
        public double op_Implicit(Acceleration distance)
        {
            double result = (double)distance;
            return result;
            // TODO: add assertions to method AccelerationTest.op_Implicit(Acceleration)
        }

        [PexMethod]
        public Acceleration op_Division(Acceleration distance, double divisor)
        {
            Acceleration result = distance / divisor;
            return result;
            // TODO: add assertions to method AccelerationTest.op_Division(Acceleration, Double)
        }

        [PexMethod]
        public Acceleration op_Addition(Acceleration acceleration1, Acceleration acceleration2)
        {
            Acceleration result = acceleration1 + acceleration2;
            return result;
            // TODO: add assertions to method AccelerationTest.op_Addition(Acceleration, Acceleration)
        }

        [PexMethod]
        public void MetersPerSecondPerSecondSet(Acceleration target, double value)
        {
            target.MetersPerSecondPerSecond = value;
            // TODO: add assertions to method AccelerationTest.MetersPerSecondPerSecondSet(Acceleration, Double)
        }

        [PexMethod]
        public double MetersPerSecondPerSecondGet(Acceleration target)
        {
            double result = target.MetersPerSecondPerSecond;
            return result;
            // TODO: add assertions to method AccelerationTest.MetersPerSecondPerSecondGet(Acceleration)
        }

        [PexMethod]
        public bool IsUnknownGet(Acceleration target)
        {
            bool result = target.IsUnknown;
            return result;
            // TODO: add assertions to method AccelerationTest.IsUnknownGet(Acceleration)
        }

        [PexMethod]
        public Acceleration Constructor(double accelerationInMetersPerSecondPerSecond)
        {
            Acceleration target = new Acceleration(accelerationInMetersPerSecondPerSecond);
            return target;
            // TODO: add assertions to method AccelerationTest.Constructor(Double)
        }
    }
}
