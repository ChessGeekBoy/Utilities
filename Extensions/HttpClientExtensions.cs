using System;
using System.Net.Http;

namespace Utilities.Extensions
{
    public static class HttpClientExtensions
    {
        public static string GetString(this HttpClient httpClient, Uri requestUri)
        {
            return httpClient.GetStringAsync(requestUri).Result;
        }

        public static void Post(this HttpClient httpClient, Uri requestUri, HttpContent requestContent)
        {
            httpClient.PostAsync(requestUri, requestContent).Wait();
        }

        public static void Patch(this HttpClient httpClient, Uri requestUri, HttpContent requestContent)
        {
            httpClient.PatchAsync(requestUri, requestContent).Wait();
        }

        public static void Put(this HttpClient httpClient, Uri requesturi, HttpContent requestContent)
        {
            httpClient.PutAsync(requesturi, requestContent).Wait();
        }

        public static void Delete(this HttpClient httpClient, Uri requestUri)
        {
            httpClient.DeleteAsync(requestUri).Wait();
        }
    }
}
