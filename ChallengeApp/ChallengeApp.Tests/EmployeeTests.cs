using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void MinMaxAverage_ShouldBeCorrect()
        {
            //arrange

            var employee = new Employee("Karol", "Wasilewski");
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(15);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(5, statistics.Min);
            Assert.AreEqual(15, statistics.Max);
            Assert.AreEqual(9, statistics.Average);
        }
            

    }
}
