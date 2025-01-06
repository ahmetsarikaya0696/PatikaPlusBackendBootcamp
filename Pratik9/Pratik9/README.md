# Vacation Planning Application

This application allows users to plan their vacation by selecting a location and transportation method. Based on the user input, it calculates the total vacation cost depending on the chosen location, transportation method, and the number of people.

## Features
1. **Location Selection**: The user must choose one of the valid locations. Valid locations are:
   - Bodrum
   - Marmaris
   - Çeşme
2. **Transportation Method Selection**: The user must select one of the transportation methods:
   - **Road transport**: 1500 TL per person for round-trip
   - **Air transport**: 4000 TL per person for round-trip
3. **Number of People**: The user specifies the number of people going on vacation.
4. **Total Cost Calculation**: Based on the selected location and transportation method, the total vacation cost is calculated and displayed.

## Usage

1. When the application starts, the user is prompted to choose a valid location. Locations are:
   - Bodrum
   - Marmaris
   - Çeşme
2. The user is prompted to choose a transportation method:
   - 1 - Road transport
   - 2 - Air transport
3. The user specifies the number of people for the vacation.
4. The application calculates the total vacation cost based on the input and displays it.

## Sample Usage

### Step 1: Location Selection
Please choose one of the following locations: Bodrum, Marmaris, or Çeşme: bodrum

### Step 2: Transportation Method Selection
How would you like to travel for your vacation? (Enter 1 or 2) 1 - Road transport (1500 TL per person for round-trip) 2 - Air transport (4000 TL per person for round-trip)

### Step 3: Number of People
How many people are you planning the vacation for? 3

### Step 4: Calculated Total Cost
Your vacation cost is: 19500 TL.

## Code Explanation

- **Location and Transportation Selection**: The user input is validated to ensure that a valid location and transportation method are selected. If the input is invalid, an error message is shown, and the user is prompted to enter a valid input.
- **Cost Calculation**: Based on the chosen location and transportation method, the cost is calculated. Each location and transportation method has a predefined cost.
- **Total Cost**: The total vacation cost is calculated by multiplying the cost per person by the number of people and displayed to the user.
