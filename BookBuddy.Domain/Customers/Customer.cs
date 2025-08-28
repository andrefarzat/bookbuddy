using System;

namespace BookBuddy.Domain.Customers
{
    public class Customer : AggregateRoot
    {
    public string Name { get; protected set; }
    public string Email { get; protected set; }
    public string PhoneNumber { get; protected set; }
    public string DriverLicense { get; protected set; }
    public Address Address { get; protected set; }

        public Customer(Guid id, string name, string email, string phoneNumber, string driverLicense, Address address)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            DriverLicense = driverLicense;
            Address = address;
        }

        // Parameterless constructor for EF Core
        protected Customer() { }
    }
}
