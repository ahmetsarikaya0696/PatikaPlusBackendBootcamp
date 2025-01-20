// Create a new instance of Random to generate random numbers
Random random = new Random();

// Generate a list of 10 random integers between -100 and 100
var numbers = Enumerable.Range(1, 10).Select(x => random.Next(-100, 100)).ToList();
PrintList(numbers); // Print the original list of numbers

// Filter and print even numbers from the list
var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
PrintList(evenNumbers);

// Filter and print odd numbers from the list
var oddNumbers = numbers.Where(x => x % 2 != 0).ToList();
PrintList(oddNumbers);

// Filter and print negative numbers from the list
var negativeNumbers = numbers.Where(x => x < 0).ToList();
PrintList(negativeNumbers);

// Filter and print positive numbers from the list
var positiveNumbers = numbers.Where(x => x > 0).ToList();
PrintList(positiveNumbers);

// Filter and print numbers between 15 and 22 from the list
var between15And22 = numbers.Where(x => x > 15 && x < 22).ToList();
PrintList(between15And22);

// Calculate and print the squares of the numbers in the list
var squares = numbers.Select(x => x * x).ToList();
PrintList(squares);

// Method to print the contents of a list
void PrintList(List<int> list)
{
    // Check if the list has any elements
    if (list.Any())
    {
        // Print each element in the list
        list.ForEach(x => Console.WriteLine(x));
    }
    else
    {
        // Print a message if the list is empty
        Console.WriteLine("Listede eleman bulunamadı!");
    }

    // Print a separator line
    Console.WriteLine("----------");
}
