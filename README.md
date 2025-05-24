# ASP.NET Core MVC CRUD Project

This is a responsive ASP.NET Core MVC project built with .NET 8 that performs full **CRUD** (Create, Read, Update, Delete) operations using **Entity Framework Core** (Code First approach) with **SQL Server** as the database. It uses **Bootstrap** for styling and layout, and **jQuery** for enhanced interactivity on the client side.

## 🔧 Technologies Used

- **.NET 8**
- **ASP.NET Core MVC**
- **Entity Framework Core** (Code First)
- **SQL Server**
- **Bootstrap 5**
- **jQuery**
- **LINQ**

## 📌 Features

- Full CRUD operations
- Code First database modeling using EF Core
- LINQ queries for data manipulation
- Responsive design with Bootstrap
- Interactive UI enhancements using jQuery
- Clean, maintainable and scalable architecture

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) (or Visual Studio Code)

### Installation

1. Clone the repository:

```bash
git clone https://github.com/your-username/your-repo-name.git
cd your-repo-name
```
Update the database connection string in appsettings.json
```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YourDbName;Trusted_Connection=True;TrustServerCertificate=True;"
}
```
Apply migrations and create the database
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
```
Then open your browser and go to: https://localhost:5001 (or the port shown in console)

📁 Project Structure
```bash
/Controllers     → MVC Controllers
/Models          → EF Core Models
/Views           → Razor Views
/Data            → DB context and configurations
/wwwroot         → Static files (CSS, JS, etc.)
```
✅ TODO
Add authentication and authorization

Add client-side validation

Improve UI with more Bootstrap components

🤝 Contributing
Contributions are welcome! Please open an issue or submit a pull request.

📄 License
This project is licensed under the MIT License - see the LICENSE file for details.

👨‍💻 Author: Built with ❤️ by ArManDS
