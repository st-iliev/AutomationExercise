using Newtonsoft.Json;

namespace Automation_Exercise.src.API.Responses
{
    public class UserResponse
    {
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
