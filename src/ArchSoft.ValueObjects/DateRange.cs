namespace ArchSoft.ValueObjects;

public class DateRange
{
    public DateRange(
        DateTime start,
        DateTime end
    )
    {
        Start = start;
        End = end;
    }

    public DateTime Start { get; private set; }
    public DateTime End { get; private set; }
}