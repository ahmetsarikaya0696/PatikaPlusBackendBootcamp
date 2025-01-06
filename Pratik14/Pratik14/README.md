# Pratik14

This is a simple C# project demonstrating the use of properties and validation in a class.

## Project Structure

- `Araba.cs`: Contains the `Araba` class with properties and validation logic.
- `Program.cs`: Contains the main program logic to create an instance of the `Araba` class and demonstrate the validation.

## Araba Class

The `Araba` class has the following properties:
- `Marka`: The brand of the car.
- `Model`: The model of the car.
- `Renk`: The color of the car.
- `KapiSayisi`: The number of doors, which must be either 2 or 4. If an invalid value is set, it defaults to -1 and prints a message.

### Example Usage
```csharp
using Pratik14;
Araba araba = new Araba() { Marka = "Tesla", Model = "Model S", KapiSayisi = 1, // Invalid value Renk = "Kırmızı" }; // Output: Kapı sayısı 2 veya 4 olmalıdır!
Console.WriteLine($"Kapi sayisi : {araba.KapiSayisi}"); // Output: Kapi sayisi : -1
```
