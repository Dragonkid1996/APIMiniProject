using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static APIMiniProject.LatestStatsModel;

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
