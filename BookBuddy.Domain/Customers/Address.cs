namespace BookBuddy.Domain.Customers
{
    public class Address
    {
        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public string Country { get; }

        public Address(string street, string city, string state, string zipCode, string country)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
        }

        public override bool Equals(object obj) =>
            obj is Address other &&
            Street == other.Street &&
            City == other.City &&
            State == other.State &&
            ZipCode == other.ZipCode &&
            Country == other.Country;

        public override int GetHashCode() =>
            HashCode.Combine(Street, City, State, ZipCode, Country);
    }
}
