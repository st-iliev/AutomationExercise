using System.Net;
using System.Text.Json.Serialization;

namespace Automation_Exercise.src.API.Responses
{
    public class UpdateUserResponse
    {
        [JsonPropertyName("responseCode")]
        public HttpStatusCode ResponseCode { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
