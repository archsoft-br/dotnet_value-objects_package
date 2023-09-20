namespace ArchSoft.ValueObjects;

public class Dimension
{
    public Dimension(
        decimal width,
        decimal height,
        decimal depth
    )
    {
        Width = width;
        Height = height;
        Depth = depth;
    }

    public decimal Width { get; private set; }
    public decimal Height { get; private set; }
    public decimal Depth { get; private set; }
}