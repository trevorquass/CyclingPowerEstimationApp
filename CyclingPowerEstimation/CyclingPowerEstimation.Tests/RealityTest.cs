// <copyright file="RealityTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Tests
{
    [TestClass]
    [PexClass(typeof(Reality))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RealityTest
    {

        [PexMethod]
        public double AirDensity([PexAssumeUnderTest]Reality target, double altitude)
        {
            double result = target.AirDensity(altitude);
            return result;
            // TODO: add assertions to method RealityTest.AirDensity(Reality, Double)
        }

        [PexMethod]
        public double CoefficientOfRollingResistanceGet([PexAssumeUnderTest]Reality target)
        {
            double result = target.CoefficientOfRollingResistance;
            return result;
            // TODO: add assertions to method RealityTest.CoefficientOfRollingResistanceGet(Reality)
        }

        [PexMethod]
        public void CoefficientOfRollingResistanceSet([PexAssumeUnderTest]Reality target, double value)
        {
            target.CoefficientOfRollingResistance = value;
            // TODO: add assertions to method RealityTest.CoefficientOfRollingResistanceSet(Reality, Double)
        }

        [PexMethod]
        public Reality Constructor()
        {
            Reality target = new Reality();
            return target;
            // TODO: add assertions to method RealityTest.Constructor()
        }

        [PexMethod]
        public double DragCoefficientGet([PexAssumeUnderTest]Reality target)
        {
            double result = target.DragCoefficient;
            return result;
            // TODO: add assertions to method RealityTest.DragCoefficientGet(Reality)
        }

        [PexMethod]
        public void DragCoefficientSet([PexAssumeUnderTest]Reality target, double value)
        {
            target.DragCoefficient = value;
            // TODO: add assertions to method RealityTest.DragCoefficientSet(Reality, Double)
        }

        [PexMethod]
        public double EffectiveFrontalAreaGet([PexAssumeUnderTest]Reality target)
        {
            double result = target.EffectiveFrontalArea;
            return result;
            // TODO: add assertions to method RealityTest.EffectiveFrontalAreaGet(Reality)
        }

        [PexMethod]
        public void EffectiveFrontalAreaSet([PexAssumeUnderTest]Reality target, double value)
        {
            target.EffectiveFrontalArea = value;
            // TODO: add assertions to method RealityTest.EffectiveFrontalAreaSet(Reality, Double)
        }

        [PexMethod]
        public double PressureAtAltitude([PexAssumeUnderTest]Reality target, double altitude)
        {
            double result = target.PressureAtAltitude(altitude);
            return result;
            // TODO: add assertions to method RealityTest.PressureAtAltitude(Reality, Double)
        }

        [PexMethod]
        public double TemperatureGet([PexAssumeUnderTest]Reality target)
        {
            double result = target.Temperature;
            return result;
            // TODO: add assertions to method RealityTest.TemperatureGet(Reality)
        }

        [PexMethod]
        public void TemperatureSet([PexAssumeUnderTest]Reality target, double value)
        {
            target.Temperature = value;
            // TODO: add assertions to method RealityTest.TemperatureSet(Reality, Double)
        }
    }
}
