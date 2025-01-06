# Person Class

This repository contains the `Person` class, which demonstrates basic class structure and functionality in C#. The `Person` class models a person with properties and methods to represent and display their attributes.

## Class Overview

The `Person` class includes the following properties and methods:

### Properties
- `Name` (required): The first name of the person.
- `Surname` (required): The last name of the person.
- `IsStudent`: A boolean value indicating whether the person is a student.
- `IsTeacher`: A read-only property that returns `true` if the person is not a student.

### Method
- `DisplayProperties()`: Displays a personalized message introducing the person and their role (student or teacher).

### Example Usage
```csharp
using System;

class Program
{
    static void Main()
    {
        var person = new Person
        {
            Name = "John",
            Surname = "Doe",
            IsStudent = true
        };

        person.DisplayProperties();
    }
}
```
Expected Output
When the above code is executed, it will produce the following output:

Merhaba benim adım John Doe. Ben bir öğrenciyim

If IsStudent is set to false, the output will instead be:

Merhaba benim adım John Doe. Ben bir öğretmenim

###Features
- Demonstrates the use of `required` properties in C#.
- Implements simple business logic with the `IsTeacher` property.
- Uses a method to dynamically display information based on property values.
