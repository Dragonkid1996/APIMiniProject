using System;
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

        public string GetAchievements()
        {
            string interfaceName = "ISteamUser";
            string methodName = "GetGlobalAchievementPercentagesForApp";
            string version = "v0002";

            var request = new RestRequest($"{interfaceName}/{methodName}/{version}/?gameid=440&format=json");
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }

        internal string GetLatestAchievements()
        {
            throw new NotImplementedException();
        }
    }
}
