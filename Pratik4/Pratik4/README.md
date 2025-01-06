# Fruit Price Calculator

This is a simple console application that simulates a fruit shop, where users can input the name of a fruit and receive its price. The application displays a list of fruit prices and calculates the price based on the user's input. 

The program is implemented using C# and demonstrates both the `if-else` and `switch-case` control structures.

## Features

- Displays fruit prices:  
  - Apple: 2 TL  
  - Pear: 3 TL  
  - Strawberry: 2 TL  
  - Banana: 3 TL  
  - All other fruits: 4 TL

- Allows users to input the name of a fruit and see its corresponding price.

- Uses both `if-else` and `switch-case` statements to determine the fruit's price.

## Usage

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or your preferred C# IDE.
3. Run the program.
4. The application will ask you which fruit you would like to buy.
5. Type the name of the fruit (e.g., "elma", "armut", "çilek", "muz") and hit Enter.
6. The program will display the price of the fruit you selected.
7. If the fruit is not on the list, it will default to 4 TL.

## Code Structure

- **Main Program**: Contains the logic for displaying the fruit prices and taking user input.
- **if-else Logic**: Determines the price of the fruit based on the user's input using a series of `if-else` conditions.
- **switch-case Logic**: Provides an alternative method of determining the fruit price using a `switch-case` structure.
