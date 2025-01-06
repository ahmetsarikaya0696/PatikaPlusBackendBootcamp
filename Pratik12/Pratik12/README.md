# Bebek Class Application

This project is a simple C# application that defines a `Bebek` class and demonstrates its usage. The `Bebek` class stores a Baby's first name, last name, and birth date, and can display this information in the console.

## Project Contents

- **Bebek Class**:
  - Includes a default constructor (`public Bebek()`) and a parameterized constructor (`public Bebek(string Ad, string Soyad)`).
  - Contains properties for `Ad`, `Soyad`, and `DogumTarihi`.
  - Provides a `DisplayProperties` method to print the properties to the console.

- **Console Application**:
  - Creates two different instances of the `Bebek` class:
    - One using the default constructor.
    - Another using the parameterized constructor.
  - Displays the properties of each instance using the `DisplayProperties` method.

## Example Output

When the program is executed, the console will display the following output:

```text
 Ingaaaa
Ad: -, Soyad: -, Birth Date: 12/30/2024
 Ingaaaa
Ad: Ali, Soyad: Veli, Birth Date: 12/30/2024
```
