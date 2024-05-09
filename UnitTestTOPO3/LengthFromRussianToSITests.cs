using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TOPO3.Core;

namespace UnitTestTOPO3
{
    [TestClass]
    public class LengthFromRussianToSITests
    {
        [TestMethod]
        public void From1ArshinToMetreTest()
        {
            TConvertor convertor = new TConvertor();
            double expected = convertor.LengthFromRussianToSI(1, LengthRussian.Arshin, LengthSI.Metre);
            Assert.AreEqual(expected, 0.7112, 0.00001);
        }

        [TestMethod]
        public void From1SazhenToMetreTest()
        {
            TConvertor convertor = new TConvertor();
            double expected = convertor.LengthFromRussianToSI(1, LengthRussian.Sazhen, LengthSI.Metre);
            Assert.AreEqual(expected, 2.1336, 0.00001);
        }

        [TestMethod]
        public void From2SazhenToCentimetreTest()
        {
            TConvertor convertor = new TConvertor();
            double expected = convertor.LengthFromRussianToSI(2, LengthRussian.Sazhen, LengthSI.Centimetre);
            Assert.AreEqual(expected, 426.72, 0.00001);
        }
    }
}
