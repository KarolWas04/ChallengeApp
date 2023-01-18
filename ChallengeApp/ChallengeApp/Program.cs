string name = "Ewa";
char sex = 'K';
int age = 30;

if (sex == 'K')
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta ponizej 30");
    }
    else if (age > 30)
    {
        Console.WriteLine("Kobieta powyzej 30");
    }
    else if (name == "Ewa" && age == 30)
    {
        Console.WriteLine("Ewa lat 30");
    }
}
else if (sex != 'K')
{
    if (age < 18)
    {
        Console.WriteLine("Niepelnoletni mezczyzna");
    }
    else  if (age > 18)
    {
        Console.WriteLine("Pelnoletni mezczyzna");
    }
}