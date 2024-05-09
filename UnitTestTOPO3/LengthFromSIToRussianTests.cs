using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TOPO3.Core;

namespace UnitTestTOPO3
{
    [TestClass]
    class LengthFromSIToRussianTests
    {
        [TestMethod]
        public void From1MetreToArshinTest()
        {
            double expected = LengthFromSIToRussian(1, LengthSI.Metre, LengthRussian.Arshin);
            Assert.AreEqual(expected, 0.7112);
        }
    }
}
