# ShipRepository

## Task:

This application will allow the user to perform CRUD (Create, Read, Update & Delete) operations on a ship.<br />

Ship Model:<br />
-> Name (string)<br />
-> Length (in meters)<br />
-> Width (in meters)<br />
-> Code (a string with a format of AAAA-1111-A1 where A is any character from the Latin alphabet and 1 is a number from 0 to 9).<br />

### Prerequisites
-> .Net 8 https://dotnet.microsoft.com/en-us/download/dotnet/8.0 <br />

### Packages Used
-> FluentValidation<br />
-> Microsoft.EntityFrameworkCore.InMemory<br />
-> Swashbuckle.AspNetCore.Swagger<br />

### How to Run the Project
-> Clone the repository <br />
-> At the ship-api/API/ directory, restore required packages by running: `dotnet restore` <br />
-> Build the solution `dotnet build` <br />
-> Run project `dotnet run` <br />
-> Launch https://localhost:{port}/swagger in your browser to view the Swagger documentation. <br />



