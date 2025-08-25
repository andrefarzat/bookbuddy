using System.Threading.Tasks;

namespace BookBuddy.UserStories.Cars.GetCar
{
    public class GetCarUserStory
    {
        public async Task<GetCarOutput> Execute(GetCarInput input)
        {
            // Here you would have logic to retrieve a Car by its Id
            // For now, just return a dummy output for demonstration.
            await Task.Yield(); // Simulate async work
            return new GetCarOutput
            {
                Id = input.CarId,
                Make = "DemoMake",
                Model = "DemoModel",
                Year = 2020,
                LicensePlate = "DEMO123",
                Status = "Available"
            };
        }
    }
}
