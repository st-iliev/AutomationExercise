using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.src.API.Utilities
{
    public class ConfigurationHelper
    {
        public static string BaseUrl { get; private set; } = "https://automationexercise.com";
        public static string Username { get; private set; } = "testqa1";
        public static string Password { get; private set; } = "testqa1";


        public static void SetBaseUrl(string baseUrl)
        {
            BaseUrl = baseUrl;
        }

        public static void SetUsername(string username)
        {
            Username = username;
        } 
        public static void SetPassword(string password)
        {
            Password = password;
        }
    }
}
