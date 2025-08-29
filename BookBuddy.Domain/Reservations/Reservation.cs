using System;

namespace BookBuddy.Domain.Reservations;

public class Reservation : AggregateRoot
{
    public Guid CarId { get; private set; }
    public Guid CustomerId { get; private set; }
    public DateTime RentalDate { get; private set; }
    public DateTime ReturnDate { get; private set; }
    public Guid PickupBranchId { get; private set; }
    public Guid ReturnBranchId { get; private set; }

    public Reservation(Guid id, Guid carId, Guid customerId, DateTime rentalDate, DateTime returnDate, Guid pickupBranchId, Guid returnBranchId)
    {
        Id = id;
        CarId = carId;
        CustomerId = customerId;
        RentalDate = rentalDate;
        ReturnDate = returnDate;
        PickupBranchId = pickupBranchId;
        ReturnBranchId = returnBranchId;
    }

    // Parameterless constructor for EF Core
    protected Reservation() { }
}
