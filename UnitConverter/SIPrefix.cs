using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kastanek.UnitConverter
{
    /// <summary>
    /// The prefix part of the unit - for example for "centimeter" it represents "centi".
    /// </summary>
    internal class SIPrefix
    {
        /// <summary>
        /// The name of the prefix.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// How high power of 10 do we need to multiply the base unit for this prefix.
        /// </summary>
        public int PowerDecimal { get; private set; }

        /// <summary>
        /// The number to multiply the base unit for this prefix.
        /// </summary>
        public double BaseMultiplier
        {
            get { return Math.Pow(10, this.PowerDecimal); }
        }

        /// <summary>
        /// The static complete list of SI prefixes
        /// </summary>
        private static List<SIPrefix> siPrefixes;

        private SIPrefix()
        {
        }

        static SIPrefix()
        {
            InitializeSIPrefixes();
        }

        /// <summary>
        /// Initializes the list of SI prefixes.
        /// </summary>
        private static void InitializeSIPrefixes()
        {
            siPrefixes = new List<SIPrefix>();

            siPrefixes.Add(new SIPrefix { Name = "deci", PowerDecimal = -1 });
            siPrefixes.Add(new SIPrefix { Name = "centi", PowerDecimal = -2 });
            siPrefixes.Add(new SIPrefix { Name = "milli", PowerDecimal = -3 });
            siPrefixes.Add(new SIPrefix { Name = "micro", PowerDecimal = -6 });
            siPrefixes.Add(new SIPrefix { Name = "nano", PowerDecimal = -9 });
            siPrefixes.Add(new SIPrefix { Name = "pico", PowerDecimal = -12 });
            siPrefixes.Add(new SIPrefix { Name = "femto", PowerDecimal = -15 });
            siPrefixes.Add(new SIPrefix { Name = "atto", PowerDecimal = -18 });
            siPrefixes.Add(new SIPrefix { Name = "zepto", PowerDecimal = -21 });
            siPrefixes.Add(new SIPrefix { Name = "yocto", PowerDecimal = -24 });

            siPrefixes.Add(new SIPrefix { Name = "deca", PowerDecimal = 1 });
            siPrefixes.Add(new SIPrefix { Name = "hecto", PowerDecimal = 2 });
            siPrefixes.Add(new SIPrefix { Name = "kilo", PowerDecimal = 3 });
            siPrefixes.Add(new SIPrefix { Name = "mega", PowerDecimal = 6 });
            siPrefixes.Add(new SIPrefix { Name = "giga", PowerDecimal = 9 });
            siPrefixes.Add(new SIPrefix { Name = "tera", PowerDecimal = 12 });
            siPrefixes.Add(new SIPrefix { Name = "peta", PowerDecimal = 15 });
            siPrefixes.Add(new SIPrefix { Name = "exa", PowerDecimal = 18 });
            siPrefixes.Add(new SIPrefix { Name = "zetta", PowerDecimal = 21 });
            siPrefixes.Add(new SIPrefix { Name = "yotta", PowerDecimal = 24 });
        }

        /// <summary>
        /// Extracts the prefix from the unit name.
        /// </summary>
        /// <param name="unitName">The full name of the unit, for example "centimeter".</param>
        /// <returns>The extracted prefix instance.</returns>
        public static SIPrefix ExtractPrefix(string unitName)
        {
            if (string.IsNullOrEmpty(unitName))
            {
                return null;
            }

            return siPrefixes.FirstOrDefault(x => unitName.StartsWith(x.Name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
