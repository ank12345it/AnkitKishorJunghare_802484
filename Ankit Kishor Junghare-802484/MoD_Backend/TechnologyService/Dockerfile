FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["TechnologyService/TechnologyService.csproj", "TechnologyService/"]
RUN dotnet restore "TechnologyService/TechnologyService.csproj"
COPY . .
WORKDIR "/src/TechnologyService"
RUN dotnet build "TechnologyService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TechnologyService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TechnologyService.dll"]