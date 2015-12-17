using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyclingPowerEstimation.Units;

namespace CyclingPowerEstimationUnitTests
{
    [TestClass]
    public class FrequencyTests
    {
        //Frequency construction tests:
        [TestMethod]
        public void ConstructPositiveFrequency()
        {
            Frequency frequency = new Frequency(60);
            double result = frequency.PerMinute;
            Assert.AreEqual(60, result);
        }
        [TestMethod]
        public void ConstructNoFrequency()
        {
            Frequency frequency = new Frequency(0);
            double result = frequency.PerMinute;
            Assert.AreEqual(0, result);
        }

        //Frequency operator tests:
        [TestMethod]
        public void FrequencyAddition()
        {
            Frequency frequency1 = new Frequency(30);
            Frequency frequency2 = new Frequency(60);
            Frequency result = new Frequency(frequency1.PerMinute + frequency2.PerMinute);
            Frequency actual = new Frequency(90);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void FrequencySubtraction()
        {
            Frequency frequency1 = new Frequency(60);
            Frequency frequency2 = new Frequency(30);
            Frequency result = new Frequency(frequency1.PerMinute - frequency2.PerMinute);
            Frequency actual = new Frequency(30);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void FrequencyDivision()
        {
            Frequency frequency = new Frequency(60);
            double divisor = 2.0;
            Frequency result = new Frequency((int)(frequency.PerMinute / divisor));
            Frequency actual = new Frequency(30);
            Assert.AreEqual(actual, result);
        }

        //Frequency readonly tests:
        [TestMethod]
        public void FrequencyZero()
        {
            Frequency frequency = Frequency.Zero;
            Frequency actual = new Frequency(0);
            Assert.AreEqual(actual, frequency);
        }

        [TestMethod]
        public void FrequencyUnknown()
        {
            Frequency frequency = Frequency.Unknown;
            Frequency actual = new Frequency(int.MinValue);
            Assert.AreEqual(actual, frequency);
        }
    }
}
