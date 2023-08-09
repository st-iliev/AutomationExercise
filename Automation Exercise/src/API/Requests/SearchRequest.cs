using Newtonsoft.Json;

namespace Automation_Exercise.src.API.Requests
{
    public class SearchRequest
    {
        [JsonProperty("search_product")]
        public string SearchProduct { get; set; }
    }

}
