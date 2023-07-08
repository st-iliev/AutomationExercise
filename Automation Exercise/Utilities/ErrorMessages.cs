using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Utilities
{
    public static class ErrorMessages
    {
        public const string incorrectData = "Your email or password is incorrect!";
        public const string emptyField = "Please fill out this field.";
        public const string incorrectEmailAddress = "Please include an '@' in the email address. '{0}' is missing an '@'.";
        public const string emailAddressAlreadyExist = "Email Address already exist!";

    }
}
