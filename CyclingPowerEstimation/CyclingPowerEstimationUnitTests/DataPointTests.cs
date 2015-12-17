using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation;
using CyclingPowerEstimation.Units;
using Rhino.Mocks;

namespace CyclingPowerEstimationUnitTests
{
    [TestClass]
    public class DataPointTests
    {
        [TestMethod]
        public void DistanceToPointIsCorrect_BothTotalDistancesAreKnown()
        {
            var point1 = new DataPoint(DateTime.Now, Distance.Zero, Frequency.Zero, new Distance(100.0), Speed.Zero, Frequency.Zero, Angle.FromDegrees(0), Angle.FromDegrees(0));
            var point2 = new DataPoint(DateTime.Now, Distance.Zero, Frequency.Zero, new Distance(200.0), Speed.Zero, Frequency.Zero, Angle.FromDegrees(0), Angle.FromDegrees(0));
            Assert.AreEqual(100.0, point1.DistanceToPoint(point2).Meters);
        }

        [TestMethod]
        public void DistanceToPointIsCorrect_BothTotalDistancesAreKnownAndSame()
        {
            var point1 = new DataPoint(DateTime.Now, Distance.Zero, Frequency.Zero, new Distance(100.0), Speed.Zero, Frequency.Zero, Angle.FromDegrees(0), Angle.FromDegrees(0));
            var point2 = new DataPoint(DateTime.Now, Distance.Zero, Frequency.Zero, new Distance(100.0), Speed.Zero, Frequency.Zero, Angle.FromDegrees(0), Angle.FromDegrees(0));
            Assert.AreEqual(0.0, point1.DistanceToPoint(point2).Meters);
        }

        [TestMethod]
        public void DistanceToPointIsCorrect_TotalDistanceIsNotKnown_AltitudeIsKnownAndSame_PositionIsKnownAndSame()
        {
            var point1 = new DataPoint(DateTime.Now, new Distance(10.0), Frequency.Zero, Distance.Unknown, Speed.Zero, Frequency.Zero, Angle.FromDegrees(45), Angle.FromDegrees(45));
            var point2 = new DataPoint(DateTime.Now, new Distance(10.0), Frequency.Zero, new Distance(100.0), Speed.Zero, Frequency.Zero, Angle.FromDegrees(45), Angle.FromDegrees(45));
            Assert.AreEqual(0.0, point1.DistanceToPoint(point2).Meters);
        }

        [TestMethod]
        public void DistanceToPointIsCorrect_TotalDistanceIsNotKnown_AltitudeIsKnownAndSame_PositionIsKnown()
        {
            var point1 = new DataPoint(DateTime.Now, new Distance(10.0), Frequency.Zero, Distance.Unknown, Speed.Zero, Frequency.Zero, Angle.FromDegrees(43.05), Angle.FromDegrees(-87.95));
            var point2 = new DataPoint(DateTime.Now, new Distance(10.0), Frequency.Zero, Distance.Unknown, Speed.Zero, Frequency.Zero, Angle.FromDegrees(44.5133), Angle.FromDegrees(-88.0158));
            Assert.AreEqual(162610, point1.DistanceToPoint(point2).Meters, 0.5);
        }

        [TestMethod]
        public void DistanceToPointIsCorrect_TotalDistanceIsNotKnown_AltitudeIsKnown_PositionIsKnownAndSame()
        {
            var point1 = new DataPoint(DateTime.Now, new Distance(5.0), Frequency.Zero, Distance.Unknown, Speed.Zero, Frequency.Zero, Angle.FromDegrees(43.05), Angle.FromDegrees(-87.95));
            var point2 = new DataPoint(DateTime.Now, new Distance(10.0), Frequency.Zero, new Distance(10.0), Speed.Zero, Frequency.Zero, Angle.FromDegrees(43.05), Angle.FromDegrees(-87.95));
            Assert.AreEqual(5.0, point1.DistanceToPoint(point2).Meters, 0.005);
        }

        [TestMethod]
        public void DistanceToPointIsCorrect_TotalDistanceIsNotKnown_AltitudeIsNotKnown_PositionIsKnown()
        {
            var point1 = new DataPoint(DateTime.Now, Distance.Unknown, Frequency.Zero, Distance.Unknown, Speed.Zero, Frequency.Zero, Angle.FromDegrees(43.05), Angle.FromDegrees(-87.95));
            var point2 = new DataPoint(DateTime.Now, new Distance(10.0), Frequency.Zero, new Distance(10.0), Speed.Zero, Frequency.Zero, Angle.FromDegrees(43.05), Angle.FromDegrees(-87.95));
            Assert.IsTrue(point1.DistanceToPoint(point2).IsUnknown);
        }

        [TestMethod]
        public void DistanceToPointIsCorrect_TotalDistanceIsNotKnown_AltitudeIsKnown_PositionIsNotKnown()
        {
            var point1 = new DataPoint(DateTime.Now, new Distance(5.0), Frequency.Zero, Distance.Unknown, Speed.Zero, Frequency.Zero, Angle.Unknown, Angle.FromDegrees(-87.95));
            var point2 = new DataPoint(DateTime.Now, new Distance(10.0), Frequency.Zero, new Distance(10.0), Speed.Zero, Frequency.Zero, Angle.FromDegrees(43.05), Angle.FromDegrees(-87.95));
            Assert.IsTrue(point1.DistanceToPoint(point2).IsUnknown);
        }

        [TestMethod]
        public void HaversineTest()
        {
            var point1 = new DataPoint(DateTime.Now, Distance.Unknown, Frequency.Zero, Distance.Unknown, Speed.Zero, Frequency.Zero, Angle.FromDegrees(43.05), Angle.FromDegrees(-87.95));
            var point2 = new DataPoint(DateTime.Now, Distance.Unknown, Frequency.Zero, Distance.Unknown, Speed.Zero, Frequency.Zero, Angle.FromDegrees(44.5133), Angle.FromDegrees(-88.0158));
            Assert.AreEqual(162610, point1.HaversineDistanceToPoint(point2).Meters, 0.5);
        }
    }
}
