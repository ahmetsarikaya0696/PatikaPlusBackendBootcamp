# Pratik42 Project

## Overview

This project is built using .NET 8 and C# 12.0. It includes a simple Entity Framework Core setup with two entities: `Game` and `Movie`.

## Entities

### Game

The `Game` entity represents a game with the following properties:

- `Id` (int): The unique identifier for the game.
- `Name` (string): The name of the game.
- `Platform` (string): The platform on which the game is available.
- `Rating` (decimal): The rating of the game.

### Movie

The `Movie` entity represents a movie with the following properties:

- `Id` (int): The unique identifier for the movie.
- `Title` (string): The title of the movie.
- `Genre` (string): The genre of the movie.
- `ReleaseYear` (int): The release year of the movie.

## DbContext

The `PatikaFirstDbContext` is the Entity Framework Core context for the project. It includes the following `DbSet` properties:

- `Games` (DbSet<Game>): The collection of `Game` entities.
- `Movies` (DbSet<Movie>): The collection of `Movie` entities.
