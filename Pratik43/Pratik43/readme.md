# Pratik43 Project

## Overview

This project demonstrates a simple implementation of a blog system using Entity Framework Core with .NET 8. The project includes two main entities: `User` and `Post`, and a database context `PatikaSecondDbContext`.

## Entities

### User

The `User` entity represents a user in the system. It has the following properties:

- `Id` (int): The unique identifier for the user.
- `Username` (string): The username of the user.
- `Email` (string): The email address of the user.
- `Posts` (List<Post>?): A list of posts created by the user.

### Post

The `Post` entity represents a blog post. It has the following properties:

- `Id` (int): The unique identifier for the post.
- `Title` (string): The title of the post.
- `Content` (string): The content of the post.
- `UserId` (int): The identifier of the user who created the post.
- `User` (User): The user who created the post.

## Database Context

### PatikaSecondDbContext

The `PatikaSecondDbContext` class is the database context for the project. It inherits from `DbContext` and includes the following `DbSet` properties:

- `Users` (DbSet<User>): Represents the collection of `User` entities in the database.
- `Posts` (DbSet<Post>): Represents the collection of `Post` entities in the database.

The context is configured through dependency injection using `DbContextOptions<PatikaSecondDbContext>`.