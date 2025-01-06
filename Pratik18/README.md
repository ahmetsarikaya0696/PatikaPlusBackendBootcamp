# Bubble Sort Example in C#

This project demonstrates the implementation of a Bubble Sort algorithm in C#. The program generates an array of random integers, displays the numbers before sorting, sorts the array in descending order, and displays the sorted numbers.

## Features

- Generates an array of 10 random integers between 1 and 100.
- Sorts the array using the Bubble Sort algorithm in descending order.
- Displays the numbers before and after sorting.

## Code Explanation

### Key Sections

1. **Array Initialization**: Creates an array of 10 elements and fills it with random integers.

   ```csharp
   int[] numbers = new int[10];
   Random random = new Random();

   for (int i = 0; i < numbers.Length; i++)
   {
       numbers[i] = random.Next(1, 100);
   }
   ```

2. **Bubble Sort Implementation**: Sorts the array in descending order.

   ```csharp
   for (int j = 0; j < numbers.Length; j++)
   {
       for (int i = 0; i < numbers.Length - 1 - j; i++)
       {
           if (numbers[i] < numbers[i + 1])
           {
               int temp = numbers[i + 1];
               numbers[i + 1] = numbers[i];
               numbers[i] = temp;
           }
       }
   }
   ```

3. **Display Numbers**: Outputs the numbers before and after sorting.

   ```csharp
   static void DisplayNumbers(int[] numbers)
   {
       foreach (int numberItem in numbers)
       {
           Console.WriteLine(numberItem);
       }
   }
   ```

## Notes

- The program includes commented-out code to demonstrate the limitation of fixed-size arrays.
- To extend the program to accept user input, you can uncomment and modify the relevant sections.
