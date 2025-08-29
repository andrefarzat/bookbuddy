using System;
using System;

namespace BookBuddy.Domain.Cars;

public class Pneu : Entity
{
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public int Size { get; private set; }
    public DateTime ManufactureDate { get; private set; }

    public Pneu(string brand, string model, int size, DateTime manufactureDate)
    {
        Brand = brand;
        Model = model;
        Size = size;
        ManufactureDate = manufactureDate;
    }
}