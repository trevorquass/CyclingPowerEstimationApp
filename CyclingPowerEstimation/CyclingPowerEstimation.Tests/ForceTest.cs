// <copyright file="ForceTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation.Units;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Units.Tests
{
    [TestClass]
    [PexClass(typeof(Force))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ForceTest
    {

        [PexMethod]
        public Force op_Subtraction(Force force1, Force force2)
        {
            Force result = force1 - force2;
            return result;
            // TODO: add assertions to method ForceTest.op_Subtraction(Force, Force)
        }

        [PexMethod]
        public double op_Implicit(Force force)
        {
            double result = (double)force;
            return result;
            // TODO: add assertions to method ForceTest.op_Implicit(Force)
        }

        [PexMethod]
        public Force op_Division(Force force, double divisor)
        {
            Force result = force / divisor;
            return result;
            // TODO: add assertions to method ForceTest.op_Division(Force, Double)
        }

        [PexMethod]
        public Power op_Multiply(Force force, Speed speed)
        {
            Power result = force * speed;
            return result;
            // TODO: add assertions to method ForceTest.op_Multiply(Force, Speed)
        }

        [PexMethod]
        public Force op_Addition(Force force1, Force force2)
        {
            Force result = force1 + force2;
            return result;
            // TODO: add assertions to method ForceTest.op_Addition(Force, Force)
        }

        [PexMethod]
        public void NewtonsSet(Force target, double value)
        {
            target.Newtons = value;
            // TODO: add assertions to method ForceTest.NewtonsSet(Force, Double)
        }

        [PexMethod]
        public double NewtonsGet(Force target)
        {
            double result = target.Newtons;
            return result;
            // TODO: add assertions to method ForceTest.NewtonsGet(Force)
        }

        [PexMethod]
        public bool IsUnknownGet(Force target)
        {
            bool result = target.IsUnknown;
            return result;
            // TODO: add assertions to method ForceTest.IsUnknownGet(Force)
        }

        [PexMethod]
        public Force Constructor(double forceInNewtons)
        {
            Force target = new Force(forceInNewtons);
            return target;
            // TODO: add assertions to method ForceTest.Constructor(Double)
        }
    }
}
