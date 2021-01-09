using NUnit.Framework;

namespace APIMiniProject
{
    public class SteamTests
    {
        private SteamService _steamService = new SteamService();

        [Test]
        public void CorrectGameReturned()
        {
            Assert.That(_steamService.SteamLatestDTO.LatestNews.appnews.appid, Is.EqualTo("648350"));
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