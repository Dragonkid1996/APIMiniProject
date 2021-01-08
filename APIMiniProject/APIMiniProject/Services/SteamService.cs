using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace APIMiniProject
{
    public class SteamService
    {
        public SteamCallManager SteamCallManager { get; set; } = new SteamCallManager();
        public SteamLatestDTO SteamLatestDTO { get; set; } = new SteamLatestDTO();
        public string LiveAchievements { get; set; }
        public JObject Json_Achievements { get; set; }

        public SteamService()
        {
            LiveAchievements = SteamCallManager.GetLatestAchievements();
            Json_Achievements = JsonConvert.DeserializeObject<JObject>(LiveAchievements);
            SteamLatestDTO.DeserializeAchievements(LiveAchievements);
        }
    }
}
