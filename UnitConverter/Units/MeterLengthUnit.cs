using System;
using System.Collections.Generic;
using System.Text;

namespace Kastanek.UnitConverter.Units
{
    /// <summary>
    /// Length unit representing meter.
    /// </summary>
    internal class MeterLengthUnit : LengthUnit
    {
        public const string Name = "meter";

        public MeterLengthUnit(SIPrefix prefix) : base(Name, prefix)
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
