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
        public void CorrectAuthorReturned()
        {
            Assert.That(_steamService.SteamLatestDTO.LatestNews.appnews.newsitems[0].author, Is.EqualTo("contact@rockpapershotgun.com (Lauren Morton)"));
        }

        [Test]
        public void CorrectDateReturned()
        {
            Assert.That(_steamService.unixToNormalDate(_steamService.SteamLatestDTO.LatestNews.appnews.newsitems[0].date), Is.EqualTo("1/4/2021"));
        }
        [Test]
        public void AppIDRemainsTheSameForNewsArticles()
        {
            Assert.That(_steamService.SteamLatestDTO.LatestNews.appnews.appid, Is.EqualTo(_steamService.SteamLatestDTO.LatestNews.appnews.newsitems[0].appid));
        }

        [Test]
        public void NumberOfNewsArticles()
        {
            Assert.That(_steamService.LiveNews.Length, Is.EqualTo(847));

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

        [Test]
        public void TitleContansJurassicWorldEvolution() {
            Assert.That(_steamService.Json_News["appnews"]["newsitems"][0]["title"].ToString(), Does.Contain("Jurassic World Evolution"));
        }

        //Tests if first news item contains 11 fields
        [Test]
        public void NewsItemContains11Fields() {
            Assert.That(_steamService.FieldCount(), Is.EqualTo(true));
        }

        [Test]
        public void NewsItemsFieldsAreNotEmpty() {
            Assert.That(_steamService.FieldNotEmpty, Is.EqualTo(true));
        }
    }
}