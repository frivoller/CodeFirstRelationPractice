# EF Core Code First

This project demonstrates the **Code First** approach using **Entity Framework Core**. The database is named `PatikaCodeFirstDb2` and contains two tables: **Users** and **Posts**. The database interaction is managed through the `PatikaSecondDbContext` class.

## Schema

- **Users Table**:
  - `Id`: Primary key (auto-increment)
  - `Username`: User's username
  - `Email`: User's email address

- **Posts Table**:
  - `Id`: Primary key (auto-increment)
  - `Title`: Post title
  - `Content`: Post content
  - `UserId`: Foreign key to the `Users` table

---

## Setup

1. **Install Required Packages**:
   Install the necessary NuGet packages for **Npgsql** (PostgreSQL provider) and **EF Core Tools**:

   ```bash
   dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
   dotnet add package Microsoft.EntityFrameworkCore.Tools