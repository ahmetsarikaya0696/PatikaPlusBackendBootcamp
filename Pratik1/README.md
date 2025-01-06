# Console Application: Personal Goals Display

This simple console application showcases the user's full name and personal learning goals. It uses basic string manipulation and outputs the information to the console.

## Code Overview

The code consists of the following components:

- **Variables**:
  - `fullName`: Stores the full name of the user.
  - `myGoal`: A string containing a list of learning goals.
- **Console Output**:
  - Displays the full name and the goals in a formatted way using string interpolation.
- **Input Pause**:
  - Keeps the console open until the user presses a key.

### Code Example

```csharp
string fullName = "ahmet sarikaya";
string myGoal = "1) SQL'deki eksiklerimi tamamlamak\r\n2) Microservice mimarisi hakkında bilgi edinmek\r\n3) React öğrenmek";
Console.WriteLine($"{fullName}\r\n{myGoal}");
Console.ReadLine();
```

## Output

When you run the program, the output will look like this:

```
ahmet sarikaya
1) SQL'deki eksiklerimi tamamlamak
2) Microservice mimarisi hakkında bilgi edinmek
3) React öğrenmek
```

## How to Run

1. Clone or download the code.
2. Open the project in an IDE that supports C# (e.g., Visual Studio, Visual Studio Code).
3. Build and run the project.
4. The console will display the full name and goals. Press any key to exit.

## Purpose

This application is a personal demonstration of basic C# syntax, including:

- Declaring and using string variables.
- Formatting strings with interpolation.
- Displaying output in a console application.

## Author

- **Ahmet Sarikaya**

---

Feel free to modify the code to include your own name and goals!
