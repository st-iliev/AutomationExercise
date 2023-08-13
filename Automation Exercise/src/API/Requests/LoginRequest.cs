using Newtonsoft.Json;

namespace Automation_Exercise.src.API.Requests
{
    public class LoginRequest
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
