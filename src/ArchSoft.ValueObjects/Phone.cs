namespace ArchSoft.ValueObjects;

public class Phone
{
    public Phone(int areaCode, int number, int countryCode = 55)
    {
        CountryCode = countryCode;
        AreaCode = areaCode;
        Number = number;
    }

    public int CountryCode { get; private set; }
    public int AreaCode { get; private set; }
    public int Number { get; private set; }

    public override string ToString()
    {
        return $"({AreaCode}) {Number}";
    }
}