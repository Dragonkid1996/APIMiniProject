using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace APIMiniProject
{
    public class SteamService
    {
        public SteamCallManager SteamCallManager { get; set; } = new SteamCallManager();
        public SteamLatestDTO SteamLatestDTO { get; set; } = new SteamLatestDTO();
        public string LiveNews { get; set; }
        public JObject Json_News { get; set; }

        public SteamService()
        {
            LiveNews = SteamCallManager.GetNews();
            Json_News = JsonConvert.DeserializeObject<JObject>(LiveNews);
            SteamLatestDTO.DeserializeNews(LiveNews);
        }
    }
}
