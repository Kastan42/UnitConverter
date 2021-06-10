using System;
using System.Collections.Generic;
using System.Text;

namespace Kastanek.UnitConverter.Units
{
    /// <summary>
    /// Unit representing length.
    /// </summary>
    abstract internal class LengthUnit : Unit
    {
        public override string TypeOfUnit { get { return "Length"; } }

        protected LengthUnit(string baseName, SIPrefix prefix) : base(baseName, prefix)
        {
        }
    }
}
