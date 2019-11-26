FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["AuthenticateService/AuthenticateService.csproj", "AuthenticateService/"]
RUN dotnet restore "AuthenticateService/AuthenticateService.csproj"
COPY . .
WORKDIR "/src/AuthenticateService"
RUN dotnet build "AuthenticateService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AuthenticateService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthenticateService.dll"]