using Automation_Exercise.Utilities;

namespace Automation_Exercise.Pages.SignupPage
{
    public class AccountInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Countries Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string MobileNumber { get; set; }
        public AccountInfo()
        {
            Name = Constants.name;
            Email = Constants.email;
            Password = Constants.password;
            FirstName = Constants.firstName;
            LastName = Constants.lastName;
            Address = Constants.firstAddress;
            Country = Countries.Australia;
            State = Constants.state;
            City = Constants.city;
            ZipCode = Constants.zipCode;
            MobileNumber = Constants.mobileNumber;
        }
       
    }
}
