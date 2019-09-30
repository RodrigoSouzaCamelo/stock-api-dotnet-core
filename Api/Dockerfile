FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY . .
RUN dotnet restore

# Copy everything else and build
RUN dotnet publish Api/Api.csproj -c Release -o out

# Migrating the Database
RUN dotnet ef database update --project Api/Api.csproj

# Copy the created database
RUN cp Api/stock.db Api/out/stock.db

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build-env /app/Api/out .
ENTRYPOINT ["dotnet", "Api.dll"]