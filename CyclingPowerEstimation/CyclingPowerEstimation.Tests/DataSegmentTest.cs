using CyclingPowerEstimation.Units;
// <copyright file="DataSegmentTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Tests
{
    [TestClass]
    [PexClass(typeof(DataSegment))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DataSegmentTest
    {

        [PexMethod]
        public Acceleration AccelerationGet([PexAssumeUnderTest]DataSegment target)
        {
            Acceleration result = target.Acceleration;
            return result;
            // TODO: add assertions to method DataSegmentTest.AccelerationGet(DataSegment)
        }

        [PexMethod]
        public Distance AltitudeGet([PexAssumeUnderTest]DataSegment target)
        {
            Distance result = target.Altitude;
            return result;
            // TODO: add assertions to method DataSegmentTest.AltitudeGet(DataSegment)
        }

        [PexMethod]
        public Frequency CadenceGet([PexAssumeUnderTest]DataSegment target)
        {
            Frequency result = target.Cadence;
            return result;
            // TODO: add assertions to method DataSegmentTest.CadenceGet(DataSegment)
        }

        [PexMethod]
        public void Calculate(
            [PexAssumeUnderTest]DataSegment target,
            Rider rider,
            Reality reality
        )
        {
            target.Calculate(rider, reality);
            // TODO: add assertions to method DataSegmentTest.Calculate(DataSegment, Rider, Reality)
        }

        [PexMethod]
        public DataSegment Constructor(DataPoint start, DataPoint end)
        {
            DataSegment target = new DataSegment(start, end);
            return target;
            // TODO: add assertions to method DataSegmentTest.Constructor(DataPoint, DataPoint)
        }

        [PexMethod]
        public TimeSpan ElapsedTimeGet([PexAssumeUnderTest]DataSegment target)
        {
            TimeSpan result = target.ElapsedTime;
            return result;
            // TODO: add assertions to method DataSegmentTest.ElapsedTimeGet(DataSegment)
        }

        [PexMethod]
        public double GradientGet([PexAssumeUnderTest]DataSegment target)
        {
            double result = target.Gradient;
            return result;
            // TODO: add assertions to method DataSegmentTest.GradientGet(DataSegment)
        }

        [PexMethod]
        public Frequency HeartRateGet([PexAssumeUnderTest]DataSegment target)
        {
            Frequency result = target.HeartRate;
            return result;
            // TODO: add assertions to method DataSegmentTest.HeartRateGet(DataSegment)
        }

        [PexMethod]
        public Angle LatitudeGet([PexAssumeUnderTest]DataSegment target)
        {
            Angle result = target.Latitude;
            return result;
            // TODO: add assertions to method DataSegmentTest.LatitudeGet(DataSegment)
        }

        [PexMethod]
        public Distance LengthGet([PexAssumeUnderTest]DataSegment target)
        {
            Distance result = target.Length;
            return result;
            // TODO: add assertions to method DataSegmentTest.LengthGet(DataSegment)
        }

        [PexMethod]
        public Angle LongitudeGet([PexAssumeUnderTest]DataSegment target)
        {
            Angle result = target.Longitude;
            return result;
            // TODO: add assertions to method DataSegmentTest.LongitudeGet(DataSegment)
        }

        [PexMethod]
        public Power PowerGet([PexAssumeUnderTest]DataSegment target)
        {
            Power result = target.Power;
            return result;
            // TODO: add assertions to method DataSegmentTest.PowerGet(DataSegment)
        }

        [PexMethod]
        public Speed SpeedGet([PexAssumeUnderTest]DataSegment target)
        {
            Speed result = target.Speed;
            return result;
            // TODO: add assertions to method DataSegmentTest.SpeedGet(DataSegment)
        }

        [PexMethod]
        public Force TotalForceGet([PexAssumeUnderTest]DataSegment target)
        {
            Force result = target.TotalForce;
            return result;
            // TODO: add assertions to method DataSegmentTest.TotalForceGet(DataSegment)
        }
    }
}
