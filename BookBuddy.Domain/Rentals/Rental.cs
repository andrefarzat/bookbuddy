using System;

namespace BookBuddy.Domain.Rentals
{
    public class Rental : AggregateRoot
    {
        public Guid CarId { get; private set; }
        public Guid CustomerId { get; private set; }
        public DateTime RentalDate { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public RentalStatus Status { get; private set; }

        public Rental(Guid id, Guid carId, Guid customerId, DateTime rentalDate, DateTime dueDate)
        {
            Id = id;
            CarId = carId;
            CustomerId = customerId;
            RentalDate = rentalDate;
            DueDate = dueDate;
            Status = RentalStatus.Active;
        }

        public void ReturnCar(DateTime returnDate)
        {
            ReturnDate = returnDate;
            Status = RentalStatus.Completed;
        }
    }

    public enum RentalStatus
    {
        Active,
        Completed,
        Overdue,
        Cancelled
    }
}
