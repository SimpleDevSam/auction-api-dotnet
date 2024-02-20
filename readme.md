# [Your Project Name]

## Description
This is a project of an API which handled Auction events. It is built using .NET with Entity Framework Core 8.02 for data access, ASP.NET Identity for authentication and user management, and SQLite as the database. The project includes a comprehensive suite of unit tests using Xunit, FluentAssertions, BOGUS, and Moq. API documentation is provided via Swagger.

## Getting Started

### Prerequisites
- .NET [appropriate version]
- A text editor or an IDE (like Visual Studio)
- SQLite

### Installing
1. Clone the repository
2. Navigate to the project directory and restore the .NET packages:

### Configuring the Database
- Ensure SQLite is installed and configured on your machine.
- Update the connection string in `appsettings.json` if necessary.

### Running the Application
1. Build and run the application: 
dotnet build
dotnet run

## Testing
This project uses Xunit for unit testing, FluentAssertions for more expressive test assertions, BOGUS for generating fake data, and Moq for mocking objects.

To run the tests, use the following command:
dotnet test


## API Documentation
API documentation is available through Swagger. Once the application is running, navigate to:
http://localhost:[port]/swagger


## Built With
- [.NET](https://dotnet.microsoft.com/)
- [Entity Framework Core 8.02](https://docs.microsoft.com/en-us/ef/core/)
- [ASP.NET Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity)
- [SQLite](https://www.sqlite.org/index.html)
- [Xunit](https://xunit.net/)
- [FluentAssertions](https://fluentassertions.com/)
- [BOGUS](https://github.com/bchavez/Bogus)
- [Moq](https://github.com/moq/moq4)
- [Swagger](https://swagger.io/)
