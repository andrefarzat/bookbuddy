using System.Threading.Tasks;

namespace BookBuddy.UserStories.Customers.UpdateCustomer
{
    public class UpdateCustomerUserStory
    {
        public async Task<UpdateCustomerOutput> Execute(UpdateCustomerInput input)
        {
            await Task.Yield();
            return new UpdateCustomerOutput
            {
                Id = input.Id,
                Name = input.Name,
                Email = input.Email,
                PhoneNumber = input.PhoneNumber,
                DriverLicense = input.DriverLicense,
                Address = input.Address
            };
        }
    }
}
