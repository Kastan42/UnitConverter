using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kastanek.UnitConverter.Tests
{
    [TestClass]
    public class TemperatureConverterTest
    {
        [TestMethod]
        public void TestCelsiusToFahrenheit()
        {
            string convertedValue = UnitConverter.Convert("42 celsius", "fahrenheit");
            Assert.AreEqual("107.6 fahrenheit", convertedValue);
        }

        [TestMethod]
        public void TestFahrenheitToCelsius()
        {
            string convertedValue = UnitConverter.Convert("42 fahrenheit", "celsius");
            Assert.AreEqual("5.55555555555556 celsius", convertedValue);
        }

        [TestMethod]
        public void TestCelsiusToCelsius()
        {
            string convertedValue = UnitConverter.Convert("42 celsius", "celsius");
            Assert.AreEqual("42 celsius", convertedValue);
        }

        [TestMethod]
        public void TestZeptocelsiusToCelsius()
        {
            string convertedValue = UnitConverter.Convert("42 zeptocelsius", "celsius");
            Assert.AreEqual("0.000000000000000000042 celsius", convertedValue);
        }

        [TestMethod]
        public void TestYottafahrenheitToMeter()
        {
            string convertedValue = UnitConverter.Convert("42 yottafahrenheit", "fahrenheit");
            Assert.AreEqual("42000000000000000000000000 fahrenheit", convertedValue);
        }

        [TestMethod]
        public void TestZeroFahrenheitToCelsius()
        {
            string convertedValue = UnitConverter.Convert("0 fahrenheit", "celsius");
            Assert.AreEqual("-17.7777777777778 celsius", convertedValue);
        }

        [TestMethod]
        public void TestNegativeValue()
        {
            string convertedValue = UnitConverter.Convert("-273.15 celsius", "fahrenheit");
            Assert.AreEqual("-459.67 fahrenheit", convertedValue);
        }

        [TestMethod]
        public void TestKilocelsiusToMicrofahrenheit()
        {
            string convertedValue = UnitConverter.Convert("4.2 kilocelsius", "microfahrenheit");
            Assert.AreEqual("7592000000 microfahrenheit", convertedValue);
        }
    }
}
