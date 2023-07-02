using Automation_Exercise.Utilities;

namespace Automation_Exercise.Pages.ContactUsPage
{
    public class ContactUsForm
    {
        

        public ContactUsForm()
        {
            Name = Constants.name; 
            Email = Constants.email;
            Subject = Constants.contactUsSubject;
            Message = Constants.contactUsMessage;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
