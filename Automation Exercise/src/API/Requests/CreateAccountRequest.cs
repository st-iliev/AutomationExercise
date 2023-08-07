
using Newtonsoft.Json;

namespace Automation_Exercise.src.API.Requests
{
    public class CreateAccountRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        public string Title { get; set; }
        public string Birth_Date { get; set; } 
        public string Birth_Month { get; set; } 
        public string Birth_Year { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Mobile_Number { get; set; }
       
    }
}
