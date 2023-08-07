namespace Automation_Exercise.src.API.Model
{
    public class ApiResponse<TResponse>
    {
        public int StatusCode { get; set; }
        public TResponse Data { get; set; }
        public string? Message { get; set; }  
    }
}
