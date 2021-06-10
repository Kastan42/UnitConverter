using System;
using System.Collections.Generic;
using System.Text;

namespace Kastanek.UnitConverter.Units
{
    /// <summary>
    /// Length unit representing inch.
    /// </summary>
    internal class InchLengthUnit : LengthUnit
    {
        public const string Name = "inch";

        private const double inchInMeters = 0.0254;

        public InchLengthUnit(SIPrefix prefix) : base(Name, prefix)
        {
        }

        public override double ConvertFromSIUnit(double value)
        {
            return base.ConvertFromBaseUnit(value / inchInMeters);
        }

        public override double ConvertToSIUnit(double value)
        {
            return base.ConvertToBaseUnit(value) * inchInMeters;
        }
    }
}
