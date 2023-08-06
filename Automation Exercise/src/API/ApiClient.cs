using Automation_Exercise.src.API.Model;
using Automation_Exercise.src.API.Utilities;
using Newtonsoft.Json;
using RestSharp;

public class ApiClient
{
    private readonly RestClient restClient;

    public ApiClient()
    {
        restClient = new RestClient(ConfigurationHelper.BaseUrl);
    }

    private ApiResponse<TResponse> SendRequest<TRequest, TResponse>(ApiRequest<TRequest> request)
    {
        var restRequest = new RestRequest(request.Endpoint, request.Method);
        if (request.Method == Method.Post && request.Data == null)
        {
            restRequest.AddJsonBody("");
        }
        else if (request.Method != Method.Get)
        {
            var jsonRequestData = JsonConvert.SerializeObject(request.Data);
            restRequest.AddParameter("application/json", jsonRequestData, ParameterType.RequestBody);
        }

        var response = restClient.Execute<TResponse>(restRequest);
        return new ApiResponse<TResponse>
        {
            StatusCode = (int)response.StatusCode,
            Data = response.Data,
            Message = response.Content
        };
    }

    public ApiResponse<TResponse> Get<TResponse>(string endpoint)
    {
        var request = new ApiRequest<object>
        {
            Endpoint = endpoint,
            Method = Method.Get
        };
        return SendRequest<object, TResponse>(request);
    }
    public ApiResponse<TResponse> Post<TRequest, TResponse>(string endpoint, TRequest data)
    {
        var request = new ApiRequest<TRequest>
        {
            Endpoint = endpoint,
            Method = Method.Post,
            Data = data
        };
        return SendRequest<TRequest, TResponse>(request);
    }
    public ApiResponse<TResponse> Put<TRequest, TResponse>(string endpoint, TRequest data)
    {
        var request = new ApiRequest<TRequest>
        {
            Endpoint = endpoint,
            Method = Method.Put,
            Data = data
        };
        return SendRequest<TRequest, TResponse>(request);
    }
    public ApiResponse<TResponse> Delete<TResponse>(string endpoint)
    {
        var request = new ApiRequest<object>
        {
            Endpoint = endpoint,
            Method = Method.Delete
        };
        return SendRequest<object, TResponse>(request);
    }
}