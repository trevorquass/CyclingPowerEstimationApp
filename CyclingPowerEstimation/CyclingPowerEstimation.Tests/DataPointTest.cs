using CyclingPowerEstimation.Units;
// <copyright file="DataPointTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Tests
{
    [TestClass]
    [PexClass(typeof(DataPoint))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DataPointTest
    {

        [PexMethod]
        public Distance AscentToPoint([PexAssumeUnderTest]DataPoint target, DataPoint otherPoint)
        {
            Distance result = target.AscentToPoint(otherPoint);
            return result;
            // TODO: add assertions to method DataPointTest.AscentToPoint(DataPoint, DataPoint)
        }

        [PexMethod]
        public DataPoint Constructor(
            DateTimeOffset dateTime,
            Distance altitude,
            Frequency cadence,
            Distance totalDistance,
            Speed speed,
            Frequency heartRateInBpm,
            Angle latitude,
            Angle longitude
        )
        {
            DataPoint target = new DataPoint
                                   (dateTime, altitude, cadence, totalDistance, speed, heartRateInBpm, latitude, longitude);
            return target;
            // TODO: add assertions to method DataPointTest.Constructor(DateTimeOffset, Distance, Frequency, Distance, Speed, Frequency, Angle, Angle)
        }

        [PexMethod]
        public Distance DistanceToPoint([PexAssumeUnderTest]DataPoint target, DataPoint otherPoint)
        {
            Distance result = target.DistanceToPoint(otherPoint);
            return result;
            // TODO: add assertions to method DataPointTest.DistanceToPoint(DataPoint, DataPoint)
        }

        [PexMethod]
        public double GradientToPoint([PexAssumeUnderTest]DataPoint target, DataPoint otherPoint)
        {
            double result = target.GradientToPoint(otherPoint);
            return result;
            // TODO: add assertions to method DataPointTest.GradientToPoint(DataPoint, DataPoint)
        }

        [PexMethod]
        public Distance HaversineDistanceToPoint([PexAssumeUnderTest]DataPoint target, DataPoint otherPoint)
        {
            Distance result = target.HaversineDistanceToPoint(otherPoint);
            return result;
            // TODO: add assertions to method DataPointTest.HaversineDistanceToPoint(DataPoint, DataPoint)
        }
    }
}
