namespace Kastanek.UnitConverter.Units
{
    internal interface IUnit
    {
        /// <summary>
        /// The name of the unit type to distinguish different families of units - for example for temperature or length.
        /// </summary>
        string TypeOfUnit { get; }

        /// <summary>
        /// The base name of the unit - for example for "centimeter" it is "meter".
        /// </summary>
        string BaseName { get; }

        /// <summary>
        /// The full name of the unit - for example "centimeter".
        /// </summary>
        string FullName { get; }

        /// <summary>
        /// The prefix part of the unit - for example for "centimeter" it represents "centi".
        /// </summary>
        SIPrefix Prefix { get; }

        /// <summary>
        /// Converts a given value in base unit (for example inch) to the current unit. 
        /// </summary>
        /// <param name="value">The value in base unit to be converted.</param>
        /// <returns>The value converted to the current unit.</returns>
        double ConvertFromBaseUnit(double value);

        /// <summary>
        /// Converts a given value in SI unit (for example meter) to the current unit. 
        /// </summary>
        /// <param name="value">The value in SI unit to be converted.</param>
        /// <returns>The value converted to the current unit.</returns>
        double ConvertFromSIUnit(double value);

        /// <summary>
        /// Converts the current value to the base unit (for example inch). 
        /// </summary>
        /// <param name="value">The value in the current unit to be converted.</param>
        /// <returns>The value converted to the base unit.</returns>
        double ConvertToBaseUnit(double value);

        /// <summary>
        /// Converts the current value to SI unit (for example meter). 
        /// </summary>
        /// <param name="value">The value in the current unit to be converted.</param>
        /// <returns>The value converted to the SI unit.</returns>
        double ConvertToSIUnit(double value);
    }
}