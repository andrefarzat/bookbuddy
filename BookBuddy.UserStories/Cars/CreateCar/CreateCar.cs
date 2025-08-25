namespace BookBuddy.UserStories.Cars.CreateCar
{
    // User Story Handler
    public class CreateCarUserStory
    {
        public async Task<CreateCarOutput> Execute(CreateCarInput input)
        {
            // Here you would have logic to create a Car, persist it, etc.
            // For now, just return a dummy output for demonstration.
            await Task.Yield(); // Simulate async work
            return new CreateCarOutput
            {
                Id = Guid.NewGuid(),
                Make = input.Make,
                Model = input.Model,
                Year = input.Year,
                LicensePlate = input.LicensePlate,
                Status = "Available"
            };
        }
    }
}
