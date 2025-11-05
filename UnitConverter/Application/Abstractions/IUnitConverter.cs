namespace Unit_Converter.Abstractions;

public interface IUnitConverter<TUnit> where TUnit : struct, Enum
{
    decimal Convert(decimal value, TUnit from, TUnit to);
}