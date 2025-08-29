using System;

namespace BookBuddy.Domain.Rentals;

public class Rental : AggregateRoot
{
    public Guid CarId { get; protected set; }
    public Guid CustomerId { get; protected set; }
    public DateTime RentalDate { get; protected set; }
    public DateTime DueDate { get; protected set; }
    public DateTime? ReturnDate { get; protected set; }
    public RentalStatus Status { get; protected set; }

    public Rental(Guid id, Guid carId, Guid customerId, DateTime rentalDate, DateTime dueDate)
    {
        Id = id;
        CarId = carId;
        CustomerId = customerId;
        RentalDate = rentalDate;
        DueDate = dueDate;
        Status = RentalStatus.Active;
    }

    // Parameterless constructor for EF Core
    protected Rental() { }

    public void ReturnCar(DateTime returnDate)
    {
        ReturnDate = returnDate;
        Status = RentalStatus.Completed;
    }

    public enum RentalStatus
    {
        Active,
        Completed,
        Overdue,
        Cancelled
    }
}
