using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TOPO3.Core;

namespace UnitTestTOPO3
{
    [TestClass]
    public class LengthFromSIToRussianTests
    {
        [TestMethod]
        public void From1MetreToArshinTest()
        {
            TConvertor convertor = new TConvertor();
            double expected = convertor.LengthFromSIToRussian(1, LengthSI.Metre, LengthRussian.Arshin);
            Assert.AreEqual(expected, 1/0.7112, 0.00001);
        }

        [TestMethod]
        public void From1MetreToSazhenTest()
        {
            TConvertor convertor = new TConvertor();
            double expected = convertor.LengthFromSIToRussian(1, LengthSI.Metre, LengthRussian.Sazhen);
            Assert.AreEqual(expected, 1/2.1336, 0.00001);
        }

        [TestMethod]
        public void From1MetreToVerstaTest()
        {
            TConvertor convertor = new TConvertor();
            double expected = convertor.LengthFromSIToRussian(1, LengthSI.Metre, LengthRussian.Versta);
            Assert.AreEqual(expected, 1 / 1066.8, 0.00001);
        }

        [TestMethod]
        public void From1MetreToPyadTest()
        {
            TConvertor convertor = new TConvertor();
            double expected = convertor.LengthFromSIToRussian(1, LengthSI.Metre, LengthRussian.Pyad);
            Assert.AreEqual(expected, 1 / 0.1778, 0.00001);
        }
    }
}
