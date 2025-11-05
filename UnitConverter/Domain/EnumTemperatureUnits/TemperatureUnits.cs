using System.ComponentModel.DataAnnotations;

namespace Unit_Converter.Components.Pages.Temperature.Enum;

public enum TemperatureUnits
{

[Display(Name = "Celsius (°C)")] Celsius,
[Display(Name = "Fahrenheit (°F)")] Fahrenheit,
[Display(Name = "Kelvin (K)")] Kelvin
}
