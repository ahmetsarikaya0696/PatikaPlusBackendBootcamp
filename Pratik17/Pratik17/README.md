# Pratik17

This repository contains a simple C# project demonstrating the use of abstract classes and inheritance in .NET 8.

## Files

### `Calisan.cs`

This file defines an abstract class `Calisan` which represents an employee. It includes the following properties and methods:

- `Ad`: Gets or sets the first name of the employee.
- `Soyad`: Gets or sets the last name of the employee.
- `Departman`: Gets or sets the department of the employee.
- `Gorev()`: An abstract method to define the task of the employee.

### `ProjeYoneticisi.cs`

This file defines a class `ProjeYoneticisi` which inherits from `Calisan`. It includes the following method:

- `Gorev()`: Overrides the abstract method to define the task of the project manager, which prints a message to the console.

### `Program.cs`

This file contains the entry point of the application. It creates an instance of `ProjeYoneticisi`, sets its properties, and calls the `Gorev` method to display the task of the project manager.
