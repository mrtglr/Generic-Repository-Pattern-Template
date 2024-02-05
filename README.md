# Generic Repository Pattern Template

This repository serves as a template for implementing the Generic Repository Pattern in a .NET Core Web API (version 6.0). The template includes a generic entity repository and controller patterns, and it uses PostgreSQL as the database provider. Additionally, a Docker container is set up to run the PostgreSQL database alongside the application.

## Getting Started

### Prerequisites

- [.NET Core 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Docker](https://www.docker.com/get-started)

### Installation

1. Clone the repository:

   ```bash
   docker build -t genericrepopatterndemo .
   ```

2. Build and run the Docker container:

   ```bash
   docker-compose up -d
   ```

## Configuration

The PostgreSQL database connection details can be configured in the `appsettings.json` file.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=YourDatabaseName;Username=YourUsername;Password=YourPassword;"
  },
  // Other configurations...
}
```
