namespace BookBuddy.UserStories.Customers.GetCustomer
{
    public class GetCustomerOutput
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DriverLicense { get; set; }
        public string Address { get; set; }
    }
}
