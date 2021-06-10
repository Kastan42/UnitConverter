using System;
using System.Collections.Generic;
using System.Text;

namespace Kastanek.UnitConverter.Units
{
    /// <summary>
    /// Temperature unit representing Fahrenheit.
    /// </summary>
    internal class FahrenheitTemperatureUnit : TemperatureUnit
    {
        public const string Name = "fahrenheit";

        public FahrenheitTemperatureUnit(SIPrefix prefix) : base(Name, prefix)
        {
        }

        public override double ConvertFromSIUnit(double value)
        {
            return this.ConvertFromBaseUnit(value * 1.8 + 32);
        }

        public override double ConvertToSIUnit(double value)
        {
            return (this.ConvertToBaseUnit(value) - 32) / 1.8;
        }
    }
}
