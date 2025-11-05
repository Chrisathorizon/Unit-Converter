using Unit_Converter.Abstractions;
using Unit_Converter.Components.Pages.Length;

namespace UnitConverter.Application.Converters;

public class LengthConverter : IUnitConverter<LengthUnits>
{
    private static readonly Dictionary<LengthUnits, decimal> ToMeter = new Dictionary<LengthUnits, decimal>
    {
        { LengthUnits.Millimeter, 0.001m },
        { LengthUnits.Centimeter, 0.01m  },
        { LengthUnits.Meter,      1.0m  },
        { LengthUnits.Kilometer,  1000m  },
        { LengthUnits.Inch,  39.3701m  },
        { LengthUnits.Foot,  3.28084m  },
        { LengthUnits.Yard,  1.09361m  },
        { LengthUnits.Mile,  0.000621371m  }
    };
    
    
    public decimal Convert(decimal value, LengthUnits from, LengthUnits to)
    {
        throw new NotImplementedException();
    }
}