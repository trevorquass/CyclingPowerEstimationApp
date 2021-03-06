// <copyright file="GeolocationTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Tests
{
    [TestClass]
    [PexClass(typeof(Geolocation))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GeolocationTest
    {

        [PexMethod]
        public Geolocation Constructor()
        {
            Geolocation target = new Geolocation();
            return target;
            // TODO: add assertions to method GeolocationTest.Constructor()
        }

        [PexMethod]
        public Geolocation Constructor01(string country, string city)
        {
            Geolocation target = new Geolocation(country, city);
            return target;
            // TODO: add assertions to method GeolocationTest.Constructor01(String, String)
        }
    }
}
