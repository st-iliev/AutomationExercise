namespace Automation_Exercise.src.API.Utilities
{
    public class ConfigurationHelper
    {
        public static string BaseUrl { get; private set; } = "https://automationexercise.com";
        public static string Password { get; private set; } = "testqa1";
        public static string Email { get; private set; } = "justfortest777@abv.bg";


        public static void SetBaseUrl(string baseUrl)
        {
            BaseUrl = baseUrl;
        }
        public static void SetPassword(string password)
        {
            Password = password;
        }
    }
}
