# Base image for the runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Build image for the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy the .csproj file and restore dependencies
COPY ["SumOFTwoNumbers.csproj", "."]
RUN dotnet restore "SumOFTwoNumbers.csproj"

# Copy the remaining files and build the project
COPY . . 
RUN dotnet build "SumOFTwoNumbers.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish the application for deployment
FROM build AS publish
RUN dotnet publish "SumOFTwoNumbers.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final stage, copying the published output and setting the entry point
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish . 
ENTRYPOINT ["dotnet", "SumOFTwoNumbers.dll"]
