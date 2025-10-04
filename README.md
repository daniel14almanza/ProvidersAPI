
# .NET Core Supplier API

Backend API for managing supplier records (CRUD) 

---

## Prerequisites

- .NET 8 SDK
- Optional: Visual Studio or VS Code

---

## Setup

1. Clone the repository:

    git clone https://github.com/username/dotnet-suppliers.git
    cd dotnet-suppliers

2. Restore dependencies:

    dotnet restore

---

## Build & Run (development)

    dotnet build
    dotnet run

- Default Kestrel URLs:
    https://localhost:5001
    http://localhost:5000

---

## API Summary

- Supplier fields (validated):
  - Legal name, Trade name, Tax ID, Phone, Email, Website, Address, Country, Annual revenue, Last edit timestamp
- Endpoints:
  - `GET /api/Provider`
  - `POST /api/Provider`
  - `GET /api/Provider/{id}`
  - `PUT /api/Provider/{id}`
  - `DELETE /api/Provider/{id}`

## Project Structure

/dotnet-suppliers
    Controllers/
    Models/
    Services/
    Properties/
        launchSettings.json
    Program.cs
    Startup.cs
    dotnet-suppliers.csproj
    README.md

