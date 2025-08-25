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

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Street?.GetHashCode() ?? 0);
                hash = hash * 23 + (City?.GetHashCode() ?? 0);
                hash = hash * 23 + (State?.GetHashCode() ?? 0);
                hash = hash * 23 + (ZipCode?.GetHashCode() ?? 0);
                hash = hash * 23 + (Country?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }
}
