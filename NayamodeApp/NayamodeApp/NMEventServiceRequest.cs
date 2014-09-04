using System.Collections.Generic;
using System.Threading.Tasks;
using NayamodeApp.Model;
using Newtonsoft.Json;

namespace NayamodeApp
{
    public enum ServiceMethod
    {
        Post, Get, URL
    }
    public class NMEventServiceRequest
    {
        private INMService _servicecall;

        public NMEventServiceRequest()
            : this(new NMEventService())
        {
        }

        private NMEventServiceRequest(INMService serviceCall)
        {
            _servicecall = serviceCall;
        }

        public async Task<T> GetUrlResponse<T>(ServiceMethod methodType, string url, string data)
        {
            string response = "";
            switch (methodType)
            {
                case ServiceMethod.Get:
                    response = _servicecall.UrlResponse_GET(url);
                    break;
                case ServiceMethod.Post:
                    response = _servicecall.UrlResponse_POST(url, data);
                    break;
                case ServiceMethod.URL:
                    response = await _servicecall.UrlResponse(url);
                    break;
                default:
                    response = "";
                    break;
            }

            return JsonConvert.DeserializeObject<T>("{\"Data\":" + response + "}");
        }


        public List<AttendeeModel> Test<T>(string data)
        {
            return JsonConvert.DeserializeObject<List<AttendeeModel>>(data);
        }

    }
}
