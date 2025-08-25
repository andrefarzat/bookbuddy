namespace BookBuddy.UserStories.Cars.CreateCar
{
    public class CreateCarOutput
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public string Status { get; set; }
    }
}
