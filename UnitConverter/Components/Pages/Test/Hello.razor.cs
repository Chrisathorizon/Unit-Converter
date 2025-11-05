using System;
using Microsoft.AspNetCore.Components;

namespace Unit_Converter.Components.Pages.Test; // <<-- anpassen an dein Projekt

// Wichtig: partial, kein Base-Type angeben (den erbt der .razor-Teil schon)
public partial class Hello
{
    [Parameter]
    public string Name { get; set; } = "World";

    private string InputName { get; set; } = string.Empty;
    private string Greeting  { get; set; } = string.Empty;

    private void OnGreet()
    {
        if (!string.IsNullOrWhiteSpace(this.InputName))
        {
            this.Name = this.InputName.Trim();
        }

        this.Greeting = $"Nice to meet you, {this.Name} 👋";
    }

    protected override void OnParametersSet()
    {
        if (string.IsNullOrWhiteSpace(this.Name))
        {
            this.Name = "World";
        }
    }
}