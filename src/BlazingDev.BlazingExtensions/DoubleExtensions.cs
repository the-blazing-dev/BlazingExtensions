using System.Globalization;

namespace BlazingDev.BlazingExtensions;

public static class DoubleExtensions
{
    public static string ToInvariantString(this double value)
    {
        return value.ToString(CultureInfo.InvariantCulture);
    }
}