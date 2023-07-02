﻿using Automation_Exercise.Pages;

namespace Automation_Exercise.Utilities
{
    public static class Constants
    {
        public const string downloadedFilePath = @"C:\Downloads\invoice.txt";
        public const string expectedFileText = "Hi {0} {1}, Your total purchase amount is {2}. Thank you"; // {0} is firstName, {1} is lastName and {2} is order amount.     
        public const string name = "Mat";
        public const string username = "testqa1";
        public const string password = "testqa1";
        public const string firstName = "Matthew";
        public const string lastName = "Tudor";
        public const string email = "justfortest777@abv.bg";
        public const string firstAddress = "Yalta str";
        public const string secondAddress = "Bulgaria bul";
        public const string companyName = "Space Z";
        public const string state = "Sula";
        public const string city = "Hamilton";
        public const string zipCode = "64834";
        public const string mobileNumber = "(492) 957-325";
        public const string homePageDescription = "All QA engineers can use this website for automation practice and API testing either they are at beginner or advance level. This is for everybody to help them brush up their automation skills.";
        public const string homePageHeadingDescription = "Full-Fledged practice website for Automation Engineers";
        public const string cardNumber = "7271 9888 3445 9541";
        public const string CVC = "672";
        public const string expirationMonth = "09";
        public const string expirationYear = "29";
        public const string contactUsMessage = "Dear [Site Support Team/Technical Support Team],\\r\\n\\r\\nI hope this email finds you well. I am writing to request the addition of validation on an important field within the [name of the site/application/service]. This enhancement will help ensure data accuracy, integrity, and provide a better user experience for all users.";
        public const string contactUsSubject = "Field validations.";

    }
}
