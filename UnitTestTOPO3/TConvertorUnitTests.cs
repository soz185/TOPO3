using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TOPO3.Core;

namespace UnitTestTOPO3
{
    [TestClass]
    public class TConvertorUnitTests
    {
        [TestMethod]
        public void ConvertorClassCreationTest()
        {
            TConvertor convertor = new TConvertor();
            Assert.IsNotNull(convertor);
        }

        [TestMethod]
        public void LengthSIEnumMetreTest()
        {
            Assert.IsNotNull(LengthSI.Metre);
        }

        [TestMethod]
        public void LengthSIEnumCentimetreTest()
        {
            Assert.IsNotNull(LengthSI.Centimetre);
        }
    }
}
