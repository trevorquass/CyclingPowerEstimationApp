// <copyright file="AngleTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation.Units;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Units.Tests
{
    [TestClass]
    [PexClass(typeof(Angle))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AngleTest
    {

        [PexMethod]
        public Angle op_Subtraction(Angle angle1, Angle angle2)
        {
            Angle result = angle1 - angle2;
            return result;
            // TODO: add assertions to method AngleTest.op_Subtraction(Angle, Angle)
        }

        [PexMethod]
        public double op_Implicit(Angle angle)
        {
            double result = (double)angle;
            return result;
            // TODO: add assertions to method AngleTest.op_Implicit(Angle)
        }

        [PexMethod]
        public Angle op_Division(Angle angle, double divisor)
        {
            Angle result = angle / divisor;
            return result;
            // TODO: add assertions to method AngleTest.op_Division(Angle, Double)
        }

        [PexMethod]
        public Angle op_Addition(Angle angle1, Angle angle2)
        {
            Angle result = angle1 + angle2;
            return result;
            // TODO: add assertions to method AngleTest.op_Addition(Angle, Angle)
        }

        [PexMethod]
        public void RadiansSet(Angle target, double value)
        {
            target.Radians = value;
            // TODO: add assertions to method AngleTest.RadiansSet(Angle, Double)
        }

        [PexMethod]
        public double RadiansGet(Angle target)
        {
            double result = target.Radians;
            return result;
            // TODO: add assertions to method AngleTest.RadiansGet(Angle)
        }

        [PexMethod]
        public bool IsUnknownGet(Angle target)
        {
            bool result = target.IsUnknown;
            return result;
            // TODO: add assertions to method AngleTest.IsUnknownGet(Angle)
        }

        [PexMethod]
        public Angle FromDegrees(double angleInDegrees)
        {
            Angle result = Angle.FromDegrees(angleInDegrees);
            return result;
            // TODO: add assertions to method AngleTest.FromDegrees(Double)
        }

        [PexMethod]
        public double DegreesGet(Angle target)
        {
            double result = target.Degrees;
            return result;
            // TODO: add assertions to method AngleTest.DegreesGet(Angle)
        }

        [PexMethod]
        public Angle Constructor(double angleInRadians)
        {
            Angle target = new Angle(angleInRadians);
            return target;
            // TODO: add assertions to method AngleTest.Constructor(Double)
        }
    }
}
