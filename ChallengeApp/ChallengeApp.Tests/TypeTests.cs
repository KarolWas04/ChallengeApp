using NUnit.Framework;
using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TwoIntNumbers()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;
            // act
            // aasert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void TwoFloatNumbers()
        {
            // arrange
            float number1 = 58.65f;
            float number2 = 53.65f;
            // act
            // aasert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void TwoStringName()
        {
            // arrange
            string name1 = "Karol";
            string name2 = "Karol";
            // act
            // aasert
            Assert.AreEqual(name1, name2);
        }
        [Test]
        public void TwoCharLetters()
        {
            // arrange
            char letter1 = 'W';
            char letter2 = 'w';
            // act
            // aasert
            Assert.AreNotEqual(letter1, letter2);
        }
        [Test]
        public void GetUserShouldReturnDifferentObects()
        {
            // arrange
            var user1 = GetEmployee("Karol");
            var user2 = GetEmployee("Karol");
            // act
            // aasert
            Assert.AreNotEqual(user1, user2);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
