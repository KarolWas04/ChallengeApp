﻿int number = 625832619;
string numberInString = number.ToString();
char[] letters= numberInString.ToArray();

List<char> numbers= new List<char>();
numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');


foreach (var singular in numbers)
{
    int count = 0;
    foreach (var x in letters)
    {
        if (singular==x) count++;
    }
    Console.WriteLine(singular + "=>" + count);
}