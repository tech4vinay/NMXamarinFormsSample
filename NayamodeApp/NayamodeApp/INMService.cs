using System.Threading.Tasks;

namespace NayamodeApp
{
    public interface INMService
    {
        string UrlResponse_GET(string url);
        string UrlResponse_POST(string url, string content);
        Task<string> UrlResponse(string url);
    }
}
