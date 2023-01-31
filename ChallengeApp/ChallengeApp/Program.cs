using ChallengeApp;

var employee = new Employee("Karol", "Wasilewski");
employee.AddGrade("Karol");
employee.AddGrade("2000");
employee.AddGrade(2);
employee.AddGrade(6);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");