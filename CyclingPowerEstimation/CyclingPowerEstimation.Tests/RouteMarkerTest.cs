using GMap.NET;
// <copyright file="RouteMarkerTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Tests
{
    [TestClass]
    [PexClass(typeof(RouteMarker))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RouteMarkerTest
    {

        [PexMethod]
        public RouteMarker Constructor(PointLatLng point)
        {
            RouteMarker target = new RouteMarker(point);
            return target;
            // TODO: add assertions to method RouteMarkerTest.Constructor(PointLatLng)
        }
    }
}
