using System.Threading.Tasks;

namespace BookBuddy.UserStories.Customers.GetCustomer
{
    public class GetCustomerUserStory
    {
        public async Task<GetCustomerOutput> Execute(GetCustomerInput input)
        {
            await Task.Yield();
            return new GetCustomerOutput
            {
                Id = input.CustomerId,
                Name = "Demo Name",
                Email = "demo@email.com",
                PhoneNumber = "1234567890",
                DriverLicense = "DL123456",
                Address = "Demo Address"
            };
        }
    }
}
