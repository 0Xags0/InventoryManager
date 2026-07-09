#  Inventory Manager API

A RESTful ASP.NET Core Web API for managing products in an inventory system. The application allows users to create, retrieve, update, and delete products while storing data in SQL Server using Entity Framework Core.

---

##  Table of Contents

- Features
- Technologies Used
- Architecture
- Installation
- Configuration
- Database
- Running the Project
- API Endpoints
- Project Structure
- Future Improvements

---

#  Features

## Product Management

- Create new products
- View all products
- View a product by ID
- Update existing products
- Delete products

## Data Validation

- Prevent invalid product data
- Validate required fields
- Store creation date automatically

## Database Support

- SQL Server integration
- Entity Framework Core
- Code First Migrations

---

#  Technologies Used

- ASP.NET Core 8 Web API
- C#
- Entity Framework Core
- SQL Server
- Swagger (OpenAPI)
- REST API

---

#  Architecture

The project follows a layered architecture.

- Controllers – Handle HTTP requests.
- Models – Represent database entities.
- Data – Database context.
- Entity Framework Core – Database communication.
- SQL Server – Persistent data storage.

---

#  Installation

## Clone repository

```bash
git clone https://github.com/YourUsername/InventoryManager.git
```

Go to the project folder.

```bash
cd InventoryManager
```

---

## Install dependencies

```bash
dotnet restore
```

---

#  Configuration

Open

```
appsettings.json
```

Update your connection string.

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=InventoryManager;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

#  Database

Create the database using Entity Framework migrations.

```bash
dotnet ef database update
```

---

#  Running the project

```bash
dotnet run
```

Swagger will be available at

```
https://localhost:7020/swagger
```

---

#  API Endpoints

## Products

### Get all products

```
GET /api/products
```

### Get product by ID

```
GET /api/products/{id}
```

### Create product

```
POST /api/products
```

Example request:

```json
{
  "name": "iPhone 15",
  "brand": "Apple",
  "description": "256GB Black",
  "price": 1200,
  "quantity": 5
}
```

---

### Update product

```
PUT /api/products/{id}
```

---

### Delete product

```
DELETE /api/products/{id}
```

---

#  Project Structure

```
InventoryManager
│
├── Controllers
│     └── ProductsController.cs
│
├── Data
│     └── ApplicationDbContext.cs
│
├── Models
│     └── Product.cs
│
├── Migrations
│
├── Properties
│
├── appsettings.json
│
└── Program.cs
```

---

#  Future Improvements

- JWT Authentication
- User Roles
- Product Categories
- Search & Filtering
- Pagination
- AutoMapper
- Repository Pattern
- Service Layer
- Unit Testing
- Docker Support

---

#  Learning Goals

This project was created to practice:

- ASP.NET Core Web API
- RESTful API principles
- Entity Framework Core
- SQL Server
- CRUD Operations
- Dependency Injection
- Swagger
- Code First Migrations

---

#  License

This project is intended for learning purposes.
