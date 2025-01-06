bool isValid = false;
string? selectedOption = string.Empty;
do
{
    // Display menu options to the user
    Console.Write("1 - Rastgele Sayı Bulma Oyunu\r\n2 - Hesap Makinesi\r\n3 - Ortalama Hesaplama\r\nYukarıdaki rakamlardan birini giriniz : ");
    selectedOption = Console.ReadLine();

    // Validate the user input
    if (selectedOption == "1" || selectedOption == "2" || selectedOption == "3")
    {
        isValid = true;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Lütfen geçerli bir seçenek seçiniz");
    }

} while (!isValid);


Console.Clear(); // Clear the console before executing the selected option

// Execute the functionality based on the selected option
switch (selectedOption)
{
    case "1":
        PlayRandomNumberGame();
        break;
    case "2":
        ApplyMathCalculation();
        break;
    default:
        CalculateGrade();
        break;
}

// Method to calculate the average grade and determine the letter grade
void CalculateGrade()
{
    Console.Write("1. Not : ");
    int grade1 = Convert.ToInt32(Console.ReadLine());
    if (grade1 < 0 || grade1 > 100)
    {
        Console.WriteLine("Geçersiz not. Program sonlandırılıyor...");
        return;
    }

    Console.Write("2. Not : ");
    int grade2 = Convert.ToInt32(Console.ReadLine());
    if (grade2 < 0 || grade2 > 100)
    {
        Console.WriteLine("Geçersiz not. Program sonlandırılıyor...");
        return;
    }

    Console.Write("3. Not : ");
    int grade3 = Convert.ToInt32(Console.ReadLine());
    if (grade3 < 0 || grade3 > 100)
    {
        Console.WriteLine("Geçersiz not. Program sonlandırılıyor...");
        return;
    }

    // Calculate the average grade
    double average = (grade1 + grade2 + grade3) / 3.0d;

    // Determine the letter grade based on the average
    string letterGrade = string.Empty;
    letterGrade = average switch
    {
        >= 90 => "AA",
        >= 85 => "BA",
        >= 80 => "BB",
        >= 75 => "CB",
        >= 70 => "CC",
        >= 65 => "DC",
        >= 60 => "DD",
        >= 55 => "FD",
        _ => "FF",
    };

    Console.WriteLine($"Ortalamanız : {average}\r\nHarf notunuz : {letterGrade}");
}

// Method to perform basic mathematical operations
void ApplyMathCalculation()
{
    Console.Write("Sayi 1 : ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Sayi 2 : ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    // Prompt the user to select an operation
    Console.Write("Toplama için +\r\nÇıkarma için -\r\nÇarpma için *\r\nBölme için / sembolünü giriniz : ");
    string? operation = Console.ReadLine();

    if (operation == "+")
    {
        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
    }
    else if (operation == "-")
    {
        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
    }
    else if (operation == "*")
    {
        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
    }
    else if (operation == "/")
    {
        if (number2 == 0)
        {
            Console.WriteLine("Sıfıra bölme işlemi yapılamaz!");
        }
        else
        {
            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
        }
    }
    else
    {
        Console.WriteLine("Geçersiz işlem!");
    }
}

// Method for the random number guessing game
void PlayRandomNumberGame()
{
    Random random = new Random();
    int randomNumber = random.Next(1, 100); // Generate a random number between 1 and 100

    int remainingGuesses = 5; // Number of guesses allowed

    Console.WriteLine("1-100 arası sayıyı tahmin ediniz");

    Console.Write("Tahmin : ");
    int userGuess = Convert.ToInt32(Console.ReadLine());

    while (true)
    {
        remainingGuesses--;
        Console.WriteLine($"Kalan tahmin hakkı : {remainingGuesses}");

        if (userGuess == randomNumber)
        {
            Console.WriteLine("Tebrikler! Doğru cevabı bildiniz.");
            break;
        }

        if (remainingGuesses == 0)
        {
            Console.WriteLine($"Doğru cevap : {randomNumber}");
            break;
        }


        if (userGuess > randomNumber)
        {
            Console.Write("Daha küçük bir sayı giriniz\r\nTahmin : ");
        }
        else
        {
            Console.Write("Daha büyük bir sayı giriniz\r\nTahmin : ");
        }

        userGuess = Convert.ToInt32(Console.ReadLine());
    }
}