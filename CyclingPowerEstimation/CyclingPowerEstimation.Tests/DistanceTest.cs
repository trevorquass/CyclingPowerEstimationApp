// <copyright file="DistanceTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation.Units;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Units.Tests
{
    [TestClass]
    [PexClass(typeof(Distance))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DistanceTest
    {

        [PexMethod]
        public Distance op_Subtraction(Distance distance1, Distance distance2)
        {
            Distance result = distance1 - distance2;
            return result;
            // TODO: add assertions to method DistanceTest.op_Subtraction(Distance, Distance)
        }

        [PexMethod]
        public double op_Implicit(Distance distance)
        {
            double result = (double)distance;
            return result;
            // TODO: add assertions to method DistanceTest.op_Implicit(Distance)
        }

        [PexMethod]
        public Speed op_Division01(Distance distance, TimeSpan divisor)
        {
            Speed result = distance / divisor;
            return result;
            // TODO: add assertions to method DistanceTest.op_Division01(Distance, TimeSpan)
        }

        [PexMethod]
        public Distance op_Division(Distance distance, double divisor)
        {
            Distance result = distance / divisor;
            return result;
            // TODO: add assertions to method DistanceTest.op_Division(Distance, Double)
        }

        [PexMethod]
        public Distance op_Addition(Distance distance1, Distance distance2)
        {
            Distance result = distance1 + distance2;
            return result;
            // TODO: add assertions to method DistanceTest.op_Addition(Distance, Distance)
        }

        [PexMethod]
        public double MilesGet(Distance target)
        {
            double result = target.Miles;
            return result;
            // TODO: add assertions to method DistanceTest.MilesGet(Distance)
        }

        [PexMethod]
        public void MetersSet(Distance target, double value)
        {
            target.Meters = value;
            // TODO: add assertions to method DistanceTest.MetersSet(Distance, Double)
        }

        [PexMethod]
        public double MetersGet(Distance target)
        {
            double result = target.Meters;
            return result;
            // TODO: add assertions to method DistanceTest.MetersGet(Distance)
        }

        [PexMethod]
        public double KilometersGet(Distance target)
        {
            double result = target.Kilometers;
            return result;
            // TODO: add assertions to method DistanceTest.KilometersGet(Distance)
        }

        [PexMethod]
        public bool IsUnknownGet(Distance target)
        {
            bool result = target.IsUnknown;
            return result;
            // TODO: add assertions to method DistanceTest.IsUnknownGet(Distance)
        }

        [PexMethod]
        public Distance Constructor(double distanceInMeters)
        {
            Distance target = new Distance(distanceInMeters);
            return target;
            // TODO: add assertions to method DistanceTest.Constructor(Double)
        }
    }
}
