using System;
using System.Collections.Generic;
using System.Text;

namespace Kastanek.UnitConverter.Units
{
    /// <summary>
    /// Data unit representing byte.
    /// </summary>
    internal class ByteDataUnit : DataUnit
    {
        public const string Name = "byte";

        public ByteDataUnit(SIPrefix prefix) : base(Name, prefix)
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
