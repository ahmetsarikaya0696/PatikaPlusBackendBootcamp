// A void method that prints your favorite song lyrics to the screen and does not return any value.
void PrintLyric()
{
    Console.WriteLine("Her gün güneş doğar yeter ki açık olsun perdeler");
}
PrintLyric();

Console.WriteLine("--------------------");
// A method that generates a random number and returns the remainder when this number is divided by 2 as an integer
int GetInt()
{
    Random random = new Random();
    return random.Next() % 2;
}
int num = GetInt();
Console.WriteLine(num);

Console.WriteLine("--------------------");
// A method that takes two numbers as parameters and returns their product as an integer
int GetProduction(int num1, int num2)
{
    return num1 * num2;
}
int production = GetProduction(4, 5);
Console.WriteLine(production);

Console.WriteLine("--------------------");
// A method that takes name and surname as parameters and prints "Welcome {name} {surname}" to the screen
void Greeting(string name, string surname)
{
    Console.WriteLine($"Hoş Geldiniz {name} {surname}");
}
Greeting("ahmet", "sarikaya");