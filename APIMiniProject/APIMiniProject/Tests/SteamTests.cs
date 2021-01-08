using NUnit.Framework;

namespace APIMiniProject
{
    public class SteamTests
    {
        private SteamService _steamService = new SteamService();

        [Test]
        public void WebCallSuccessCheck()
        {
            Assert.That(_steamService.SteamLatestDTO.LatestAchievements.success);
        }
    }
}