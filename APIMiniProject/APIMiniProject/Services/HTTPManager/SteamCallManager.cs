using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace APIMiniProject
{
    public class SteamCallManager
    {
        private readonly IRestClient _client;

        public SteamCallManager()
        {
            _client = new RestClient(SteamConfigReader.BaseUrl);
        }
        
        public string GetNews()
        {
            string interfaceName = "ISteamUser";
            string methodName = "GetNewsForApp";
            string version = "v0002";

            var request = new RestRequest($"{interfaceName}/{methodName}/{version}/?appid=648350&count=3&maxlength=300&format=json");

            var response = _client.Execute(request, Method.GET);

            return response.Content;
        }
    }
}
