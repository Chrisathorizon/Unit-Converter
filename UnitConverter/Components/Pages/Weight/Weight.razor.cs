using System;
using Microsoft.AspNetCore.Components;

namespace Unit_Converter.Components.Pages.Weight;

public partial class Weight
{
    [Parameter]
    public decimal InputWeight { get; set; }
    public string  InputOldUnit { get; set; }
    public string  InputNewUnit { get; set; }

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

    private void ConvertWeight()
    {
        
    }
}