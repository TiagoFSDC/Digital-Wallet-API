FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY *.sln ./
COPY *.config ./
COPY *.runsettings ./
COPY Bank.Management.Api/Bank.Management.Api.csproj/ Bank.Management.Api/
COPY Bank.Management.Infraestructure.Data.PostgreSQL/Bank.Management.Infraestructure.Data.PostgreSQL.csproj/ Bank.Management.Infraestructure.Data.PostgreSQL/
COPY Bank.Management.Infraestructure.Domain/Bank.Management.Infraestructure.Domain.csproj/ Bank.Management.Infraestructure.Domain/
COPY Bank.Management.Infraestructure.Queries/Bank.Management.Infraestructure.Queries.csproj/ Bank.Management.Infraestructure.Queries/

RUN dotnet tool restore && dotnet restore

COPY . .

WORKDIR /src/Bank.Management.Api
RUN mkdir -p /src/Bank.Management.Api/Swagger/Definition
RUN dotnet build --configuration Release --nologo --no-restore

FROM build AS publish
WORKDIR /src/Bank.Management.Api
RUN dotnet publish --configuration Release --nologo --no-build -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bank.Management.Api.dll"]