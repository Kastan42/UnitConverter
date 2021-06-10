using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kastanek.UnitConverter.Tests
{
    [TestClass]
    public class UnitConverterTest
    {
        [TestMethod]
        public void TestNullValue()
        {
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert(null, "millimeter"));
        }

        [TestMethod]
        public void TestNullUnitTo()
        {
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert("42 meters", null));
        }

        [TestMethod]
        public void TestInfiniteValue()
        {
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert("NaN meters", null));
        }

        [TestMethod]
        public void TestNullUnitFrom()
        {
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert("42", "millimeter"));
        }

        [TestMethod]
        public void TestTextValue()
        {
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert("xxx", "millimeter"));
        }

        [TestMethod]
        public void TestInvalidUnitFromValue()
        {
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert("42 xxx", "millimeter"));
        }

        [TestMethod]
        public void TestInvalidUnitToValue()
        {
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert("42 meter", "xxx"));
        }

        [TestMethod]
        public void TestIncompatibleUnits()
        {
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert("42 meter", "bit"));
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert("42 celsius", "bit"));
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert("42 byte", "centimeter"));
        }

        [TestMethod]
        public void TestMoreSpaces()
        {
            string convertedValue = UnitConverter.Convert("42               meter", "meter");
            Assert.AreEqual("42 meter", convertedValue);
        }

        [TestMethod]
        public void TestDifferentCase()
        {
            string convertedValue = UnitConverter.Convert("42 CeNtIMeTeR", "cEnTimEtEr");
            Assert.AreEqual("42 cEnTimEtEr", convertedValue);
        }
    }
}
