# CSharpRestfullAPI

![.NET CI](https://github.com/Sebastian90Sonntag/CSharp-Restfull-API/actions/workflows/dotnet.yml/badge.svg)

Ein moderner, schichtbasierter RESTful UserService in C# und .NET 8.

## Features

- **RESTful API** für User-Management
- **Clean Architecture** (Trennung von Domain, Application, Infrastructure)
- **Dependency Injection** und **EF Core**
- **InMemory-Datenbank** für Entwicklung (optional SQLite für Produktion)
- **Swagger/OpenAPI**-Dokumentation
- **xUnit-Tests** mit Moq

## Projektstruktur

```
CSharp-Restfull-API/
├── Controllers/                # API-Endpunkte
├── Domain/                     # Entitäten & Interfaces
├── Infrastructure/             # Datenzugriff (EF Core)
├── Services/                   # Geschäftslogik
├── CSharpRestfullAPI.Tests/    # Unit Tests (xUnit + Moq)
├── Program.cs                  # Einstiegspunkt & DI
├── CSharpRestfullAPI.csproj
└── CSharp-Restfull-API.sln
```

## Schnellstart

```bash
dotnet restore
dotnet build
dotnet run
```

**Swagger UI:** [http://localhost:5000/swagger](http://localhost:5000/swagger) (Port ggf. anpassen)

## Tests

```bash
dotnet test
```

Tests nutzen **xUnit** und **Moq** für Unit-Tests des UserService.

## Beispiel-Endpunkte

| Methode | Endpunkt | Beschreibung |
|---------|----------|--------------|
| `GET` | `/api/users` | Alle User abrufen |
| `GET` | `/api/users/{id}` | User nach ID |
| `POST` | `/api/users` | User anlegen |
| `PUT` | `/api/users/{id}` | User aktualisieren |
| `DELETE` | `/api/users/{id}` | User löschen |

## Datenbank

- **Standard:** InMemory (nur Entwicklung)
- **Produktiv:** SQLite (auskommentiert in `Program.cs`)

## CI

GitHub Actions führt **Build** und **Tests** aus bei jedem Push und PR auf `main`.

---

**Autor:** Sebastian Sonntag · 2025
