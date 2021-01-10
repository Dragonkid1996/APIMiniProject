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

        public bool FieldCount()
        {
            
            for (int i = 0; i < 3; i++) {
                var count = 0;
                foreach (var item in Json_News["appnews"]["newsitems"][i]) {
                    count++;
                }
                if (count != 11) {
                    return false;
                }
            }
            return true;
        }

        public bool FieldNotEmpty()
        {

            for (int i = 0; i < 3; i++)
            {
                foreach (var item in Json_News["appnews"]["newsitems"][i])
                {
                    if (item.ToString().Length <= 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        public string unixToNormalDate(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch).ToShortDateString();
        }

        public int CountContentCharacters()
        {
            return Json_News["appnews"]["newsitems"][1]["contents"].ToString().Length;
        }

        public int CountNumberOfArticles()
        {
            var count = 0;
            foreach (var item in Json_News["appnews"]["newsitems"])
            {
                count += 1;
            }
            return count;
        }
    }
}
