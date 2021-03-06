using System.IO;
// <copyright file="TcxDataSegmentWriterTest.cs">Copyright ©  2015</copyright>

using System;
using CyclingPowerEstimation.IO;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclingPowerEstimation.IO.Tests
{
    [TestClass]
    [PexClass(typeof(TcxDataSegmentWriter))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TcxDataSegmentWriterTest
    {

        [PexMethod]
        public TcxDataSegmentWriter Constructor(Stream stream)
        {
            TcxDataSegmentWriter target = new TcxDataSegmentWriter(stream);
            return target;
            // TODO: add assertions to method TcxDataSegmentWriterTest.Constructor(Stream)
        }

        [PexMethod]
        public void Dispose([PexAssumeUnderTest]TcxDataSegmentWriter target)
        {
            target.Dispose();
            // TODO: add assertions to method TcxDataSegmentWriterTest.Dispose(TcxDataSegmentWriter)
        }
    }
}
