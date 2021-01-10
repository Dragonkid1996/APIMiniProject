using System;
using Newtonsoft.Json;

namespace APIMiniProject
{
    public class SteamLatestDTO
    {
        public LatestNewsRoot LatestNews { get; set; }

        internal void DeserializeNews(string liveNews)
        {
            LatestNews = JsonConvert.DeserializeObject<LatestNewsRoot>(liveNews);
        }
    }
}