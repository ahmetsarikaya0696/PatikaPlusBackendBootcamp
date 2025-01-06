// This program prompts the user to enter a number and displays its square.
bool isValidInput = false;
while (!isValidInput)
{
    // Try block to handle potential exceptions during input and processing
    try
    {
        // Prompt the user for a number
        Console.Write("Sayı : ");

        // Convert the input to an integer
        int sayi = Convert.ToInt32(Console.ReadLine());

        // Output the square of the number
        Console.WriteLine($"Sayinin karesi : {sayi * sayi}");

        isValidInput = true;
    }
    // Catch block to handle exceptions
    catch (Exception)
    {
        // Inform the user of invalid input
        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
    }
}