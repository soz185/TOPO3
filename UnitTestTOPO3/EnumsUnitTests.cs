﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TOPO3.Core;

namespace UnitTestTOPO3
{
    [TestClass]
    public class EnumsUnitTests
    {
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

        [TestMethod]
        public void LengthSIEnumMillimetreTest()
        {
            Assert.IsNotNull(LengthSI.Millimetre);
        }

    }
}
