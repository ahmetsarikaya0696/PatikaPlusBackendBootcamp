# Method Examples in C#

This project demonstrates various types of methods in C# with different return types and parameter usage. The examples include void methods, methods that return values, and methods with parameters.

## Code Overview

### 1. Void Method without Parameters
```csharp
// A void method that does not return any value.
// Prints your favorite song lyrics to the screen.
void PrintLyric()
{
    Console.WriteLine("Her gün güneş doğar yeter ki açık olsun perdeler");
}
PrintLyric();
```
- **Description**: Prints a line of lyrics to the console.

### 2. Method Returning an Integer
```csharp
// A method that returns an integer.
// Generates a random number and returns the remainder of its division by 2.
int GetInt()
{
    Random random = new Random();
    return random.Next() % 2;
}
int num = GetInt();
Console.WriteLine(num);
```
- **Description**: Generates a random integer and calculates the remainder when divided by 2.
- **Usage**: Demonstrates a method that returns a value.

### 3. Method with Parameters and Return Value
```csharp
// A method that takes parameters and returns a value.
// Returns the product of the two numbers passed as parameters.
int GetProduction(int num1, int num2)
{
    return num1 * num2;
}
int production = GetProduction(4, 5);
Console.WriteLine(production);
```
- **Description**: Multiplies two integers passed as parameters and returns the result.
- **Parameters**:
  - `num1`: First integer.
  - `num2`: Second integer.

### 4. Void Method with Parameters
```csharp
// A method that takes parameters and does not return any value.
// Prints "Welcome {name} {surname}" using the name and surname provided as parameters.
void Greeting(string name, string surname)
{
    Console.WriteLine($"Hoş Geldiniz {name} {surname}");
}
Greeting("ahmet", "sarikaya");
```
- **Description**: Prints a welcome message using name and surname parameters.
- **Parameters**:
  - `name`: The first name.
  - `surname`: The surname.

## Running the Code
1. Copy the code into a C# project or an online compiler like [dotnetfiddle](https://dotnetfiddle.net/).
2. Execute the code to see the following outputs:
   - Song lyrics printed to the console.
   - A random number (0 or 1) displayed.
   - The product of two numbers (4 * 5 = 20).
   - A welcome message with the given name and surname.

## Output Example
```
Her gün güneş doğar yeter ki açık olsun perdeler
--------------------
1
--------------------
20
--------------------
Hoş Geldiniz ahmet sarikaya
```

## Purpose
This project is designed to help beginners understand:
- Different types of methods in C#.
- How to use parameters and return values.
- Basic console output functionality.
