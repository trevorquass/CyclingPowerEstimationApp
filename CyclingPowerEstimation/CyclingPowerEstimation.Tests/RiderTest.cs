// <copyright file="RiderTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Tests
{
    [TestClass]
    [PexClass(typeof(Rider))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RiderTest
    {

        [PexMethod]
        public Rider Constructor(double massInKg, double bikeMassInKg)
        {
            Rider target = new Rider(massInKg, bikeMassInKg);
            return target;
            // TODO: add assertions to method RiderTest.Constructor(Double, Double)
        }

        [PexMethod]
        public double MassIncludingBikeGet([PexAssumeUnderTest]Rider target)
        {
            double result = target.MassIncludingBike;
            return result;
            // TODO: add assertions to method RiderTest.MassIncludingBikeGet(Rider)
        }
    }
}
