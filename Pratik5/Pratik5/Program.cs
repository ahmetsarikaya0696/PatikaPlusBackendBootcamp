// Initialize a counter to track the number of correct answers
var correctAnswerCount = 0;

// Ask the first question
Console.WriteLine("Kızınca tüküren hayvan hangisidir ?\r\na) Lama b) Deve");
string? userAnswer = Console.ReadLine()?.ToLower();

// Check if the answer is correct
if (userAnswer == "a")
{
    correctAnswerCount++;  // Increment the correct answer count
    Console.WriteLine("Doğru cevap");  // Correct answer message
}
else
{
    Console.WriteLine("Yanlış cevap");  // Incorrect answer message
}

// Ask the second question
Console.WriteLine("Dünya'ya en yakın gezegen hangisidir ?\r\na) Venüs b) Mars");
userAnswer = Console.ReadLine()?.ToLower();

// Check if the answer is correct
if (userAnswer == "a")
{
    correctAnswerCount++;  // Increment the correct answer count
    Console.WriteLine("Doğru cevap");  // Correct answer message
}
else
{
    Console.WriteLine("Yanlış cevap");  // Incorrect answer message
}

// If the user answered both questions correctly
if (correctAnswerCount == 2)
{
    Console.WriteLine("Tebrikler, ödülü kazandınız");  // Congratulatory message for winning the prize
    return;  // Exit the program
}

// Ask the third question
Console.WriteLine("5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?\r\na) 7 b) 12");
userAnswer = Console.ReadLine()?.ToLower();

// Check if the answer is correct
if (userAnswer == "b")
    correctAnswerCount++;  // Increment the correct answer count

// Check if the user answered both questions correctly
if (correctAnswerCount == 2)
{
    Console.WriteLine("Tebrikler, ödülü kazandınız");  // Congratulatory message for winning the prize
}
else
{
    Console.WriteLine("Üzgünüm, ödülü kazanamadınız");  // Apology message for not winning the prize
}