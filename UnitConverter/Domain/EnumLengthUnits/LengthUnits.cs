using System.ComponentModel.DataAnnotations;

namespace Unit_Converter.Components.Pages.Length;

public enum LengthUnits
{
    [Display(Name = "Millimeter (mm)")] Millimeter,
    [Display(Name = "Centimeter (cm)")] Centimeter,
    [Display(Name = "Meter (m)")] Meter,
    [Display(Name = "Kilometer (km)")] Kilometer,
    [Display(Name = "Inch (in)")] Inch,
    [Display(Name = "Foot (ft)")] Foot,
    [Display(Name = "Yard (yr)")] Yard,
    [Display(Name = "Mile (mile)")] Mile
}