using System;
using System.Collections.Generic;
using System.Text;

namespace Kastanek.UnitConverter.Units
{
    /// <summary>
    /// Temperature unit representing Celsius.
    /// </summary>
    internal class CelsiusTemperatureUnit : TemperatureUnit
    {
        public const string Name = "celsius";

        public CelsiusTemperatureUnit(SIPrefix prefix) : base(Name, prefix)
        {
        }

        public override double ConvertFromSIUnit(double value)
        {
            return this.ConvertFromBaseUnit(value);
        }

        public override double ConvertToSIUnit(double value)
        {
            return this.ConvertToBaseUnit(value);
        }
    }
}
