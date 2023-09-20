namespace ArchSoft.ValueObjects;

/// <summary>
///     Geographic Coordinate
/// </summary>
public class Coordinate
{
    public Coordinate(
        decimal latitude,
        decimal longitude
    )
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public decimal Latitude { get; private set; }
    public decimal Longitude { get; private set; }
}