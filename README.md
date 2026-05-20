# Employees Console App

Simple .NET console application for managing employees.

The application allows users to:
- Add employees
- Store employee salary information
- List all employees

No persistence/database is used. Data is stored in memory only.

---

# Architecture

The solution follows:
- Object-Oriented Design
- SOLID principles
- Clean Architecture inspired layering
- Basic Domain-Driven Design concepts

Project structure:

```text
Employees.Presentation
Employees.Application
Employees.Domain
Employees.Infrastructure
```

Dependency direction:

```text
Presentation -> Application
Presentation -> Infrastructure

Application -> Domain

Infrastructure -> Application
Infrastructure -> Domain
```

---

# Primitive Obsession

The project avoids primitive obsession by using Value Objects instead of raw primitive types.

# Run the application

```bash
dotnet run
```