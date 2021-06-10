# UnitConverter
A simple unit converter library.

# Usage
Call _UnitConverter.Convert_ method to convert your units from one to another. The library supports units with [common SI prefixes](https://en.wikipedia.org/wiki/Metric_prefix#List_of_SI_prefixes).

One of the overload of this method allows you to enter string input of the value and unit (in singular form) to be converted separated by a space, for example "42 kilometer". The second parameter is then the output unit, for example "centimeter". The output is then in the similar format as the input, in this case "4200000 centimeter".

The current support of units is limited to length units (meter, inch, foot), temperature (Celsius, Fahrenheit) and data (bit, byte), however other units can be easily added!