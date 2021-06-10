using System;
using System.Collections.Generic;
using System.Text;

namespace Kastanek.UnitConverter.Units
{
    /// <summary>
    /// Data unit representing bits.
    /// </summary>
    internal class BitDataUnit : DataUnit
    {
        public const string Name = "bit";

        private const int bitsInByte = 8;

        public BitDataUnit(SIPrefix prefix) : base(Name, prefix)
        {
        }

        public override double ConvertFromSIUnit(double value)
        {
            return this.ConvertFromBaseUnit(value * bitsInByte);
        }

        public override double ConvertToSIUnit(double value)
        {
            return this.ConvertToBaseUnit(value) / bitsInByte;
        }
    }
}
