using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace APIMiniProject
{
    public class SteamService
    {
        public SteamCallManager steamCallManager { get; set; } = new SteamCallManager();

        public SteamLatestDTO steamLatestDTO { get; set; } = new SteamLatestDTO();

        public string LiveNews { get; set; }

        public JObject Json_News { get; set; }

        public SteamService()
        {
            LiveNews = steamCallManager.GetNews();
            //Json_News = JsonConvert.DeserializeObject<JObject>(LiveNews);
            steamLatestDTO.DeserializeNews(LiveNews);
        }
    }
}
