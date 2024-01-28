# ShipRepository

## Task:

This application will allow the user to perform CRUD (Create, Read, Update & Delete) operations on a ship. 

Ship Model:
-> Name (string)
-> Length (in meters)
-> Width (in meters)
-> Code (a string with a format of AAAA-1111-A1 where A is any character from the Latin alphabet and 1 is a number from 0 to 9).

### Packages Used
-> FluentValidation
-> Microsoft.EntityFrameworkCore.InMemory
-> Swashbuckle.AspNetCore.Swagger

### How to Run the Project
-> Clone the repository 
-> At the ship-api/API/ directory, restore required packages by running: `dotnet restore`
-> Build the solution `dotnet build`
-> Run project `dotnet run`
-> Launch https://localhost:{port}/swagger in your browser to view the Swagger documentation.



