using NUnit.Framework;

namespace APIMiniProject
{
    public class SteamTests
    {
        private SteamService _steamService = new SteamService();

        [Test]
        public void CorrectGameReturned()
        {
            Assert.That(_steamService.SteamLatestDTO.LatestNews.appnews.appid, Is.EqualTo(648350));
        }
    }
}