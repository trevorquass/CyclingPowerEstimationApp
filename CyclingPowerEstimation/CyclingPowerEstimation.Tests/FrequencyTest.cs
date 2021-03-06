// <copyright file="FrequencyTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation.Units;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.Units.Tests
{
    [TestClass]
    [PexClass(typeof(Frequency))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FrequencyTest
    {

        [PexMethod]
        public Frequency op_Subtraction(Frequency frequency1, Frequency frequency2)
        {
            Frequency result = frequency1 - frequency2;
            return result;
            // TODO: add assertions to method FrequencyTest.op_Subtraction(Frequency, Frequency)
        }

        [PexMethod]
        public int op_Implicit(Frequency frequency)
        {
            int result = (int)frequency;
            return result;
            // TODO: add assertions to method FrequencyTest.op_Implicit(Frequency)
        }

        [PexMethod]
        public Frequency op_Division(Frequency frequency, double divisor)
        {
            Frequency result = frequency / divisor;
            return result;
            // TODO: add assertions to method FrequencyTest.op_Division(Frequency, Double)
        }

        [PexMethod]
        public Frequency op_Addition(Frequency frequency1, Frequency frequency2)
        {
            Frequency result = frequency1 + frequency2;
            return result;
            // TODO: add assertions to method FrequencyTest.op_Addition(Frequency, Frequency)
        }

        [PexMethod]
        public void PerMinuteSet(Frequency target, int value)
        {
            target.PerMinute = value;
            // TODO: add assertions to method FrequencyTest.PerMinuteSet(Frequency, Int32)
        }

        [PexMethod]
        public int PerMinuteGet(Frequency target)
        {
            int result = target.PerMinute;
            return result;
            // TODO: add assertions to method FrequencyTest.PerMinuteGet(Frequency)
        }

        [PexMethod]
        public bool IsUnknownGet(Frequency target)
        {
            bool result = target.IsUnknown;
            return result;
            // TODO: add assertions to method FrequencyTest.IsUnknownGet(Frequency)
        }

        [PexMethod]
        public Frequency Constructor(int frequencyPerMinute)
        {
            Frequency target = new Frequency(frequencyPerMinute);
            return target;
            // TODO: add assertions to method FrequencyTest.Constructor(Int32)
        }
    }
}
