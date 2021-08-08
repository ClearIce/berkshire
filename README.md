# BHHC Demo

This project utilizes .NET Core 5, Entity Framework Core, Sqlite, particles.js, and React to make a small portfolio page

## EF Core migrations

    dotnet tool install --global dotnet-ef
    dotnet ef database update

## Docker Instructions
    
    docker build -t berkshire:latest .
    docker run -p 80:80 berkshire:latest
