namespace BookBuddy.UserStories.Customers.CreateCustomer
{
    public class CreateCustomerOutput
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DriverLicense { get; set; }
        public string Address { get; set; }
    }
}
