using System;

namespace BookBuddy.Domain.Branches;

public class Branch : AggregateRoot
{
    public Guid AddressId { get; private set; }
    public string Name { get; private set; }
    public TimeSpan OpenHours { get; private set; }
    public TimeSpan ClosedHours { get; private set; }

    public Branch(Guid id, Guid addressId, string name, TimeSpan openHours, TimeSpan closedHours)
    {
        Id = id;
        AddressId = addressId;
        Name = name;
        OpenHours = openHours;
        ClosedHours = closedHours;
    }

    // Parameterless constructor for EF Core
    protected Branch() { }
}
