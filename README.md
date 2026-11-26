# Expense Tracker – Web API

A small, secure REST API for tracking personal expenses, built with **.NET 10** and **PostgreSQL**. It is the backend for the [Expense Tracker client web app](https://github.com/Thilrash/expense-tracker-client-web-app).

This is a learning and portfolio project, built step by step. The goal is clean, well-tested code with security practices applied from day one.

> **Status:** 🚧 In development. See the [issues](../../issues) for the roadmap.

## Features (planned)

- Register and log in with JWT authentication (ASP.NET Core Identity)
- Manage expense categories
- Create, read, update and delete expenses
- Filter expenses by date range and category
- Monthly summary endpoint (totals per category)
- Each user can only access their own data

## Tech stack

| Area | Choice |
|---|---|
| Framework | .NET 10 Web API (C#) |
| Database | PostgreSQL |
| ORM | Entity Framework Core with Npgsql |
| Auth | ASP.NET Core Identity + JWT |
| Validation | FluentValidation |
| API docs | OpenAPI / Swagger |
| Tests | xUnit, Testcontainers |
| Containers | Docker, Docker Compose |
| CI/CD | GitHub Actions |

## Security practices

- Passwords hashed by ASP.NET Core Identity
- EF Core parameterized queries (no raw SQL string building)
- Input validation on every request model
- Rate limiting, strict CORS and security headers
- Secrets kept out of Git (environment variables, user secrets)
- Automated checks: Dependabot, CodeQL, Gitleaks, Trivy

## Prerequisites

- [.NET SDK 10](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/) (for the local PostgreSQL database)
- An IDE such as JetBrains Rider or VS Code

## Getting started

Setup instructions will be added as the project is built (see the first issues for the solution scaffold and the local database).

## Project structure (planned)

```
src/
  ExpenseTracker.Api/     # controllers/endpoints, startup, middleware
  ExpenseTracker.Core/    # entities and business logic
  ExpenseTracker.Data/    # EF Core DbContext, migrations
tests/
  ExpenseTracker.Tests/   # unit and integration tests
```

## Related repositories

- Frontend: [expense-tracker-client-web-app](https://github.com/Thilrash/expense-tracker-client-web-app) (Angular)

## License

To be decided.
