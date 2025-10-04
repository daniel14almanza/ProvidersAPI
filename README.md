# My .NET Core API

## Table of Contents

- [Prerequisites](#prerequisites)
- [Setup](#setup)
- [Build and Run](#build-and-run)
- [Test the API](#test-the-api)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)


---

## Prerequisites

Before you start, make sure you have installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (or your version)
- Optional: IDE like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

---

## Setup

1. **Clone the repository**

```bash
git clone https://github.com/username/dotnet-api.git
cd dotnet-api

2.Restore dependencies

dotnet restore

Build and Run

Build the project

dotnet build


Run the API

dotnet run


By default, the API will run on:

https://localhost:5001

http://localhost:5000

Optional: Run in development mode with hot reload

dotnet watch run

Test the API

You can test your endpoints using tools like Postman
 or curl:

curl https://localhost:5001/weatherforecast


Or open a browser at https://localhost:5001/swagger if Swagger is configured.

Project Structure

Typical .NET Core API layout:

/MyDotnetApi
├── Controllers/          # API controllers
├── Models/               # Data models
├── Properties/
│   └── launchSettings.json  # Local launch settings
├── Program.cs            # Entry point
├── Startup.cs            # Configuration
├── MyDotnetApi.csproj    # Project file
├── .gitignore
└── README.md


bin/ and obj/ are generated at build time and should not be committed.

Contributing

Fork the repository.

Create a new branch for your feature or bugfix.

Commit changes with descriptive messages.

Open a Pull Request.

License

This project is licensed under the MIT License. See LICENSE
 for details.
