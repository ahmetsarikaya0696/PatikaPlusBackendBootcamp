List<string> coffees = new List<string>();
string input = string.Empty;
int index = 1;

while (true)
{
    Console.Write($"Kahve {index} : ");
    input = Console.ReadLine();

    coffees.Add(input);

    Console.Write("Başka kahve eklemek istiyorsanız herhangi bir tuşa istemiyorsanız 'h' tuşuna basınız : ");
    input = Console.ReadLine().ToLower();

    if (input == "h")
    {
        Console.WriteLine("Programdan çıkılıyor...");
        break;
    }
    index++;
}

Console.WriteLine("Girilen Kahve İsimleri:");
foreach (var coffee in coffees)
{
    Console.WriteLine(coffee);
}