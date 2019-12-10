#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["TestProject.API/TestProject.API.csproj", "TestProject.API/"]
COPY ["TestProject.Application/TestProject.Application.csproj", "TestProject.Application/"]
COPY ["TestProject.Domain/TestProject.Domain.csproj", "TestProject.Domain/"]
COPY ["TestProject.Infra.CrossCutting.IoC/TestProject.Infra.CrossCutting.IoC.csproj", "TestProject.Infra.CrossCutting.IoC/"]
COPY ["TestsProject.Infra.Data/TestsProject.Infra.Data.csproj", "TestsProject.Infra.Data/"]
RUN dotnet restore "TestProject.API/TestProject.API.csproj"
COPY . .
WORKDIR "/src/TestProject.API"
RUN dotnet build "TestProject.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestProject.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestProject.API.dll"]
