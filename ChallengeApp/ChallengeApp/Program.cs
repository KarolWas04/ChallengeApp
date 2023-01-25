using ChallengeApp;
using System.Reflection.Metadata;

Employee person1 = new Employee("Karol", "Wasilewski", "33");
Employee person2 = new Employee("Janusz", "Kowalski", "54");
Employee person3 = new Employee("Grazyna", "Kowalska", "50");

person1.AddScore(5); person1.AddScore(2); person1.AddScore(3); person1.AddScore(9); person1.AddScore(4);

person2.AddScore(2); person2.AddScore(4); person2.AddScore(9); person2.AddScore(1); person2.AddScore(8);

person3.AddScore(6); person3.AddScore(5); person3.AddScore(8); person3.AddScore(4); person3.AddScore(3);


List<Employee> people = new List<Employee>()
{
    person1, person2, person3
};

int maxResult = -1;
Employee personWithMaxResult = null;
foreach(var person in people)
{
    if(person.Result > maxResult)
    {
        personWithMaxResult = person;
    }
}
Console.WriteLine($"Osoba z najwyzsza liczba ocen to: {personWithMaxResult.Name} {personWithMaxResult.Surname} w wieku {personWithMaxResult.Age} lat z wynikiem {personWithMaxResult.Result} punktow.");