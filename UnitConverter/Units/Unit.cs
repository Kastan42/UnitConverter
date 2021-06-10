using System;

namespace Kastanek.UnitConverter.Units
{
    internal abstract class Unit : IUnit
    {
        public abstract string TypeOfUnit { get; }

        public string BaseName { get; private set; }

        public string FullName
        {
            get
            {
                return (Prefix == null ? string.Empty : Prefix.Name) + BaseName;
            }
        }

        public SIPrefix Prefix { get; protected set; }

        protected Unit(string baseName, SIPrefix prefix)
        {
            this.BaseName = baseName;
            this.Prefix = prefix;
        }

        public virtual double ConvertToBaseUnit(double value)
        {
            return this.Prefix == null ? value : (value * this.Prefix.BaseMultiplier);
        }

        public virtual double ConvertFromBaseUnit(double value)
        {
            return this.Prefix == null ? value : (value / this.Prefix.BaseMultiplier);
        }

        public abstract double ConvertToSIUnit(double value);

        public abstract double ConvertFromSIUnit(double value);
    }
}
