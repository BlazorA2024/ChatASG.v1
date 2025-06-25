using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace NWHttps
{
    public interface IWebApiClientFactory
    {
      Task<HttpClient> GetClientAsync();

    }
 
public class WebApiClientFactory : IWebApiClientFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public WebApiClientFactory(
            IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<HttpClient> GetClientAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("LocalApi");

            //var token = await _httpContextAccessor.HttpContext?.GetTokenAsync("access_token");

            //if (!string.IsNullOrWhiteSpace(token))
            //{
            //    Console.WriteLine($"? [WebApiClientFactory] Bearer Token = {token.Substring(0, 20)}...");

            //    httpClient.DefaultRequestHeaders.Authorization =
            //        new AuthenticationHeaderValue("Bearer", token);
            //}
            //else
            //{
            //    Console.WriteLine("? [WebApiClientFactory] Token is NULL or empty!");
            //}

            return httpClient;
        }
    }

}

//namespace NWHttps
//{

//    public interface IWebApiClientFactory
//    {
//        Task<HttpClient> GetClientAsync();

//    }
//    //https://localhost:6002/swagger/v1/swagger.json
//    //




//    public class WebApiClientFactory : IWebApiClientFactory
//    {
//        private readonly IHttpClientFactory _httpClientFactory;




//        public WebApiClientFactory(
//            IHttpClientFactory httpClientFactory

//            )
//        {
//            _httpClientFactory = httpClientFactory;

//            // _token = token;

//        }



//        public async Task<HttpClient> GetClientAsync()
//        {
//            var httpClient = _httpClientFactory.CreateClient("LocalApi");

//            //httpClient.BaseAddress = new Uri(_appSettings.BaseUrls.Api);
//            //  string bearerToken = _token.AccessToken;
//            //  if (!string.IsNullOrEmpty(bearerToken)) httpClient.SetBearerToken(bearerToken);

//            return httpClient;

//        }

//    }
//}
