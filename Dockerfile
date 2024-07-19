#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Rest.Api/Api.RestCountries/Api.RestCountries.csproj", "Rest.Api/Api.RestCountries/"]
COPY ["Rest.Api/Client/Client.csproj", "Rest.Api/Client/"]
COPY ["Rest.Api/Models/Models.csproj", "Rest.Api/Models/"]
RUN dotnet restore "./Rest.Api/Api.RestCountries/./Api.RestCountries.csproj"
COPY . .
WORKDIR "/src/Rest.Api/Api.RestCountries"
RUN dotnet build "./Api.RestCountries.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Api.RestCountries.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.RestCountries.dll"]