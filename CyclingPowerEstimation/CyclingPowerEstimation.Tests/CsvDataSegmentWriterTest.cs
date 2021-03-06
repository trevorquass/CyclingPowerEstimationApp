using System.Collections.Generic;
using CyclingPowerEstimation;
using System.IO;
// <copyright file="CsvDataSegmentWriterTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation.IO;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.IO.Tests
{
    [TestClass]
    [PexClass(typeof(CsvDataSegmentWriter))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CsvDataSegmentWriterTest
    {

        [PexMethod]
        public CsvDataSegmentWriter Constructor(Stream stream)
        {
            CsvDataSegmentWriter target = new CsvDataSegmentWriter(stream);
            return target;
            // TODO: add assertions to method CsvDataSegmentWriterTest.Constructor(Stream)
        }

        [PexMethod]
        public void Write(
            [PexAssumeUnderTest]CsvDataSegmentWriter target,
            List<DataSegment> dataSegments,
            GpsDeviceInfo gpsDeviceInfo
        )
        {
            target.Write(dataSegments, gpsDeviceInfo);
            // TODO: add assertions to method CsvDataSegmentWriterTest.Write(CsvDataSegmentWriter, List`1<DataSegment>, GpsDeviceInfo)
        }
    }
}
