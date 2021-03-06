using System.IO;
// <copyright file="TcxDataSegmentReaderTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation.IO;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.IO.Tests
{
    [TestClass]
    [PexClass(typeof(TcxDataSegmentReader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TcxDataSegmentReaderTest
    {

        [PexMethod]
        public TcxDataSegmentReader Constructor(Stream stream)
        {
            TcxDataSegmentReader target = new TcxDataSegmentReader(stream);
            return target;
            // TODO: add assertions to method TcxDataSegmentReaderTest.Constructor(Stream)
        }

        [PexMethod]
        public void Dispose([PexAssumeUnderTest]TcxDataSegmentReader target)
        {
            target.Dispose();
            // TODO: add assertions to method TcxDataSegmentReaderTest.Dispose(TcxDataSegmentReader)
        }
    }
}
