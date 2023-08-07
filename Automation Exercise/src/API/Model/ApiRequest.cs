using RestSharp;

namespace Automation_Exercise.src.API.Model
{
    public class ApiRequest<TRequest>
    {
        public string Endpoint { get; set; }
        public Method Method { get; set; }
        public TRequest Data { get; set; }
        public List<ApiParameter> Parameters { get; set; }
    }
}
