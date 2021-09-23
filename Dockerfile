FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src

COPY ["DashboardTestApi/DashboardTestApi.csproj", "DashboardTestApi/"]

RUN dotnet add DashboardTestApi package  DevExpress.AspNetCore.Dashboard -s https://nuget.devexpress.com/meeVRd9J5vbFjhxQ2sUWMKg1dUwRRROtwjFd2Zgj4h1TVJiDbY/api

RUN dotnet restore "DashboardTestApi/DashboardTestApi.csproj"
COPY . .
WORKDIR "/src/DashboardTestApi"



RUN dotnet build "DashboardTestApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DashboardTestApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DashboardTestApi.dll"]