using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kastanek.UnitConverter.Tests
{
    [TestClass]
    public class LengthUnitConverterTest
    {
        [TestMethod]
        public void TestMeterToMillimeter()
        {
            string convertedValue = UnitConverter.Convert("42 meter", "millimeter");
            Assert.AreEqual("42000 millimeter", convertedValue);
        }

        [TestMethod]
        public void TestMeterToMeter()
        {
            string convertedValue = UnitConverter.Convert("42 meter", "meter");
            Assert.AreEqual("42 meter", convertedValue);
        }

        [TestMethod]
        public void TestZeptometerToMeter()
        {
            string convertedValue = UnitConverter.Convert("42 zeptometer", "meter");
            Assert.AreEqual("0.000000000000000000042 meter", convertedValue);
        }

        [TestMethod]
        public void TestYoctometerToYottameter()
        {
            string convertedValue = UnitConverter.Convert("1 yoctometer", "yottameter");
            Assert.AreEqual("0.000000000000000000000000000000000000000000000001 yottameter", convertedValue);
        }

        [TestMethod]
        public void TestYottameterToYoctometer()
        {
            string convertedValue = UnitConverter.Convert("1 yottameter", "yoctometer");
            Assert.AreEqual("1000000000000000000000000000000000000000000000000 yoctometer", convertedValue);
        }

        [TestMethod]
        public void TestYottameterToMeter()
        {
            string convertedValue = UnitConverter.Convert("42 yottameter", "meter");
            Assert.AreEqual("42000000000000000000000000 meter", convertedValue);
        }

        [TestMethod]
        public void TestZeroValue()
        {
            string convertedValue = UnitConverter.Convert("0 meter", "gigameter");
            Assert.AreEqual("0 gigameter", convertedValue);
        }

        [TestMethod]
        public void TestNegativeValue()
        {
            string convertedValue = UnitConverter.Convert("-400 centimeter", "meter");
            Assert.AreEqual("-4 meter", convertedValue);
        }

        [TestMethod]
        public void TestDecimalValue()
        {
            string convertedValue = UnitConverter.Convert("4.2 kilometer", "meter");
            Assert.AreEqual("4200 meter", convertedValue);
        }

        [TestMethod]
        public void TestNegativeDecimalValue()
        {
            string convertedValue = UnitConverter.Convert("-8.4 kilometer", "meter");
            Assert.AreEqual("-8400 meter", convertedValue);
        }

        [TestMethod]
        public void TestCentimeterToInch()
        {
            string convertedValue = UnitConverter.Convert("21 centimeter", "inch");
            Assert.AreEqual("8.26771653543307 inch", convertedValue);
        }

        [TestMethod]
        public void TestMegainchToDecimeter()
        {
            string convertedValue = UnitConverter.Convert("999 megainch", "decimeter");
            Assert.AreEqual("253746000 decimeter", convertedValue);
        }

        [TestMethod]
        public void TestInchToFoot()
        {
            string convertedValue = UnitConverter.Convert("21.42 inch", "foot");
            Assert.AreEqual("1.785 foot", convertedValue);
        }

        [TestMethod]
        public void TestMegafootToMillinch()
        {
            string convertedValue = UnitConverter.Convert("123 megafoot", "milliinch");
            Assert.AreEqual("1476000000000 milliinch", convertedValue);
        }

        [TestMethod]
        public void TestKilometerToFoot()
        {
            string convertedValue = UnitConverter.Convert("42.21 kilometer", "foot");
            Assert.AreEqual("138484.251968504 foot", convertedValue);
        }

        [TestMethod]
        public void TestPetafootToGigameter()
        {
            string convertedValue = UnitConverter.Convert("123 petafoot", "gigameter");
            Assert.AreEqual("37490400 gigameter", convertedValue);
        }
    }
}
