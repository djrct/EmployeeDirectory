# EmployeeDirectory

EmployeeDirectory is a .NET 9 solution with:

- An ASP.NET Core Web API (`EmployeeDirectory.Api`)
- A Blazor Server web app (`EmployeeDirectory.Web`)
- A shared class library for cross-project models/contracts (`EmployeeDirectory.Shared`)
- An xUnit test project (`EmployeeDirectory.Tests`)

The repository is currently scaffolded with starter templates and is ready for feature development.

## Solution Structure

```text
EmployeeDirectory.sln
|- EmployeeDirectory.Api/        # ASP.NET Core API
|- EmployeeDirectory.Web/        # Blazor Server UI
|- EmployeeDirectory.Shared/     # Shared DTOs/constants/validation
|- EmployeeDirectory.Tests/      # xUnit tests
```

## Prerequisites

- .NET SDK 9.0+
- Visual Studio 2022, VS Code, or JetBrains Rider

Check your SDK:

```powershell
dotnet --version
```

## Restore, Build, and Test

From the repository root:

```powershell
dotnet restore
dotnet build EmployeeDirectory.sln
dotnet test EmployeeDirectory.Tests/EmployeeDirectory.Tests.csproj
```

## CI (feature/add-ci)

This branch is intended to introduce Continuous Integration validation for every change before merge.

### CI Goals

- Restore all dependencies
- Build the full solution (`EmployeeDirectory.sln`)
- Run tests in `EmployeeDirectory.Tests`
- Fail fast on compile or test failures

### Recommended Pipeline Checks

Use these commands in your CI workflow steps:

```powershell
dotnet restore
dotnet build EmployeeDirectory.sln --configuration Release --no-restore
dotnet test EmployeeDirectory.Tests/EmployeeDirectory.Tests.csproj --configuration Release --no-build --verbosity normal
```

### Branch and PR Strategy

- Run CI on pushes to `main` and `feature/add-ci`
- Run CI on pull requests targeting `main`
- Require successful CI status before merge

### Badge Placeholder

Add this after creating your workflow (replace `build.yml` if you choose another name):

```markdown
![CI](https://github.com/djrct/EmployeeDirectory/actions/workflows/build.yml/badge.svg)
```

### Suggested Workflow Name

- `build.yml`
- Job name: `build-and-test`
- Runner: `ubuntu-latest`
- .NET SDK: `9.0.x`

## Run the API

Start the API project:

```powershell
dotnet run --project EmployeeDirectory.Api
```

Default local URLs (from launch settings):

- `http://localhost:5002`
- `https://localhost:7294`

Starter endpoint:

- `GET /EmployeeController`

OpenAPI document is available in Development at:

- `/openapi/v1.json`

## Run the Web App

Start the Blazor Server app:

```powershell
dotnet run --project EmployeeDirectory.Web
```

Default local URLs (from launch settings):

- `http://localhost:5088`
- `https://localhost:7191`

The web app currently contains starter pages (`Home`, `Counter`, `Weather`).

## Development Tips

Use hot reload during development:

```powershell
dotnet watch --project EmployeeDirectory.Api
dotnet watch --project EmployeeDirectory.Web
```

Run each command in a separate terminal when running API and Web together.

## Current Status

- Shared project folders are scaffolded for `DTOs`, `Constants`, and `Validation`.
- API and Web projects both reference `EmployeeDirectory.Shared`.
- Test project is configured with xUnit and coverlet collector.

## Next Suggested Milestones

1. Define core employee domain models and DTOs in `EmployeeDirectory.Shared`.
2. Replace template API endpoints with employee CRUD endpoints.
3. Connect Blazor pages to API endpoints.
4. Add meaningful unit/integration tests.
5. Add CI checks for build and test validation.
