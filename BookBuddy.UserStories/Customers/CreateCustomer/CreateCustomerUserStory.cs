using System.Threading.Tasks;

namespace BookBuddy.UserStories.Customers.CreateCustomer
{
    public class CreateCustomerUserStory
    {
        public async Task<CreateCustomerOutput> Execute(CreateCustomerInput input)
        {
            await Task.Yield();
            return new CreateCustomerOutput
            {
                Id = Guid.NewGuid(),
                Name = input.Name,
                Email = input.Email,
                PhoneNumber = input.PhoneNumber,
                DriverLicense = input.DriverLicense,
                Address = input.Address
            };
        }
    }
}
