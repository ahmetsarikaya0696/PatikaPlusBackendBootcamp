int[] numbers = new int[10]; // numbers array with 10 elements created
Random random = new Random(); // random created to generate random integers

// numbers array filled with random integer values
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 100);
}

// Display before sorting
DisplayNumbers(numbers);

// retrieving integer from user
// Console.Write("Number : ");
// var number = Convert.ToInt32(Console.ReadLine());

// Adding an 11th number is not possible because the array size is fixed
// numbers[11] = number; // Uncommenting this will cause an error
// Console.WriteLine(numbers[11]);

// Bubble sort
for (int j = 0; j < numbers.Length; j++)
{
    for (int i = 0; i < numbers.Length - 1-j; i++)
    {
        if (numbers[i] < numbers[i + 1])
        {
            int temp = numbers[i + 1];
            numbers[i + 1] = numbers[i];
            numbers[i] = temp;
        }
    }
}

// Display after sorting
DisplayNumbers(numbers);

static void DisplayNumbers(int[] numbers)
{
    // numbers array displayed
    foreach (int numberItem in numbers)
    {
        Console.WriteLine(numberItem);
    }
}