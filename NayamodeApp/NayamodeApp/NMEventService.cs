using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NayamodeApp
{
    internal class NMEventService : INMService
    {

        private async Task<string> WebApiPostResponse(string url, string postData)
        {
            try
            {
                var handler = new HttpClientHandler();
                var httpClient = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                HttpContent content = new StringContent(postData);
                request.Content = content;
                if (handler.SupportsTransferEncodingChunked())
                {
                    request.Headers.TransferEncodingChunked = true;
                }
                var response = await httpClient.SendAsync(request);
                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        private async Task<string> WebApiGetResponse(string url)
        {
            try
            {
                var httpClient = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var response = await httpClient.SendAsync(request);
                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        private async Task<string> GetUrlStringData(string url)
        {
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetStringAsync(url);
                return response;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public string UrlResponse_GET(string url)
        {
            return Task.Run(async () => await WebApiGetResponse(url)).Result;
        }

        public string UrlResponse_POST(string url, string content)
        {
            return Task.Run(async () => await WebApiPostResponse(url, content)).Result;
        }

        public async Task<string> UrlResponse(string url)
        {
            try
            {
                var result = await GetUrlStringData(url);
                return result;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
