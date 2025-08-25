using System;

namespace BookBuddy.Domain.Customers
{
    public class Customer : AggregateRoot
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string DriverLicense { get; private set; }
    public Address Address { get; private set; }

    public Customer(Guid id, string name, string email, string phoneNumber, string driverLicense, Address address)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            DriverLicense = driverLicense;
            Address = address;
        }
    }
}
