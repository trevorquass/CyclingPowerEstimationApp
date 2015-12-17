using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using CyclingPowerEstimation.IO;
using Microsoft.Pex.Framework.Generated;
// <copyright file="TcxDataSegmentReaderTest.Constructor.g.cs">Copyright ©  2015</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace CyclingPowerEstimation.IO.Tests
{
    public partial class TcxDataSegmentReaderTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(TcxDataSegmentReaderTest))]
        public void Constructor788()
        {
            using (PexDisposableContext disposables = PexDisposableContext.Create())
            {
              TcxDataSegmentReader tcxDataSegmentReader;
              tcxDataSegmentReader = this.Constructor((Stream)null);
              disposables.Add((IDisposable)tcxDataSegmentReader);
              disposables.Dispose();
              Assert.IsNotNull((object)tcxDataSegmentReader);
            }
        }
    }
}
