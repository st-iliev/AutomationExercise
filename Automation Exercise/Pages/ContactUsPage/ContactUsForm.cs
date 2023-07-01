using Automation_Exercise.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages.ContactUsPage
{
    public class ContactUsForm
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public ContactUsForm()
        {
            Name = Constants.name; 
            Email = Constants.email;
            Subject = "Field validations.";
            Message = "Dear [Site Support Team/Technical Support Team],\r\n\r\nI hope this email finds you well. I am writing to request the addition of validation on an important field within the [name of the site/application/service]. This enhancement will help ensure data accuracy, integrity, and provide a better user experience for all users.";
        }
    }
}
