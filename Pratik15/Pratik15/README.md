# Pratik15

This repository contains a simple C# application demonstrating inheritance and polymorphism concepts. The application includes classes for `Ogretmen` (Teacher) and `Ogrenci` (Student) that inherit from a base class `BaseKisi`.

## Project Structure

- **Program.cs**: The main entry point of the application where instances of `Ogretmen` and `Ogrenci` are created and their methods are called.
- **BaseKisi.cs**: Defines the abstract base class `BaseKisi` with common properties and methods.
- **Ogretmen.cs**: Defines the `Ogretmen` class that inherits from `BaseKisi` and adds a `Maas` property.
- **Ogrenci.cs**: Defines the `Ogrenci` class that inherits from `BaseKisi` and adds an `OgrenciNumarasi` property.


## Classes

### BaseKisi

An abstract base class that contains common properties and methods for `Ogretmen` and `Ogrenci`.

- **Properties**:
  - `Ad` (required): The first name of the person.
  - `Soyad` (required): The last name of the person.

- **Methods**:
  - `DisplayAdSoyad()`: Displays the first and last name.

### Ogretmen

Inherits from `BaseKisi` and adds a `Maas` property.

- **Properties**:
  - `Maas`: The salary of the teacher.

- **Methods**:
  - `DisplayAdSoyadMaas()`: Displays the first name, last name, and salary.

### Ogrenci

Inherits from `BaseKisi` and adds an `OgrenciNumarasi` property.

- **Properties**:
  - `OgrenciNumarasi` (required): The student number.

- **Methods**:
  - `DisplayAdSoyadOgrenciNo()`: Displays the first name, last name, and student number.
