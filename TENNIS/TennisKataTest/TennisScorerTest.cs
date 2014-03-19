using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisKata;

namespace TennisKataTest
{
    [TestClass]
    public class TennisScorerTest
    {
        private ITennisScorer _scorer;

        [TestInitialize]
        public void Setup()
        {
            _scorer = new TennisScorer();
            _scorer.StartGame("Player 1", "Player 2");
        }

        [TestMethod]
        public void StartGameTest()
        {
            var score = _scorer.Score;
            Assert.AreEqual("Love-All", score);
        }

    }
}
