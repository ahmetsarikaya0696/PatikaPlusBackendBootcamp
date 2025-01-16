# DVD Rental Database

This repository contains SQL scripts for managing a DVD rental database. The primary focus is on querying the database to retrieve specific information about films and customers.

## SQL Scripts

### 1. Retrieve Longest Films Ending with 'n'
This query selects the top 5 longest films from the `film` table where the film title ends with the character 'n'.
### 2. Retrieve Shortest Films Ending with 'n'
This query selects the next 5 shortest films (lengths 6 to 10) from the `film` table where the film title ends with the character 'n'.
### 3. Retrieve Customers by Last Name
This query retrieves the first 4 customers from the `customer` table with a `store_id` of 1, ordered by their last names in descending order.
## Usage
To execute these queries, connect to your SQL database and run the scripts in your preferred SQL client.