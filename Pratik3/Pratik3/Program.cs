Console.Write("Lütfen bir sayı giriniz : "); // Prompt the user to enter a number
string? sayiStr = Console.ReadLine(); // Read the input as a string
int.TryParse(sayiStr, out int sayi); // Try to convert the input string to an integer

if (sayi < 10)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür."); // Output that the number is less than 10
}
else if (sayi > 10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür."); // Output that the number is greater than 10
}
else
{
    Console.WriteLine("Girilen sayı 10'a eşittir."); // Output that the number is equal to 10
}

if (sayi % 2 == 0)
{
    Console.WriteLine("Girilen sayı çifttir."); // Output that the number is even
}
else
{
    Console.WriteLine("Girilen sayı tektir."); // Output that the number is odd
}