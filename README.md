# CSharp RESTful API

![.NET](https://img.shields.io/badge/.NET_8-512BD4?style=flat&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=flat&logo=swagger&logoColor=black)

Ein moderner, schichtbasierter RESTful UserService in C# und .NET 8.

## Features

- **RESTful API** für User-Management (CRUD)
- **Clean Architecture** (Trennung von Domain, Application, Infrastructure)
- **Dependency Injection** und **EF Core**
- **InMemory-Datenbank** für Entwicklung (optional SQLite für Produktion)
- **Swagger/OpenAPI**-Dokumentation

## Projektstruktur

```
CSharp-Restfull-API/
├── Controllers/           # API-Endpunkte
├── Domain/                # Entitäten & Interfaces
├── Infrastructure/        # Datenzugriff (EF Core)
├── Services/              # Geschäftslogik
├── Program.cs             # Einstiegspunkt & DI
├── CSharpRestfullAPI.csproj
└── CSharp-Restfull-API.sln
```

## Schnellstart

```bash
# Abhängigkeiten installieren
dotnet restore

# Projekt bauen
dotnet build

# Starten
dotnet run
```

Swagger UI: [http://localhost:5000/swagger](http://localhost:5000/swagger) (Port ggf. anpassen)

## API-Endpunkte

| Methode | Endpunkt | Beschreibung |
|---------|----------|--------------|
| `GET` | `/api/users` | Alle User abrufen |
| `GET` | `/api/users/{id}` | User nach ID abrufen |
| `POST` | `/api/users` | User anlegen |
| `PUT` | `/api/users/{id}` | User aktualisieren |
| `DELETE` | `/api/users/{id}` | User löschen |

## Datenbank

- **Standard:** InMemory (nur Entwicklung)
- **Produktiv:** SQLite (konfigurierbar in `Program.cs`)

## Hinweise

- Für produktiven Einsatz SQLite oder eine andere Datenbank aktivieren
- Die Architektur ist für Erweiterbarkeit und Testbarkeit ausgelegt

---

**Autor:** Sebastian Sonntag — 2025
