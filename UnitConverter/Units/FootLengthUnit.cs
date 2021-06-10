using System;
using System.Collections.Generic;
using System.Text;

namespace Kastanek.UnitConverter.Units
{
    /// <summary>
    /// Length unit representing foot.
    /// </summary>
    internal class FootLengthUnit : LengthUnit
    {
        public const string Name = "foot";

        private const double footInMeters = 0.3048;

        public FootLengthUnit(SIPrefix prefix) : base(Name, prefix)
        {
        }

        public override double ConvertFromSIUnit(double value)
        {
            return base.ConvertFromBaseUnit(value / footInMeters);
        }

        public override double ConvertToSIUnit(double value)
        {
            return base.ConvertToBaseUnit(value) * footInMeters;
        }
    }
}
