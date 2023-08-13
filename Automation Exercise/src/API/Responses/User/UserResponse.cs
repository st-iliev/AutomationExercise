using System.Net;

namespace Automation_Exercise.src.API.Responses.User
{
    public class UserResponse
    {
        public HttpStatusCode ResponseCode { get; set; }
        public User User { get; set; }
    }
}
