using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kastanek.UnitConverter.Tests
{
    [TestClass]
    public class DataUnitConverterTest
    {
        [TestMethod]
        public void TestByteToMillibyte()
        {
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert("42 byte", "milibyte"));
        }

        [TestMethod]
        public void TestByteToByte()
        {
            string convertedValue = UnitConverter.Convert("42 byte", "byte");
            Assert.AreEqual("42 byte", convertedValue);
        }

        [TestMethod]
        public void TestBitToByte()
        {
            string convertedValue = UnitConverter.Convert("42 bit", "byte");
            Assert.AreEqual("5.25 byte", convertedValue);
        }

        [TestMethod]
        public void TestYoctobyteToYottabyte()
        {
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert("1 yoctobyte", "yottabyte"));
        }

        [TestMethod]
        public void TestYottabyteToYoctobyte()
        {
            Assert.ThrowsException<InvalidOperationException>(() => UnitConverter.Convert("1 yottabyte", "yoctobyte"));
            
        }

        [TestMethod]
        public void TestYottabitToBit()
        {
            string convertedValue = UnitConverter.Convert("42 yottabit", "bit");
            Assert.AreEqual("42000000000000000000000000 bit", convertedValue);
        }

        [TestMethod]
        public void TestZeroValue()
        {
            string convertedValue = UnitConverter.Convert("0 byte", "gigabit");
            Assert.AreEqual("0 gigabit", convertedValue);
        }

        [TestMethod]
        public void TestNegativeValue()
        {
            string convertedValue = UnitConverter.Convert("-400 byte", "kilobit");
            Assert.AreEqual("-3.2 kilobit", convertedValue);
        }

        [TestMethod]
        public void TestDecimalValue()
        {
            string convertedValue = UnitConverter.Convert("4.2 kilobit", "byte");
            Assert.AreEqual("525 byte", convertedValue);
        }

        [TestMethod]
        public void TestNegativeDecimalValue()
        {
            string convertedValue = UnitConverter.Convert("-8.4 kilobyte", "megabit");
            Assert.AreEqual("-0.0672 megabit", convertedValue);
        }
    }
}
