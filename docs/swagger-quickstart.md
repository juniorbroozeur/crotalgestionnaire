# Swagger quickstart (Admin API)

## Lancer localement

```bash
dotnet restore src/AdminApi/AdminApi.csproj
dotnet run --project src/AdminApi/AdminApi.csproj
```

## URL Swagger

Ouvrez:

- `https://localhost:5001/swagger`
- ou `http://localhost:5000/swagger`

## Endpoints de démonstration

- `GET /api/files`
- `POST /api/files`
- `POST /api/files/{id}/validate-step`

Ces endpoints servent à visualiser les contrats DTO dans Swagger pendant la Phase 2.
