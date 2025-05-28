# CSharpRestfullAPI

Ein moderner, schichtbasierter RESTful UserService in C# und .NET 8.

## Features

- **RESTful API** für User-Management
- **Clean Architecture** (Trennung von Domain, Application, Infrastructure)
- **Dependency Injection** und **EF Core**
- **InMemory-Datenbank** für Entwicklung (optional SQLite für Produktion)
- **Swagger/OpenAPI**-Dokumentation

## Projektstruktur

```markdown
CSharp-Restfull-API/
│
├── Controllers/           # API-Endpunkte
├── Domain/                # Entitäten & Interfaces
├── Infrastructure/        # Datenzugriff (EF Core)
├── Services/              # Geschäftslogik
├── Program.cs             # Einstiegspunkt & DI
├── CSharpRestfullAPI.csproj
└── CSharp-Restfull-API.sln
```

## Schnellstart

1. **Abhängigkeiten installieren**

   ```bash
   dotnet restore
   ```

2. **Projekt bauen**

   ```bash
   dotnet build
   ```

3. **Starten**

   ```bash
   dotnet run
   ```

4. **Swagger UI**
   - Im Browser öffnen: [http://localhost:5000/swagger](http://localhost:5000/swagger) (Port ggf. anpassen)

## Datenbank

- **Standard:** InMemory (nur Entwicklung)
- **Produktiv:** SQLite (auskommentiert in `Program.cs`)

## Beispiel-Endpunkte

- `GET /api/users` – Alle User abrufen
- `GET /api/users/{id}` – User nach ID abrufen
- `POST /api/users` – User anlegen
- `PUT /api/users/{id}` – User aktualisieren
- `DELETE /api/users/{id}` – User löschen

## Hinweise

- Für produktiven Einsatz SQLite oder eine andere Datenbank aktivieren.
- Die Architektur ist für Erweiterbarkeit und Testbarkeit ausgelegt.

---

**Autor:**  
Sebastian Sonntag  
2025
