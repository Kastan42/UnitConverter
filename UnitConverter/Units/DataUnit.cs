using System;
using System.Collections.Generic;
using System.Text;

namespace Kastanek.UnitConverter.Units
{
    /// <summary>
    /// Unit representing data.
    /// </summary>
    internal abstract class DataUnit : Unit
    {
        public override string TypeOfUnit { get { return "Data"; } }

        protected DataUnit(string baseName, SIPrefix prefix) : base(baseName, prefix)
        {
            if (prefix != null && prefix.PowerDecimal < 0)
            {
                throw new InvalidOperationException("Cannot have a partial data unit.");
            }
        }
    }
}
