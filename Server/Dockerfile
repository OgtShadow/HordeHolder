# ---------- BUILD ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# kopiujemy csproj i restore (cache)
COPY *.csproj .
RUN dotnet restore

# kopiujemy resztę i build
COPY . .
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false


# ---------- RUNTIME ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "Server.dll"]
