using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.AspNetCore.Components;
using UnitConverter.Domain;

namespace Unit_Converter.Components.Pages.Length;

public partial class Length : ComponentBase
{
    [Parameter]
    public decimal InputLength { get; set; }

    private UnitSelectModel Model { get; set; } = new UnitSelectModel();
    private LengthUnits[] AllLengthUnits { get; } = Enum.GetValues<LengthUnits>();

    private void HandleSubmit()
    {
        LengthUnits selected = this.Model.Unit!.Value;
        Console.WriteLine($"Selected: {selected}");
        //hier Konvertierung
    }

    private static string GetDisplayName(LengthUnits unit)
    {
        Type t = typeof(LengthUnits);
        MemberInfo[] members = t.GetMember(unit.ToString())
        if (members.Length > 0)
        {
            object[] attrs = members[0].GetCustomAttributes(typeof(DisplayAttribute), false);
            if (attrs.Length > 0)
            {
                DisplayAttribute attr = (DisplayAttribute)attrs[0];
                string? name = attr.GetName();
                if (!string.IsNullOrEmpty(name)) return name!;
            }
        }
        return unit.ToString();
    }

    private void ChangeToLength()
    {
        this.Nav.NavigateTo("/length");
    }

    private void ChangeToWeight()
    {
        this.Nav.NavigateTo("/weight");
    }

    private void ChangeToTemperature()
    {
        this.Nav.NavigateTo("/temperature");
    }

    private void ConvertLength()
    {
        
    }
}