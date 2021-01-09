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
        }
    }
}