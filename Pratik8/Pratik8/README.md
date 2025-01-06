Counter Loop Example

This project demonstrates the use of while and do-while loops in C# to iterate through a counter from 0 up to a user-defined limit and print a message to the console.

Code Overview

The program works as follows:

Prompts the user to input a limit value.

Converts the input into an integer.

Uses two separate loop structures (while and do-while) to:

Increment a counter starting from 0.

Print a message to the console on each iteration.

Key Features:

The while loop runs as long as the condition (counter <= limit) is true.

The do-while loop runs at least once, even if the condition is false.

Code Explanation

// Prompt the user to input a limit
Console.Write("Limit : ");
int.TryParse(Console.ReadLine(), out int limit);

// Initialize the counter
int i = 0;

// Use a while loop
while (i <= limit)
{
    Console.WriteLine($"{i}) Ben bir Patika'lıyım");
    i++;
}

// Reset the counter
i = 0;

// Use a do-while loop
do
{
    Console.WriteLine($"{i}) Ben bir Patika'lıyım");
    i++;
} while (i <= limit);

Behavior of Loops

while Loop

Checks the condition before executing the loop body.

If the condition is false from the start, the loop body will not execute.

do-while Loop

Executes the loop body at least once, regardless of the condition.

The condition is checked after the loop body executes.

Example Output

Input

Limit : 3

Output

0) Ben bir Patika'lıyım
1) Ben bir Patika'lıyım
2) Ben bir Patika'lıyım
3) Ben bir Patika'lıyım

0) Ben bir Patika'lıyım
1) Ben bir Patika'lıyım
2) Ben bir Patika'lıyım
3) Ben bir Patika'lıyım

Usage Instructions

Compile the code using a C# compiler (e.g., csc).

Run the program.

Enter an integer value when prompted for a limit.

Observe the output demonstrating both while and do-while loop behavior.

Key Learning Points

Understand the difference between while and do-while loops.

Practice using loops to solve simple iterative problems.

Learn how to take user input and convert it to an integer using int.TryParse.
