using System.ComponentModel.DataAnnotations;
using Unit_Converter.Components.Pages.Length;

namespace UnitConverter.Domain;

public sealed class UnitSelectModel
{
    [Required] //zwingt eine Auswahl != null 
    public LengthUnits? Unit {get; set;}
    
}