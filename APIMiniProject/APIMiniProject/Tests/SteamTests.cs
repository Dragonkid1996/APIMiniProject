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

        [Test]
        public void CountContentCharactersTest()
        {
            ///380 because the 300 max characters in parameters of API call is without hyperlink tag
            Assert.That(_steamService.CountContentCharacters(), Is.EqualTo(380));
        }

        [Test]
        public void NumberOfArticlesIsSameAsSpecified()
        {
            Assert.That(_steamService.CountNumberOfArticles(), Is.EqualTo(3));
        }

        [Test]
        public void GameIDIsInURLOfPost()
        {
            Assert.That(_steamService.Json_News["appnews"]["newsitems"][0]["url"].ToString(),
                Does.Contain(_steamService.Json_News["appnews"]["newsitems"][0]["gid"].ToString()));
        }
    }
}