List<string> guests = new List<string>(); // Create a list to store guests
var input = string.Empty; // Variable to store user input

while (true)
{
    // Retrieve guest name
    Console.Write("Lütfen davet etmek istediğiniz kişinin adını ve soyadını giriniz: ");
    input = Console.ReadLine();

    // Add guest to the list
    guests.Add(input);

    // Ask user if they want to add another guest
    Console.Write("Başka bir davetli eklemek istiyor musunuz? (Evet için herhangi bir tuşa/Hayır için h tuşuna basınız): ");
    input = Console.ReadLine();

    // If user enters "h", exit the loop
    if (input.ToLower() == "h") break;
}

// Display guests
Console.WriteLine("** Davetliler **");
foreach (var guest in guests)
{
    Console.WriteLine(guest);
}