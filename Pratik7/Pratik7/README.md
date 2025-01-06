# C# While Loop Examples

This project demonstrates basic usage of `while` loops in C#. The examples cover a variety of tasks including printing messages, calculating sums, and working with even and odd numbers.

---

## Examples

### 1. Print a Motivational Message 10 Times
The program prints the message:

```
"Kendime inanıyorum, ben bu yazılım işini hallederim!"
```

10 times on the console, along with a sequential number prefix.

#### Code Snippet:
```csharp
int i = 0;
while (i < 10)
{
    Console.WriteLine($"{i + 1}) Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}
```

---

### 2. Print Numbers from 1 to 20
The program prints all integers from 1 to 20.

#### Code Snippet:
```csharp
i = 1;
while (i <= 20)
{
    Console.WriteLine(i);
    i++;
}
```

---

### 3. Print Even Numbers from 1 to 20
The program prints all even integers between 1 and 20.

#### Code Snippet:
```csharp
i = 1;
while (i <= 20)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}
```

---

### 4. Calculate the Sum of Numbers from 50 to 150
The program calculates the sum of all integers between 50 and 150 and displays the result.

#### Code Snippet:
```csharp
i = 50;
int toplam = 0;
while (i <= 150)
{
    toplam += i;
    i++;
}
Console.WriteLine($"Toplam : {toplam}");
```

---

### 5. Calculate the Sum of Even and Odd Numbers Separately (1 to 120)
The program calculates the sum of even and odd integers separately from 1 to 120 and displays the results.

#### Code Snippet:
```csharp
int tekToplam = 0;
int ciftToplam = 0;
i = 1;
while (i <= 120)
{
    if (i % 2 == 0)
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;
    }
    i++;
}

Console.WriteLine($"Çift sayıların toplamı : {ciftToplam}\r\nTek sayıların toplamı : {tekToplam}");
```

---

## Requirements
- .NET SDK installed
- A C# development environment (e.g., Visual Studio, Visual Studio Code, or JetBrains Rider)

---

## How to Run
1. Copy the code into a `.cs` file (e.g., `Program.cs`).
2. Open a terminal and navigate to the directory containing the file.
3. Compile the program using the following command:
   ```bash
   dotnet build
   ```
4. Run the compiled program:
   ```bash
   dotnet run
   ```

---

## Output
The program outputs the results for each of the above tasks sequentially, separated by lines of dashes (`--------------------`).
