namespace ArchSoft.ValueObjects;

public class Address
{
    public Address(
        string street,
        string number,
        string neighborhood,
        string city,
        string state,
        string postalCode,
        string complement = "",
        string country = "BR"
    )
    {
        Street = street;
        Number = number;
        Complement = complement;
        Neighborhood = neighborhood;
        City = city;
        State = state;
        PostalCode = postalCode;
        Country = country;
    }

    public string Street { get; private set; }
    public string Number { get; private set; }
    public string Complement { get; private set; }
    public string Neighborhood { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string PostalCode { get; private set; }
    public string Country { get; private set; }
}