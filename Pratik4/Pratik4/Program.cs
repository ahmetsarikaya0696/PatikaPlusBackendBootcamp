// Displaying welcome message and fruit prices
Console.WriteLine("Rüya Manavına Hoşgeldiniz\r\nElma = 2TL\r\nArmut = 3TL\r\nÇilek = 2TL\r\nMuz = 3 TL\r\nDiğer bütün meyveler = 4 TL");

// Prompting the user to choose a fruit
Console.Write("Hangi meyveyi satın almak istersiniz?");
string? fruitName = Console.ReadLine()?.ToLower();

// Using if-else to determine the fruit price
if (fruitName == "elma")
{
    Console.WriteLine($"{fruitName} fiyatı 2 TL ' dir");
}
else if (fruitName == "armut")
{
    Console.WriteLine($"{fruitName} fiyatı 3 TL ' dir");
}
else if (fruitName == "çilek")
{
    Console.WriteLine($"{fruitName} fiyatı 2 TL ' dir");
}
else if (fruitName == "muz")
{
    Console.WriteLine($"{fruitName} fiyatı 3 TL ' dir");
}
else
{
    // Default case for other fruits
    Console.WriteLine($"{fruitName} fiyatı 4 TL ' dir");
}

Console.WriteLine("----------------------------------------");

// Using switch-case to determine the fruit price
Console.WriteLine("Rüya Manavına Hoşgeldiniz\r\nElma = 2TL\r\nArmut = 3TL\r\nÇilek = 2TL\r\nMuz = 3 TL\r\nDiğer bütün meyveler = 4 TL");
Console.Write("Hangi meyveyi satın almak istersiniz?");
string? fruitName2 = Console.ReadLine()?.ToLower();

// Switch-case for handling different fruit prices
switch (fruitName2)
{
    case "elma":
        Console.WriteLine($"{fruitName2} fiyatı 2 TL ' dir");
        break;
    case "armut":
        Console.WriteLine($"{fruitName2} fiyatı 3 TL ' dir");
        break;
    case "çilek":
        Console.WriteLine($"{fruitName2} fiyatı 2 TL ' dir");
        break;
    case "muz":
        Console.WriteLine($"{fruitName2} fiyatı 3 TL ' dir");
        break;
    default:
        // Default case for any other fruit not listed
        Console.WriteLine($"{fruitName2} fiyatı 4 TL ' dir");
        break;
}
