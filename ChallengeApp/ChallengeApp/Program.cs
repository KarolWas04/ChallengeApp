using ChallengeApp;

var employee = new Employee("Karol", "Wasilewski");
employee.AddGrade(9f);
employee.AddGrade(3.5);
employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade(8);

//var statistics = employee.GetStatistics();

var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWihle();

//Console.WriteLine($"Average: {statistics.Average:N2}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("Statistics with Foreach");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine("-----");
Console.WriteLine("Statistics with For");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine("-----");
Console.WriteLine("Statistics with DoWhile");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine("-----");
Console.WriteLine("Statistics with While");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine("-----");