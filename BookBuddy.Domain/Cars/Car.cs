using System;

namespace BookBuddy.Domain.Cars
{
    public class Car : AggregateRoot
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string LicensePlate { get; private set; }
        public CarStatus Status { get; private set; }

        public Car(Guid id, string make, string model, int year, string licensePlate, CarStatus status)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            LicensePlate = licensePlate;
            Status = status;
        }

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
}
