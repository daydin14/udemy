# Posts: A Blazor Server Side Application

[![Blazor Server Side](https://img.shields.io/badge/Blazor-Server%20Side-brightgreen)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![.NET](https://img.shields.io/badge/.NET-7.0-blue)](https://dotnet.microsoft.com/)
[![Bootstrap](https://img.shields.io/badge/Bootstrap-v5.3.0-blueviolet)](https://getbootstrap.com/)

This is a basic Blazor Server Side application that demonstrates how to create interactive web applications using C# and .NET. Blazor Server Side allows you to build web applications with C# on the server and then communicate with the client using SignalR.

## Table of Contents

- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
  - [Creating a new Blazor Server-Side App](#creating-a-new-blazor-server-side-app)
- [Project Structure](#project-structure)
- [Customizing the Application](#customizing-the-application)
- [Additional Resources](#additional-resources)
- [License](#license)

## Prerequisites

Before getting started, make sure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (Version 7.0 recommended)
- [Visual Studio](https://visualstudio.microsoft.com/) (Optional, but recommended for development)
- [Visual Studio Code](https://code.visualstudio.com/) (Optional, for a lightweight development environment)

## Getting Started

1. Clone this repository or create a new Blazor Server Side project using the following command:

   **`Creating a new Blazor Server-Side App`**

   ```bash
   dotnet new blazorserver -n BlazorApp
   cd BlazorApp
   ```

2. Build and run the application:

   ```bash
   dotnet build
   dotnet run | dotnet watch
   ```

3. Open your web browser and navigate to `https://localhost:5001 or port: 7140` to see the application in action. Mine defaulted to `7140`

## Project Structure

The project structure consists of the following main folders and files:

- `Data`: Contains Post model and AppDBContext.cs
- `Pages`: Contains the Razor components that define the pages of the application.
  <small>(`Create`, `Index`, `Update`)</small>
- `wwwroot`: Contains static files, such as CSS, JavaScript, and images.
- `Shared`: Contains MainLayout and NavMenu where links can be updated/modified
- `Program.cs`: Configures the application entry point, Blazor Server application, and services.

## Customizing the Application

Feel free to customize the application by modifying the Razor components in the `Pages` folder. You can also add additional services and functionality as needed in the `Program.cs`.

## Additional Resources

- [Official Blazor Documentation](https://docs.microsoft.com/en-us/aspnet/core/blazor/)
- [Blazor GitHub Repository](https://github.com/dotnet/aspnetcore)
- [Blazor Community](https://learn.microsoft.com/en-us/dotnet/maui/)
