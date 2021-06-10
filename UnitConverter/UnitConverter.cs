using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Kastanek.UnitConverter.Units;

namespace Kastanek.UnitConverter
{
    public static class UnitConverter
    {
        /// <summary>
        /// Converts the input value to another unit.
        /// </summary>
        /// <param name="inputValueUnit">The input value and unit (in singular form) to be converted separated by a space, for example "42 centimeter".</param>
        /// <param name="outputUnit">The name of the converted unit (in singular form).</param>
        /// <returns>The converted value with the corresponding unit separated by a space.</returns>
        public static string Convert(string inputValueUnit, string outputUnit)
        {
            if (string.IsNullOrEmpty(inputValueUnit) || string.IsNullOrEmpty(outputUnit))
            {
                throw new InvalidOperationException("Input and output units needs to be filled in.");
            }

            int indexOfSeparator = inputValueUnit.IndexOf(' ');

            if (indexOfSeparator < 1)
            {
                throw new InvalidOperationException("Invalid input value and unit.");
            }

            string inputValueString = inputValueUnit.Substring(0, indexOfSeparator);
            double inputValue;
            if (!double.TryParse(inputValueString, NumberStyles.Any, CultureInfo.InvariantCulture, out inputValue) ||
                !double.IsFinite(inputValue))
            {
                throw new InvalidOperationException("Invalid input value.");
            }

            string inputUnitName = inputValueUnit.Substring(indexOfSeparator).Trim();
            double convertedValue = Convert(inputValue, inputUnitName, outputUnit);

            return string.Format(
                CultureInfo.InvariantCulture,
                "{0:0.########################################################################################} {1}",
                convertedValue,
                outputUnit);
        }

        /// <summary>
        /// Converts the input value to another unit.
        /// </summary>
        /// <param name="inputValue">The input value to be converted.</param>
        /// <param name="inputUnitName">The input unit name to be converted (in singular form).</param>
        /// <param name="outputUnitName">The name of the converted unit (in singular form).</param>
        /// <returns>The converted numerical value.</returns>
        public static double Convert(double inputValue, string inputUnitName, string outputUnitName)
        {
            if (string.IsNullOrEmpty(inputUnitName) || string.IsNullOrEmpty(outputUnitName))
            {
                throw new InvalidOperationException("Input and output units needs to be filled in.");
            }

            IUnit inputUnit = UnitFactory.Instance.CreateUnit(inputUnitName);
            if (inputUnit == null)
            {
                throw new InvalidOperationException("Invalid input unit.");
            }

            IUnit outputUnit = UnitFactory.Instance.CreateUnit(outputUnitName);
            if (outputUnit == null)
            {
                throw new InvalidOperationException("Invalid output unit.");
            }

            if (inputUnit.TypeOfUnit != outputUnit.TypeOfUnit)
            {
                throw new InvalidOperationException("Cannot convert incompatible units.");
            }

            if (inputUnitName == outputUnitName)
            {
                return inputValue;
            }

            double valueInSIUnits = inputUnit.ConvertToSIUnit(inputValue);
            double valueInOutputUnits = outputUnit.ConvertFromSIUnit(valueInSIUnits);

            return valueInOutputUnits;
        }
    }
}
