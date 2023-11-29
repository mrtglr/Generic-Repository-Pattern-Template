# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./Generic-Repo-Pattern-Demo.csproj" --disable-parallel
RUN dotnet publish "./Generic-Repo-Pattern-Demo.csproj" -c release -o /app --no-restore

# Final Stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./

ENTRYPOINT ["dotnet", "Generic-Repo-Pattern-Demo.dll"]