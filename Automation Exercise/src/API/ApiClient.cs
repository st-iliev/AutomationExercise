using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Refit;

public class ApiClient
{
    private readonly HttpClient httpClient;

    public ApiClient(string baseApiUrl)
    {
        httpClient = new HttpClient { BaseAddress = new Uri(baseApiUrl) };
    }

    public async Task<ApiResponse<TResponse>> SendAsync<TRequest, TResponse>(ApiRequest<TRequest> request)
    {
        try
        {
            HttpResponseMessage response;

            switch (request.Method.Method.ToUpper())
            {
                case "GET":
                    response = await httpClient.GetAsync(request.Url);
                    break;
                case "POST":
                    response = await httpClient.PostAsJsonAsync(request.Url, request.Data);
                    break;
                // Implement handling for other HTTP methods (PUT, DELETE) as needed
                default:
                    throw new ArgumentException($"Unsupported HTTP method: {request.Method}");
            }

            var apiResponse = new ApiResponse<TResponse>
            {
                StatusCode = response.StatusCode
            };

            if (response.IsSuccessStatusCode)
            {
                apiResponse.Data = await response.Content.ReadAsAsync<TResponse>();
            }

            return apiResponse;
        }
        catch (Exception ex)
        {
            // Handle any exceptions that may occur during the API request
            // You can log the exception or perform any other actions based on your needs
            throw;
        }
    }
}