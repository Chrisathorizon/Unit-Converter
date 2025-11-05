using System;
using Microsoft.AspNetCore.Components;

namespace Unit_Converter.Components.Pages.Temperature;

public partial class Temperature
{
    [Parameter]
    public decimal InputTemperature { get; set; }
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

    private void ConvertTemperature()
    {
        
    }
}