using System;
using Newtonsoft.Json;

namespace APIMiniProject
{
    public class SteamLatestDTO
    {
        public LatestAchievementsRoot LatestAchievements { get; set; }

        internal void DeserializeAchievements(string liveAchievements)
        {
            LatestAchievements = JsonConvert.DeserializeObject<LatestAchievementsRoot>(liveAchievements);
        }
    }
}