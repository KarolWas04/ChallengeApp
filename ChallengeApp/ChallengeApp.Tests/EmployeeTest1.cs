using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectThreeScores_ShouldCorrectResult()
        {
            // arrange
            var user = new Employee("Karol", "Wasilewski", "33");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-12);

            // act
            var result = user.Result;

            // aasert
            Assert.AreEqual(-1, result);
            
        }
    }
}