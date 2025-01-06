# Hafta5Kapanis

## Overview
This project allows users to create and manage a list of cars (`Araba`). Users can input details such as serial number, brand, model, color, and the number of doors for each car.

## Araba Class
The `Araba` class represents a car with the following properties:

- **UretimTarihi**: The production date of the car (default is the current date).
- **SeriNumarasi**: The serial number of the car (required).
- **Marka**: The brand of the car (required).
- **Model**: The model of the car (required).
- **Renk**: The color of the car (required).
- **KapiSayisi**: The number of doors on the car (must be a non-negative integer).

### Properties
### KapiSayisi Validation
The `KapiSayisi` property includes validation to ensure that the number of doors cannot be negative. An `ArgumentException` is thrown if an invalid value is provided.

## Program Flow
1. The program prompts the user to create a car.
2. If the user agrees, they are asked to input the car's details.
3. The program validates the input and creates a new `Araba` object, which is added to a list.
4. The user is then asked if they want to create another car or view the list of created cars.