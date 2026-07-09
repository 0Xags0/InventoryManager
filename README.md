# InventoryManager

InventoryManager is an ASP.NET Core Web API project for managing products in a warehouse or store.

## Features

- Get all products
- Get product by ID
- Create a new product
- Update an existing product
- Delete a product

## Technologies

- ASP.NET Core
- Entity Framework Core
- SQL Server
- Swagger (OpenAPI)
- Git & GitHub

## Project Structure

```
Controllers/
Data/
Migrations/
Models/
Program.cs
```

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | /api/products | Get all products |
| GET | /api/products/{id} | Get product by ID |
| POST | /api/products | Create product |
| PUT | /api/products/{id} | Update product |
| DELETE | /api/products/{id} | Delete product |

## Future Improvements

- Async/Await
- DTO
- Validation
- Service Layer
- Repository Pattern
- JWT Authentication

## Author

Created by Xags.
