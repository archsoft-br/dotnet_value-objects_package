namespace ArchSoft.ValueObjects;

public class Measurement
{
    public Measurement(decimal quantity, string unit)
    {
        Quantity = quantity;
        Unit = unit;
    }

    public decimal Quantity { get; private set; }
    public string Unit { get; private set; }

    public override string ToString()
    {
        return $"{Quantity} {Unit}";
    }
}