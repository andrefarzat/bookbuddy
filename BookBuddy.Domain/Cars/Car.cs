using System;
using System.Collections.Generic;

namespace BookBuddy.Domain.Cars;
public class Car : AggregateRoot
{
public string Make { get; protected set; }
public string Model { get; protected set; }
public int Year { get; protected set; }
public string LicensePlate { get; protected set; }
public ICollection<Pneu> Pneus { get; protected set; } = new List<Pneu>();

public CarStatus Status { get; protected set; }

    public Car(Guid id, string make, string model, int year, string licensePlate, CarStatus status)
    {
        Id = id;
        Make = make;
        Model = model;
        Year = year;
        LicensePlate = licensePlate;
        Status = status;
    }

    // Parameterless constructor for EF Core
    protected Car() { }

    public void SetStatus(CarStatus status)
    {
        Status = status;
    }
}

public enum CarStatus
{
    Available,
    Rented,
    Maintenance,
    Unavailable
}
