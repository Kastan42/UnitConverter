using System;
using System.Collections.Generic;
using System.Text;
using Kastanek.UnitConverter.Units;

namespace Kastanek.UnitConverter
{
    /// <summary>
    /// A factory for creating specific IUnit implementations.
    /// </summary>
    internal class UnitFactory
    {
        private static UnitFactory instance;

        public static UnitFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UnitFactory();
                }

                return instance;
            }
        }

        private UnitFactory()
        {
        }

        /// <summary>
        /// Creates a specific IUnit implementation based on the given unit name.
        /// </summary>
        /// <param name="fullName">Unit's full name.</param>
        /// <returns>The specific IUnit implementation</returns>
        public IUnit CreateUnit(string fullName)
        {
            fullName = fullName.Trim();
            SIPrefix siPrefix = SIPrefix.ExtractPrefix(fullName);
            string baseName = siPrefix == null ?
                fullName : fullName.Substring(siPrefix.Name.Length);

            if (baseName.Equals(MeterLengthUnit.Name, StringComparison.OrdinalIgnoreCase))
            {
                return new MeterLengthUnit(siPrefix);
            }
            else if (baseName.Equals(InchLengthUnit.Name, StringComparison.OrdinalIgnoreCase))
            {
                return new InchLengthUnit(siPrefix);
            }
            else if (baseName.Equals(FootLengthUnit.Name, StringComparison.OrdinalIgnoreCase))
            {
                return new FootLengthUnit(siPrefix);
            }
            else if (baseName.Equals(CelsiusTemperatureUnit.Name, StringComparison.OrdinalIgnoreCase))
            {
                return new CelsiusTemperatureUnit(siPrefix);
            }
            else if (baseName.Equals(FahrenheitTemperatureUnit.Name, StringComparison.OrdinalIgnoreCase))
            {
                return new FahrenheitTemperatureUnit(siPrefix);
            }
            else if (baseName.Equals(BitDataUnit.Name, StringComparison.OrdinalIgnoreCase))
            {
                return new BitDataUnit(siPrefix);
            }
            else if (baseName.Equals(ByteDataUnit.Name, StringComparison.OrdinalIgnoreCase))
            {
                return new ByteDataUnit(siPrefix);
            }
            else
            {
                return null;
            }
        }
    }
}
