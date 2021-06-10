using System;
using System.Collections.Generic;
using System.Text;

namespace Kastanek.UnitConverter.Units
{
    /// <summary>
    /// Unit representing temperature.
    /// </summary>
    abstract internal class TemperatureUnit : Unit
    {
        public override string TypeOfUnit { get { return "Temperature"; } }

        protected TemperatureUnit(string baseName, SIPrefix prefix) : base(baseName, prefix)
        {
        }
    }
}
