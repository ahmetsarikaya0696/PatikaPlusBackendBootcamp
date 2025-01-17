# Employee Database

This project contains an SQL script to create and manage an employee database.

## Table Structure

The `employee` table consists of the following columns:

- **id**: INTEGER, primary key, auto-incremented
- **name**: VARCHAR(50), name of the employee
- **birthday**: DATE, birth date of the employee
- **email**: VARCHAR(100), email address of the employee

## SQL Script

The SQL script performs the following operations:

1. **Create Table**: Creates the `employee` table with the specified columns.
2. **Insert Data**: Inserts 50 mock employee records into the `employee` table using data from the Mockaroo service.
3. **Update Records**: Updates specific employee records with new values.
4. **Delete Records**: Deletes specific employee records from the table.

## Usage

To execute the SQL script, run it in your SQL database environment. Ensure that you have the necessary permissions to create tables and insert data.
